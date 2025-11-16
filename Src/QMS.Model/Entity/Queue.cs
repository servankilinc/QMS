using System.Runtime.InteropServices;

namespace QMS.Model.Entity;

public class Queue
{
    public Guid Id { get; set; }
    public int QueueTypeId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ClientId { get; set; }
    public int LastMovementTypeId { get; set; }
    public DateTime Date { get; set; }

    public virtual QueueType QueueType { get; set; } = null!;
    public virtual Branch Branch { get; set; } = null!;
    public virtual Client Client { get; set; } = null!;
    public virtual QueueMovementType LastMovementType { get; set; } = null!;
    public virtual ICollection<QueueMovement> QueueMovements { get; set; } = null!;
}
