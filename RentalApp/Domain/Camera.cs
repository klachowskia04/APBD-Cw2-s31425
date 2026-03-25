namespace RentalApp.Domain;

public class Camera : Equipment
{
    public int Megapixels { get; set; }
    public bool IsMirrorless { get; set; }

    public Camera(string name, int megapixedls, bool isMirrorless)
        : base(name)
    {
        Megapixels = megapixedls;
        IsMirrorless = isMirrorless;
    }
}