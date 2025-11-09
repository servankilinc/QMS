namespace QMS.Model.Entity;

public class BankoPagerMap
{
    public Guid BankoId { get; set; }
    public Guid PagerId { get; set; }
    public virtual Banko Banko { get; set; } = null!;
    public virtual Pager Pager { get; set; } = null!;
}
