namespace QMS.Model.Entity;

public class QueueMovement
{
    public Guid Id { get; set; }
    public Guid QueueId { get; set; }
    public Guid? TerminalUserId { get; set; }
    public Guid UnitId { get; set; }
    public int MovementTypeId { get; set; }
    public int StatusTypeId { get; set; }

    #region Transfer Movement Type Props
    public int? TransferTypeId { get; set; }
    #endregion

    #region Call Movement Type Props
    public int? CallTypeId { get; set; }
    public Guid? PagerId { get; set; }
    public int? Number { get; set; } 
    #endregion

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
    public virtual TransferType? TransferType { get; set; }
    public virtual CallType? CallType { get; set; }
    public virtual Pager? Pager { get; set; }
}