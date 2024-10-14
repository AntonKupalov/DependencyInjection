using DependencyInjection.Interfaces;

namespace DependencyInjection.Services;

public class ThirdService : IThirdService
{
    public void ThirdMethod()
    {
        Console.WriteLine(GetType().GUID);
    }
}