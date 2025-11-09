namespace QMS.Model.Entity;

public class Unit
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<DisplayUnitMap>? DisplayUnitMaps { get; set; }
    public virtual ICollection<TerminalUserUnitMap>? TerminalUserUnitMaps { get; set; }
    public virtual ICollection<BankoUnitMap>? BankoUnitMaps { get; set; }
    public virtual ICollection<BranchUnitMap>? BranchUnitMaps { get; set; }
}
