using MammaMia.Services;

namespace MammaMia.Models;

public class CakeService : IFoodService<Cake>
{
    public IEnumerable<Cake> GetAll()
    {
        throw new NotImplementedException();
    }

    public Cake? GetById(int id)
    {
        throw new NotImplementedException();
    }
}