namespace QMS.Model.Entity;

public class MainDisplayType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<MainDisplay>? MainDisplays { get; set; }
}
