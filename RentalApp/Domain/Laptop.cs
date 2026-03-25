namespace RentalApp.Domain;

public class Laptop : Equipment
{
    public int RamGb { get; set; }
    public string ScreenSize { get; set; }

    public Laptop(string name, int ram, string screenSize) : base(name)
    {
        RamGb = ram;
        ScreenSize = screenSize;
    }
}
