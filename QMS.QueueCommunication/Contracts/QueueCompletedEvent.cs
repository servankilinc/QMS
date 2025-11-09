namespace QMS.QueueCommunication.Contracts;

public record QueueCompletedEvent
{
    public Guid QueueMovementId { get; init; }
    public int UnitId { get; init; }
    public int TerminalUserId { get; init; }
    public Guid CorrelationId { get; init; }
    public DateTime EventDate { get; init; } = DateTime.Now;
    public string Message { get; set; } = string.Empty;
}