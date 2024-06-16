using Microsoft.Extensions.DependencyInjection;
using CounterMonitor.UseCases.ReadingsForCounter.Services;

namespace CounterMonitor.UseCases.ReadingsForCounter.Extensions;

internal static class ServiceCollectionExtensions
{
  public static IServiceCollection AddReadingsForCounter(this IServiceCollection services) =>
    services.AddScoped<ReadingsForCounterService>();
}