using DependencyInjection.Interfaces;

namespace DependencyInjection.Services;

public class SecondService : ISecondInterface
{
    public void SecondMethod()
    {
        Console.WriteLine(GetType().GUID);
    }
}