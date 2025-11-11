namespace QMS.Model.Entity;

public class SerialConverter {     
    public Guid Id { get; set; }
    public Guid ConverterId { get; set; }
    public string PortName { get; set; } = null!;
    public int BaudRate { get; set; }
    public int Parity { get; set; }
    public int DataBits { get; set; }
    public int StopBits { get; set; }
    public bool DtrEnable { get; set; }
    public virtual Converter Converter { get; set; } = null!;
}
