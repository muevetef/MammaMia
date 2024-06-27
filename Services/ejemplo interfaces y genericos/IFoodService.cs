using MammaMia.Models;

namespace MammaMia.Services;

public interface IFoodService<T>
{
    public IEnumerable<T> GetAll();
    public T? GetById(int id);

}