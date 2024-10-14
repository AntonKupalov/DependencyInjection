using DependencyInjection.Interfaces;
using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<IFirstService,FirstService>();
        serviceCollection.AddScoped<ISecondInterface, SecondService>();
        serviceCollection.AddTransient<IThirdService, ThirdService>();
     
        var serviceProvider = serviceCollection.BuildServiceProvider();
        serviceProvider.GetService<IFirstService>().FirstMethod();
        serviceProvider.GetService<ISecondInterface>().SecondMethod();
        serviceProvider.GetService<IThirdService>().ThirdMethod();
    }
}