namespace QMS.Model.Entity;

public class MainDisplay
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public int MainDisplayTypeId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual MainDisplayType MainDisplayType { get; set; } = null!;
    public virtual MainDisplayTv? MainDisplayTv { get; set; }
    public virtual MainDisplayBoard? MainDisplayBoard { get; set; }
    public virtual ICollection<MainDisplayBankoMap>? MainDisplayBankoMaps { get; set; }
}
