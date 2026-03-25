namespace RentalApp.Repositories;

public interface RepozytoriumInterfejs<T>
{
    void Add(T item);
    List<T> GetAll();
}