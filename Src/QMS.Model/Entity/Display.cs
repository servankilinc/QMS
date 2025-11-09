namespace QMS.Model.Entity;

public class Display
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual ICollection<DisplayUnitMap>? DisplayUnitMaps { get; set; }
}
