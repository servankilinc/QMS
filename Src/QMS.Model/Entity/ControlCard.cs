namespace QMS.Model.Entity;

public class ControlCard
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Name { get; set; } = null!;
    public string Ip { get; set; } = null!;
    public int Port { get; set; }
    public virtual Branch Branch { get; set; } = null!;
}