namespace QMS.Model.Entity;

public class DisplayType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Display>? Displays { get; set; }
}
