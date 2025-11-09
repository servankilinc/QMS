namespace QMS.Model.Entity;

public class TerminalUser
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual ICollection<TerminalUserUnitMap>? TerminalUserUnitMaps { get; set; }
    public virtual ICollection<TerminalUserBankoMap>? BankoTerminalUserMaps { get; set; }
}
