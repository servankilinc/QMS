namespace QMS.Model.Entity;

public class QueueMovementType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
    public virtual ICollection<Queue>? QueueListOnLastThisMovement { get; set; }
}
