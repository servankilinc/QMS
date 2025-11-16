namespace QMS.Model.Entity;

public class Unit
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int Priority { get; set; }

    public virtual ICollection<BankoUnitMap>? BankoUnitMaps { get; set; }
    public virtual ICollection<BranchUnitMap>? BranchUnitMaps { get; set; }
    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
    public virtual ICollection<KioskUnitMap>? KioskUnitMaps { get; set; }
    public virtual ICollection<UnitQueueTypeSchedule>? UnitQueueTypeSchedules { get; set; }
    public virtual ICollection<UnitQueueTypeSetting>? UnitQueueTypeSettings { get; set; }
    public virtual ICollection<UnitSchedule>? UnitSchedules { get; set; }
}
