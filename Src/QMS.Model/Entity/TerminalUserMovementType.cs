namespace QMS.Model.Entity;

public class TerminalUserMovementType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<TerminalUserMovement>? TerminalUserMovements { get; set; }
}