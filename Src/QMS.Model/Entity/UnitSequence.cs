namespace QMS.Model.Entity;

public class UnitSequence
{
    public Guid Id { get; set; }
    /// <summary>
    /// Farklı branchlerin aynı unitleri farklı yönetebilsin diye eklendi yoksa unitId den yola çıkarak branch bulunabilir
    /// </summary>
    public Guid BranchId { get; set; }
    public Guid UnitId { get; set; }
    public Guid QueueTypeId { get; set; }
    public int WeekDayIndex { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public bool IsActive { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
    public virtual Weekday Weekday { get; set; } = null!;
}


// kiosk - branch
// kiosk - unit (n-n)
// kiosk - queuetype (n-n) 