namespace RentalApp.Domain;

public class Student : User
{
    public Student(string firstName, string lastName)
        : base(firstName, lastName) { }

    public override int MaxBorrowLimit => 2;
}