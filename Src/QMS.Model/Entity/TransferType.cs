namespace QMS.Model.Entity;

public class TransferType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
}