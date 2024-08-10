namespace DotaCounterPicker.Data.DTO;

public class HeroToLine
{
    public int Id {  get; set; }

    public int HeroId {  get; set; }

    public int LineId {  get; set; }

    public Hero Hero { get; set; } = null!;

    public Line Line { get; set; } = null!;

}
