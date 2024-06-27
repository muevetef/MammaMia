using MammaMia.Models;

namespace MammaMia.Services;

public class PizzaService : IFoodService<Pizza>
{
    public IEnumerable<Pizza> GetAll()
    {
        throw new NotImplementedException();
    }

    public Pizza? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Pizza? Create(Pizza pizza){
        throw new NotImplementedException();
    }

    public void AddToppping(int PizzaId, int ToppingId){
        throw new NotImplementedException();
    }

    public void UpdateSauce(int PizzaId, int SauceId){
        throw new NotImplementedException();
    }

    public void DeleteById(int PizzaId){
        throw new NotImplementedException();
    }
}