namespace QMS.Model.Entity;

public class Banko
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid DisplayId { get; set; }
    public string Name { get; set; } = null!;
    public int Priority { get; set; }

    public virtual Branch Branch { get; set; } = null!;
    public virtual Display? Display { get; set; }
    public virtual ICollection<TerminalUserBankoMap>? BankoTerminalUserMaps { get; set; }
    public virtual ICollection<BankoPagerMap>? BankoPagerMaps { get; set; }
    public virtual ICollection<BankoUnitMap>? BankoUnitMaps { get; set; }
    public virtual ICollection<MainDisplayBankoMap>? MainDisplayBankoMaps { get; set; }
}
