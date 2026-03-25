using RentalApp.Domain;
using RentalApp.Repositories;

namespace RentalApp.Services;

public class RentalService
{
    private readonly RepozytoriumInterfejs<Rental> _rentals;

    public RentalService(RepozytoriumInterfejs<Rental> rentals)
    {
        _rentals = rentals;
    }

    public void Borrow(User user, Equipment equipment, int days)
    {
        if (!equipment.IsAvailable)
            throw new Exception("Sprzęt niedostępny");

        int active = _rentals.GetAll()
            .Count(r => r.User.Id == user.Id && !r.IsReturned);

        if (active >= user.MaxBorrowLimit)
            throw new Exception("Limit przekroczony");

        var rental = new Rental(user, equipment, days);

        equipment.MarkUnavailable();
        _rentals.Add(rental);
    }

    public void Return(Rental rental)
    {
        rental.Return();
        rental.Equipment.MarkAvailable();
    }
}