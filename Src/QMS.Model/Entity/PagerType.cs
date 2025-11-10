namespace QMS.Model.Entity;

public class PagerType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Pager>? Pagers { get; set; }
}
