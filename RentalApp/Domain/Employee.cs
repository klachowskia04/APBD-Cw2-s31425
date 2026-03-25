namespace RentalApp.Domain;

public class Employee : User
{
    public Employee(string firstName, string lastName) 
        : base(firstName, lastName) { }
    
    public override int MaxBorrowLimit { get => 5; }
}