namespace QMS.Model.Entity;

public class MainDisplayBankoMap
{
    public Guid MainDisplayId { get; set; }
    public Guid BankoId { get; set; }

    public virtual MainDisplay MainDisplay { get; set; } = null!;
    public virtual Banko Banko { get; set; } = null!;
}
