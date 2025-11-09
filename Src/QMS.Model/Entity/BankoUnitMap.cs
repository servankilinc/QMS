namespace QMS.Model.Entity;

public class BankoUnitMap
{
    public Guid BankoId { get; set; }
    public Guid UnitId { get; set; }
    public virtual Banko Banko { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
}
