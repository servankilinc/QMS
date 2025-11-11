namespace QMS.Model.Entity;

public class Pager
{
    public Guid Id { get; set; }
    /// <summary>
    /// çağrı cihazı sadece seçilen branch'te tanımlı bankolarla ilişkilendirilebilir
    /// </summary>
    public Guid BranchId { get; set; }
    public int PagerTypeId { get; set; }
    public Guid ConverterId { get; set; }
    public string Name { get; set; } = null!;
    // çağrı cihazı iletişim bilgileri
    /// <summary>
    /// seri haberleşme için cihaz indexi (COM1=1, COM2=2,...)
    /// </summary>
    public int DeviceIndex { get; set; }
    public string? DeviceIp { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual PagerType PagerType { get; set; } = null!;
    public virtual Converter Converter { get; set; } = null!;
    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
    public virtual ICollection<BankoPagerMap>? BankoPagerMaps { get; set; }
}
