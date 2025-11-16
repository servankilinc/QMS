namespace QMS.Model.Entity;

public class TerminalUser
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
    public virtual ICollection<TerminalUserBankoMap>? BankoTerminalUserMaps { get; set; }
    public virtual ICollection<TerminalUserMovement>? TerminalUserMovements { get; set; }
}
