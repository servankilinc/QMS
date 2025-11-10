namespace QMS.Model.Entity;

public class KioskQueueTypeMap
{
    public Guid KioskId { get; set; }
    public Guid QueueTypeId { get; set; }
    public virtual Kiosk Kiosk { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
}

// kiosk - branch
// kiosk - unit (n-n)
// kiosk - queuetype (n-n) 