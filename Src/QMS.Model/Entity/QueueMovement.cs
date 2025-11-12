namespace QMS.Model.Entity;

public class QueueMovement
{
    public Guid Id { get; set; }
    public Guid QueueId { get; set; }
    public Guid? TerminalUserId { get; set; }
    public Guid UnitId { get; set; }
    public int MovementTypeId { get; set; }
    public int StatusTypeId { get; set; }
    public Guid TransferId { get; set; }

    public DateTime Date { get; set; }
    
    /// <summary>
    /// Null ise bir sonraki harket kaydı açıldığı an yazabilir veya bir sonraki hareketin başlamasını bekletmeden de hareketi bitirebilir
    /// </summary>
    public DateTime? ClosingDate { get; set; }

    /// <summary>
    /// ClosingDate değiştiğ zaman set edilmeli
    /// </summary>
    public TimeSpan? Duration { get; set; }

    public virtual Queue Queue { get; set; } = null!;
    public virtual TerminalUser? TerminalUser { get; set; }
    public virtual QueueMovementType MovementType { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueMovementStatusType StatusType { get; set; } = null!;
    public virtual Transfer? Transfer { get; set; }
}
