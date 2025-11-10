namespace QMS.Model.Entity;

public class KioskUnitMap
{
    public Guid KioskId { get; set; }
    public Guid UnitId { get; set; }
    public virtual Kiosk Kiosk { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
}
// kiosk - branch
// kiosk - unit (n-n)
// kiosk - queuetype (n-n) 