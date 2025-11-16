namespace QMS.Model.Entity;

public class QueueType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Priority { get; set; }

    public virtual ICollection<Queue>? Queues { get; set; }
    public virtual ICollection<BranchQueueTypeMap>? BranchQueueTypeMaps { get; set; }
    /// <summary>
    /// kiosk branch de tanımlı olan kuyruk tipleri doğrudan kullanmayabilir özelleştirilebilir
    /// </summary>
    public virtual ICollection<KioskQueueTypeMap>? KioskQueueTypeMaps { get; set; }
    public virtual ICollection<UnitQueueTypeSchedule>? UnitQueueTypeSchedules { get; set; }
    public virtual ICollection<UnitQueueTypeSetting>? UnitQueueTypeSettings { get; set; }
    public virtual ICollection<UnitSchedule>? UnitSchedules { get; set; }
}
