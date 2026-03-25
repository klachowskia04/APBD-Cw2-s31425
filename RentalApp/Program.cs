using RentalApp.Domain;
using RentalApp.Repositories;
using RentalApp.Services;
// kom branch2
var rentalRepo = new InMemoryRepository<Rental>();

var rentalService = new RentalService(rentalRepo);
var penaltyCalculator = new PenaltyCalculator();


var student = new Student("Jan", "Kowalski");
var employee = new Employee("Anna", "Nowak");


var laptop = new Laptop("Dell", 16, "15");
var projector = new Projector("Epson", 3000, true);


Console.WriteLine(" Wypożyczenie poprawne ");

rentalService.Borrow(student, laptop, 3);


Console.WriteLine("\n Próba wypożyczenia niedostępnego sprzętu ");

try
{
    rentalService.Borrow(student, laptop, 3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("\n Test limitu studenta ");

var cam1 = new Camera("Canon", 20, true);
var cam2 = new Camera("Sony", 24, true);

rentalService.Borrow(student, cam1, 3);

try
{
    rentalService.Borrow(student, cam2, 3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("\n Zwrot sprzętu ");

var rental = rentalRepo.GetAll().First();
rentalService.Return(rental);

Console.WriteLine("Sprzęt zwrócony");

Console.WriteLine("\nZwrot po terminie");


rental = rentalRepo.GetAll().Last();
rental.Return();


typeof(Rental)
    .GetProperty("ReturnDate")!
    .SetValue(rental, rental.DueDate.AddDays(2));

var penalty = penaltyCalculator.Calculate(rental);

Console.WriteLine($"Kara: {penalty}");


Console.WriteLine("\n RAPORT ");

var allRentals = rentalRepo.GetAll();

Console.WriteLine($"Liczba wypożyczeń: {allRentals.Count}");

var active = allRentals.Count(r => !r.IsReturned);
Console.WriteLine($"Aktywne: {active}");

var late = allRentals.Count(r => r.IsLate);
Console.WriteLine($"Przeterminowane: {late}");