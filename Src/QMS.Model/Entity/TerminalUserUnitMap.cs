namespace QMS.Model.Entity;

public class TerminalUserUnitMap
{
    public Guid TerminalUserId { get; set; }
    public Guid UnitId { get; set; }

    public virtual TerminalUser TerminalUser { get; set; } = null!;
    public virtual Unit Unit { get; set; } = null!;
}
