namespace QMS.Model.Entity;

public class Converter
{
    public Guid Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid BoradBrandId { get; set; }
    public int ConverterTypeId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;
    public virtual BoardBrand BoradBrand { get; set; } = null!;
    public virtual ConverterType ConverterType { get; set; } = null!;
    public virtual TcpConverter? TcpConverter { get; set; } = null!;
    public virtual SerialConverter? SerialConverter { get; set; } = null!;
    public virtual ICollection<Pager>? Pagers { get; set; }
}