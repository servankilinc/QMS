namespace QMS.Model.Entity;

public class BranchQueueTypeMap
{
    public Guid BranchId { get; set; }
    public int QueueTypeId { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
}