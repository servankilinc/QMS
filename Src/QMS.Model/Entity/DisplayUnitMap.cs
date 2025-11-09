namespace QMS.Model.Entity;

public class DisplayUnitMap
{
    public Guid DisplayId { get; set; }
    public Guid UnitId { get; set; }

    public virtual Display Display { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
}
