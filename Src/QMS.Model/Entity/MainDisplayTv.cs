namespace QMS.Model.Entity;

public class MainDisplayTv
{
    public Guid Id { get; set; } // aynı zamanda display Id'si (fk display.Id)
    public string Name { get; set; } = null!;
    public int TvDesignId { get; set; }
    public int Volume { get; set; }
    public bool IsHaveVideoList { get; set; }
    public Guid TvChanelId { get; set; }

    public virtual MainDisplay? MainDisplay { get; set; }
}
