namespace QMS.Model.Entity;
/// <summary>
/// birimlerin sıra tipleri ile çalışma saatleri (personel, çağırabilmesi vs. süreçlerinde)
/// </summary>
public class UnitSchedule
{
    public Guid Id { get; set; }
    /// <summary>
    /// Farklı branchlerin aynı unitleri farklı yönetebilsin diye eklendi yoksa unitId den yola çıkarak branch bulunabilir
    /// </summary>
    public Guid BranchId { get; set; }
    public Guid UnitId { get; set; }
    public int QueueTypeId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public bool IsActive { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
}