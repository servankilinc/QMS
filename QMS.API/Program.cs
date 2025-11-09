using MassTransit;
using QMS.API.Consumers;
using QMS.QueueCommunication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ------- MASTRANSIT --------
builder.Services.AddMassTransit(busRegConfigrator =>
{
    busRegConfigrator.SetKebabCaseEndpointNameFormatter();

    busRegConfigrator.UsingRabbitMq((busRegContext, cfg) =>
    {
        cfg.Host("localhost", "/", hostConfig =>
        {
            hostConfig.Username("guest");
            hostConfig.Password("guest");
        });

        cfg.ReceiveEndpoint(RabbitMQConstants.TakeNumberQueueName, e =>
        {
            e.ConfigureConsumer<CallNumberConsumer>(busRegContext);
            e.UseMessageRetry(r => r.Interval(3, TimeSpan.FromSeconds(5)));
            e.UseInMemoryOutbox(busRegContext);
        });
        cfg.ReceiveEndpoint(RabbitMQConstants.CallNumberQueueName, e =>
        {
            e.ConfigureConsumer<CallNumberConsumer>(busRegContext);
            e.UseMessageRetry(r => r.Interval(3, TimeSpan.FromSeconds(5)));
            e.UseInMemoryOutbox(busRegContext);
        });
        cfg.ReceiveEndpoint(RabbitMQConstants.CompleteQueueQueueName, e =>
        {
            e.ConfigureConsumer<CallNumberConsumer>(busRegContext);
            e.UseMessageRetry(r => r.Interval(3, TimeSpan.FromSeconds(5)));
            e.UseInMemoryOutbox(busRegContext);
        });
        cfg.ConfigureEndpoints(busRegContext);
    });

    busRegConfigrator.AddConsumers(typeof(Program).Assembly);
});
// ------- MASTRANSIT --------



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
