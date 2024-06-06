using CounterMonitor.UseCases.CreateCounter.Extensions;
using CounterMonitor.UseCases.CreateReading.Extensions;
using CounterMonitor.UseCases.ReadAllCounters.Extensions;
using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CounterMonitor.UseCases;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddUseCases(this IServiceCollection services,
                                               IConfiguration configuration) =>
    services.AddDataAccess(configuration)
            .AddReadAllCounters()
            .AddCreateCounter()
            .AddCreateReading();
}