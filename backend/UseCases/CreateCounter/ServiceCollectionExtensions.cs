using CounterMonitor.UseCases.CreateCounter.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CounterMonitor.UseCases.CreateCounter;

internal static class ServiceCollectionExtensions
{
  public static IServiceCollection AddCreateCounter(this IServiceCollection services) =>
    services.AddScoped<CreateCounterService>();
}