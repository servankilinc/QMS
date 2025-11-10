namespace QMS.Model.Entity;

public class Unit
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int Priority { get; set; }

    public virtual ICollection<DisplayUnitMap>? DisplayUnitMaps { get; set; }
    public virtual ICollection<TerminalUserUnitMap>? TerminalUserUnitMaps { get; set; }
    public virtual ICollection<BankoUnitMap>? BankoUnitMaps { get; set; }
    public virtual ICollection<BranchUnitMap>? BranchUnitMaps { get; set; }
}

public class UnitQueueTypeSequence
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
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    public int MaxClientCount { get; set; }
    public bool IsActive { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
    public virtual QueueType QueueType { get; set; } = null!;
    public virtual Weekday Weekday { get; set; } = null!;
}

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

public class Weekday
{
    /// <summary>
    /// DayOfWeek { 0:pz => 1: pzt => ..., 6 => cts }
    /// </summary>
    public int Index { get; set; }
    public string Name { get; set; } = null!;
    public string ShortName { get; set; } = null!;
    public ICollection<UnitQueueTypeSequence>? UnitQueueTypeSequences { get; set; }
}

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
}


// kiosk - branch
// kiosk - unit (n-n)
// kiosk - queuetype (n-n) 