namespace QMS.Model.Entity;

public class UnitQueueTypeSettings
{
    public Guid Id { get; set; }
    /// <summary>
    /// Farklı branchlerin aynı unitleri farklı yönetebilsin diye eklendi yoksa unitId den yola çıkarak branch bulunabilir
    /// </summary>
    public Guid BranchId { get; set; }
    public Guid UnitId { get; set; }
    public Guid QueueTypeId { get; set; }
    public bool UseTheseSettings { get; set; }
    /// <summary>
    /// False durumunda gün sonu gelince sıfırlar
    /// </summary>
    public bool ResetNumberOnlyMaxCount { get; set; }
    public int Priority { get; set; }
    public string? NumberLetter { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    public int MaxClientCount { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
}


// kiosk - branch
// kiosk - unit (n-n)
// kiosk - queuetype (n-n) 