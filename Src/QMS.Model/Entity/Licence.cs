namespace QMS.Model.Entity;

public class Licence
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Key { get; set; } = null!;
    public string ValueHash { get; set; } = null!;
    public string ValueSalt { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
}