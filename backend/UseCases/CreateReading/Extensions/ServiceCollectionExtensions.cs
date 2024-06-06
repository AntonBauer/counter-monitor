using Microsoft.Extensions.DependencyInjection;
using CounterMonitor.UseCases.CreateReading.Services;

namespace CounterMonitor.UseCases.CreateReading.Extensions;

internal static class ServiceCollectionExtensions
{
  public static IServiceCollection AddCreateReading(this IServiceCollection services) =>
    services.AddScoped<CreateReadingService>();
}