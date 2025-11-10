namespace QMS.Model.Entity;

public class Weekday
{
    /// <summary>
    /// DayOfWeek { 0:pz => 1: pzt => ..., 6 => cts }
    /// </summary>
    public int Index { get; set; }
    public string Name { get; set; } = null!;
    public string ShortName { get; set; } = null!;
    public ICollection<UnitSequence>? UnitSequences { get; set; }
    public ICollection<UnitQueueTypeSequence>? UnitQueueTypeSequences { get; set; }
}


// kiosk - branch
// kiosk - unit (n-n)
// kiosk - queuetype (n-n) 