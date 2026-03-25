using RentalApp.Domain;

namespace RentalApp.Services;

public class PenaltyCalculator
{
    public decimal Calculate(Rental rental)
    {
        if (!rental.IsLate) return 0;

        int daysLate = (rental.ReturnDate.Value - rental.DueDate).Days;
        return daysLate * 10;
    }
}