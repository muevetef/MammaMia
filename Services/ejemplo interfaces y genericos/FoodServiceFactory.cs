
using MammaMia.Models;

namespace MammaMia.Services;

public class FoodServiceFactory : IFoodServiceFactory
{
    public IFoodService<T> CreateService<T>()
    {
        if (typeof(T) == typeof(Cake))
        {
            return (IFoodService<T>)new CakeService();
        }
        else if (typeof(T) == typeof(Pizza))
        {
            return (IFoodService<T>)new PizzaService();
        }else{
            throw new ArgumentException("No hay ningun servicio para el tipo proposcionado");
        }

    }
}