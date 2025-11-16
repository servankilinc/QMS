namespace QMS.Model.Entity;

public class MainDisplayBoard
{
    public Guid Id { get; set; }  // aynı zamanda display Id'si (fk display.Id)
    public string Name { get; set; } = null!;

    public virtual MainDisplay? MainDisplay { get; set; }
}