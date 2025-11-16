namespace QMS.Model.Entity;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid? BranchId { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public Branch? Branch { get; set; }
}