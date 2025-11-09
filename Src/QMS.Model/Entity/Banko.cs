namespace QMS.Model.Entity;

public class Banko
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual ICollection<TerminalUserBankoMap>? BankoTerminalUserMaps { get; set; }
    public virtual ICollection<BankoPagerMap>? BankoPagerMaps { get; set; }
    public virtual ICollection<BankoUnitMap>? BankoUnitMaps { get; set; }
}
