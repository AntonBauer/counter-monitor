using CounterMonitor.UseCases.CreateCounter;
using CounterMonitor.UseCases.ReadAllCounters;
using Microsoft.AspNetCore.Routing;

namespace CounterMonitor.UseCases;

public static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddUseCases(this IEndpointRouteBuilder app) =>
    app.AddCreateCounter()
       .AddReadAllCounters();
}