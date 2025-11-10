namespace QMS.Model.Entity;

public class Center
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<Branch>? Branches { get; set; }
}