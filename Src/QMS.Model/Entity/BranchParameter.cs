namespace QMS.Model.Entity;

public class BranchParameter
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public string Key { get; set; } = null!;
    public string Value { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
}