using Microsoft.AspNetCore.Routing;

namespace CounterMonitor.UseCases.CreateCounter;

internal static class WebApplicationExtensions
{
    public static IEndpointRouteBuilder AddCreateCounter(this IEndpointRouteBuilder app) =>
      app;
}