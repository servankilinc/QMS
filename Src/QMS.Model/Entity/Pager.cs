namespace QMS.Model.Entity;

public class Pager
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<BankoPagerMap>? BankoPagerMaps { get; set; }
}
