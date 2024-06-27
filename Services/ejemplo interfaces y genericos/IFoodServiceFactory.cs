namespace MammaMia.Services;

public interface IFoodServiceFactory
{
    IFoodService<T> CreateService<T>();
}
