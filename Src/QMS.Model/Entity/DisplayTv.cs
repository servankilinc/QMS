namespace QMS.Model.Entity;

public class DisplayTv
{
    public Guid Id { get; set; } // aynı zamanda display Id'si (fk display.Id)
    public string Name { get; set; } = null!;
    public int TvDesignId { get; set; }
    public int Volume { get; set; }
    public bool IsHaveVideoList { get; set; }
    public Guid TvChanelId { get; set; }

    public virtual Display? Display { get; set; }
}
