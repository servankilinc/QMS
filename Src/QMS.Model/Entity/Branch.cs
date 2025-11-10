namespace QMS.Model.Entity;

public class Branch
{
    public Guid Id { get; set; }
    public Guid CenterId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Center Center { get; set; } = null!;
    public virtual ICollection<BranchUnitMap>? BranchUnitMaps { get; set; }
    public virtual ICollection<BranchQueueTypeMap>? BranchQueueTypeMaps { get; set; }
    public virtual ICollection<Queue>? Queues { get; set; }
    public virtual ICollection<TerminalUser>? TerminalUsers { get; set; }
    public virtual ICollection<Banko>? Bankos { get; set; }
    public virtual ICollection<Display>? Displays { get; set; }
    public virtual ICollection<BranchParameter>? BranchParameters { get; set; }
}