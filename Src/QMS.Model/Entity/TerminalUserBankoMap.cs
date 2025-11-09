namespace QMS.Model.Entity;

public class TerminalUserBankoMap
{
    public Guid BankoId { get; set; }
    public Guid TerminalUserId { get; set; }
    public virtual Banko Banko { get; set; } = null!;
    public virtual TerminalUser TerminalUser { get; set; } = null!;
}