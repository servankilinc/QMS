namespace QMS.Model.Entity;

public class BoardBrand
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Converter>? Converters { get; set; }
}
