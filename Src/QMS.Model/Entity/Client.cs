namespace QMS.Model.Entity;

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string TCKNO { get; set; } = null!;

    public virtual ICollection<Queue>? Queues { get; set; }
}