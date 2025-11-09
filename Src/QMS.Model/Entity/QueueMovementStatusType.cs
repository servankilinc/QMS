namespace QMS.Model.Entity;

public class QueueMovementStatusType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
}