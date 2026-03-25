namespace RentalApp.Domain;

public class Rental
{
    public Guid Id { get; private set; }
    public User User { get; }
    public Equipment Equipment { get; }
    public DateTime BorrowDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }

    public bool IsReturned => ReturnDate.HasValue;

    public Rental(User user, Equipment equipment, int days)
    {
        Id = Guid.NewGuid();
        User = user;
        Equipment = equipment;
        BorrowDate = DateTime.Now;
        DueDate = BorrowDate.AddDays(days);
    }

    public void Return()
    {
        ReturnDate = DateTime.Now;
    }

    public bool IsLate =>
        ReturnDate.HasValue && ReturnDate > DueDate;
}