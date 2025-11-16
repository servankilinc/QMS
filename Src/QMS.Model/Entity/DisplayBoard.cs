namespace QMS.Model.Entity;

public class DisplayBoard
{
    public Guid Id { get; set; }  // aynı zamanda display Id'si (fk display.Id)
    public string Name { get; set; } = null!;

    public virtual Display? Display { get; set; }
}