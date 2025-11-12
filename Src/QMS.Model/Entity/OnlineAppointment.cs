namespace QMS.Model.Entity;

public class OnlineAppointment
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid QueueId { get; set; }
    public int LastOperation { get; set; }
    public virtual Queue Queue { get; set; } = null!;
    public virtual Client Client { get; set; } = null!;
}