namespace QMS.Model.Entity;

public class Holiday
{
    public int MyProperty { get; set; }
    public string Name { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsNationalHoliday { get; set; }
}
