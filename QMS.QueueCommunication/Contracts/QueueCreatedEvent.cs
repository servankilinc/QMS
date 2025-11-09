namespace QMS.QueueCommunication.Contracts;

public record QueueCreatedEvent
{
    public Guid QueueId { get; init; }
    public string LiebleTCKNO { get; init; } = string.Empty;
    public string LiebleName { get; init; } = string.Empty;
    public int UnitId { get; init; }
    public Guid CorrelationId { get; init; }
    public DateTime EventDate { get; init; } = DateTime.Now;
    public string Message { get; set; } = string.Empty;
}
