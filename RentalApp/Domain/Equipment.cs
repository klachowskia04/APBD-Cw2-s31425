namespace RentalApp.Domain;

public abstract class Equipment
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public bool IsAvailable { get; private set; }

    protected Equipment(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        IsAvailable = true;
    }

    public void MarkUnavailable()
    {
        IsAvailable = false;
    }

    public void MarkAvailable()
    {
        IsAvailable = true;
    }
}