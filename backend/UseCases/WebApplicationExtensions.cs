using CounterMonitor.UseCases.CreateCounter.Extensions;
using CounterMonitor.UseCases.CreateReading.Extensions;
using CounterMonitor.UseCases.ReadAllCounters.Extensions;
using CounterMonitor.UseCases.ReadingsForCounter.Extensions;
using Microsoft.AspNetCore.Routing;

namespace CounterMonitor.UseCases;

public static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddUseCases(this IEndpointRouteBuilder app) =>
    app.AddCreateCounter()
       .AddReadAllCounters()
       .AddCreateReading()
       .AddReadingsForCounter();
}