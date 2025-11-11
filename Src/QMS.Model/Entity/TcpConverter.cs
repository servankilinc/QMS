namespace QMS.Model.Entity;

public class TcpConverter
{
    public Guid Id { get; set; }
    public Guid ConverterId { get; set; }
    public string Ip { get; set; } = null!;
    public string Port { get; set; } = null!;
    public int Mode { get; set; }
    public virtual Converter Converter { get; set; } = null!;
}