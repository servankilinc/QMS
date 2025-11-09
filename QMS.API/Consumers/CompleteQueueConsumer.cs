using MassTransit;
using QMS.Business.Abstract;
using QMS.QueueCommunication.Contracts;

namespace QMS.API.Consumers;

public class CompleteQueueConsumer(IQueueService _queueService, IPublishEndpoint _publishEndpoint) : IConsumer<CompleteQueueCommand>
{
    public async Task Consume(ConsumeContext<CompleteQueueCommand> context)
    {
        var result = _queueService.Complete(context.Message.QueueMovementId, context.Message.TerimanlUserId);

        await _publishEndpoint.Publish(new QueueCompletedEvent
        {
            QueueMovementId = result.Item1.Id,
            UnitId = result.Item2.UnitId,
            TerminalUserId = result.Item2.TerminalUserId,
            Message = $"Sayın {result.Item1.Lieble.Name} işleminiz tamamlanmıştır. No : {result.Item2.Number}",
            CorrelationId = context.Message.CorrelationId,
            EventDate = DateTime.Now,
        });
    }
}
