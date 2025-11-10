namespace QMS.Model.Entity;

public class QueueType
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int Priority { get; set; }

    public virtual ICollection<Queue>? Queues { get; set; }
    public virtual ICollection<BranchQueueTypeMap>? BranchQueueTypeMaps { get; set; }
}
