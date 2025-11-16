namespace QMS.Model.Entity;

public class Kiosk
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual ICollection<KioskUnitMap>? KioskUnitMaps { get; set; }
    /// <summary>
    /// kiosk branch de tanımlı olan kuyruk tipleri doğrudan kullanmayabilir özelleştirilebilir
    /// </summary>
    public virtual ICollection<KioskQueueTypeMap>? KioskQueueTypeMaps { get; set; }
}
