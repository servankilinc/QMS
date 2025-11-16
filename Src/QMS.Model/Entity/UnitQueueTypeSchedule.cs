namespace QMS.Model.Entity;

/// <summary>
/// birimlerin sıra tipleri ile belirli zaman aralıklarında sıra verebilme ayarları
/// </summary>
public class UnitQueueTypeSchedule
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
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    public int MaxClientCount { get; set; }
    public bool IsActive { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
}