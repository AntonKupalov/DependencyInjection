using DependencyInjection.Interfaces;

namespace DependencyInjection.Services;

public class FirstService : IFirstService
{
    public void FirstMethod()
    {
        Console.WriteLine(GetType().GUID);
    }
}