namespace QMS.Model.Entity;

public class TerminalUserMovement
{
    public Guid Id { get; set; }
    public Guid TerminalUserId { get; set; } 
    public int MovementTypeId { get; set; }
    public string? PcUniqueInfo { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public DateTime Date { get; set; }
    public virtual TerminalUser TerminalUser { get; set; } = null!;
    public virtual TerminalUserMovementType MovementType { get; set; } = null!;
}
