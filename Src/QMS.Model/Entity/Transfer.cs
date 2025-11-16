namespace QMS.Model.Entity;

public class Transfer
{
    public Guid Id { get; set; }
    public int TransferTypeId { get; set; }
    public Guid? PagerId { get; set; }
    public int Number { get; set; }

    public virtual TransferType TransferType { get; set; } = null!;
    public virtual Pager? Pager { get; set; }
    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
}
