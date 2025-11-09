namespace QMS.QueueCommunication.Contracts;

public record TakeNumberCommand
{
    public string TCKNO { get; init; } = null!;
    public int UnitId { get; init; }

    public Guid CorrelationId { get; init; } = Guid.NewGuid();
    public DateTime RequestedAt { get; init; } = DateTime.Now;
}
