using CounterMonitor.UseCases.ReadAllCounters.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CounterMonitor.UseCases.ReadAllCounters.Extensions;

internal static class ServiceCollectionExtensions
{
  public static IServiceCollection AddReadAllCounters(this IServiceCollection services) =>
    services.AddScoped<ReadCountersService>();
}