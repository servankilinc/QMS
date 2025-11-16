namespace QMS.Model.Entity;

public class UnitQueueTypeSetting
{
    public Guid Id { get; set; }
    /// <summary>
    /// Farklı branchlerin aynı unitleri farklı yönetebilsin diye eklendi yoksa unitId den yola çıkarak branch bulunabilir
    /// </summary>
    public Guid BranchId { get; set; }
    public Guid UnitId { get; set; }
    public int QueueTypeId { get; set; }

    public bool UseTheseSettings { get; set; }
    public bool ResetNumberEndOfDay { get; set; }
    public int Priority { get; set; }
    public bool OnlineAppointment { get; set; }
    public int OnlineAppointmentFrequency { get; set; }
    public int OnlineAppointmentAfterDay { get; set; }
    public string? NumberLetter { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    public int MaxClientCount { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
}