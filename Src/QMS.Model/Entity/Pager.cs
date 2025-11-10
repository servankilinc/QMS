namespace QMS.Model.Entity;

public class Pager
{
    public Guid Id { get; set; }
    public int PagerTypeId { get; set; }
    public string Name { get; set; } = null!;
    public virtual PagerType PagerType { get; set; } = null!;
    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
    public virtual ICollection<BankoPagerMap>? BankoPagerMaps { get; set; }
}

public class PagerType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Pager>? Pagers { get; set; }
}
