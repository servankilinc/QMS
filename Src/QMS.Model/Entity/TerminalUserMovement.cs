namespace QMS.Model.Entity;

public class TerminalUserMovement
{
    public Guid Id { get; set; }
    public Guid TerminalUserId { get; set; } 
    public int MovementTypeId { get; set; }
    public string? PcInfo { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public TimeSpan? Duration { get; set; }
    public virtual TerminalUser TerminalUser { get; set; } = null!;
    public virtual TerminalUserMovementType MovementType { get; set; } = null!;
}
