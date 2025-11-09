namespace QMS.Model.Entity;

public class BranchUnitMap
{
    public Guid BranchId { get; set; }
    public Guid UnitId { get; set; }
    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
}