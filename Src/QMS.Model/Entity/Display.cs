namespace QMS.Model.Entity;

public class Display
{
    // branch eklemeye gerek yok çünkü display banko ile ilişkilendirilecek
    public Guid Id { get; set; }
    public Guid BankoId { get; set; }
    public int DisplayTypeId { get; set; }
    public Guid? DisplayTvId { get; set; }
    public Guid? DisplayBoardId { get; set; }
    public string Name { get; set; } = null!;

    public virtual Banko Banko { get; set; } = null!;
    public virtual DisplayType DisplayType { get; set; } = null!;
    public virtual DisplayTv? DisplayTv { get; set; }
    public virtual DisplayBoard? DisplayBoard { get; set; }
}
