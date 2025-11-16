namespace QMS.Model.Entity;

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Surname { get; set; }
    public char Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? SaltTCKNO { get; set; }
    public string? HashTCKNO { get; set; }

    public virtual ICollection<Queue>? Queues { get; set; }
}