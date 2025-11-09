using MassTransit;
using QMS.Business.Abstract;
using QMS.Model.Entity;
using QMS.QueueCommunication.Contracts;

namespace QMS.API.Consumers;

public class TakeNumberConsumer(IQueueService _queueService, IPublishEndpoint _publishEndpoint): IConsumer<TakeNumberCommand>
{
    public async Task Consume(ConsumeContext<TakeNumberCommand> context)
    {
        Lieble? lieble = _queueService.GetLiebleByTCKNO(context.Message.TCKNO);
        if (lieble is null)
        {
            throw new Exception("Vatandaş Bulunamadı");
        }
        var corelationId = context.CorrelationId ?? Guid.NewGuid();

        var result = _queueService.Add(lieble.Id, context.Message.UnitId, context.Message.RequestedAt);


        await _publishEndpoint.Publish(new QueueCreatedEvent
        {
            LiebleTCKNO = context.Message.TCKNO,
            LiebleName = lieble.Name,
            Message = $"Sayın {lieble.Name}, {result.Item2} numaralı sıranız alınmıştır. Lütfen bekleyiniz.",
            CorrelationId = context.Message.CorrelationId,
            EventDate = DateTime.Now,
            QueueId = result.Item1.Id,
            UnitId = result.Item1.UnitId
        });
    }
}
