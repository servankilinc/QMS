namespace QMS.Model.Entity;

public class Transfer
{
    public int Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid? PagerId { get; set; }
    public int TransferTypeId { get; set; }
    public int Number { get; set; }

    public virtual Pager? Pager { get; set; }
    public virtual Branch Branch { get; set; } = null!;
    public virtual TransferType TransferType { get; set; } = null!;
    public virtual ICollection<QueueMovement>? QueueMovements { get; set; }
}
