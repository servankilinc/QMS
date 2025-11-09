namespace QMS.QueueCommunication.Contracts;

public record CallNumberCommand
{
    public Guid QueueMovementId { get; init; }
    public int TerimanlUserId { get; init; }

    public Guid CorrelationId { get; init; } = Guid.NewGuid();
    public DateTime CalledAt { get; init; } = DateTime.Now;
}
