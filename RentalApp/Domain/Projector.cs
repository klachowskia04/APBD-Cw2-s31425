namespace RentalApp.Domain;

public class Projector : Equipment
{
    public int Lumens { get; set; }
    public bool isFullHd { get; set; }

    public Projector(string name, int lumens, bool IsFullHd)
        : base(name)
    {
        Lumens = lumens;
        IsFullHd = isFullHd;
    }
}