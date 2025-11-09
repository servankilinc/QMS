using MassTransit;
using QMS.Business.Abstract;
using QMS.QueueCommunication.Contracts;

namespace QMS.API.Consumers;

public class CallNumberConsumer(IQueueService _queueService, IPublishEndpoint _publishEndpoint) : IConsumer<CallNumberCommand>
{
    public async Task Consume(ConsumeContext<CallNumberCommand> context)
    {
        var result =  _queueService.Called(context.Message.QueueMovementId, context.Message.TerimanlUserId);

        await _publishEndpoint.Publish(new NumberCalledEvent
        {
            QueueMovementId = result.Item1.Id,
            UnitId = result.Item2.UnitId,
            TerminalUserId = result.Item2.TerminalUserId,
            Message = $"Sayın {result.Item1.Lieble.Name}, {result.Item2.Number} numaralı sıranız geldi.",
            CorrelationId = context.Message.CorrelationId,
            EventDate = DateTime.Now,
        });
    }
}
