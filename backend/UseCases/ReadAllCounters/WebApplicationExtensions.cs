using CounterMonitor.UseCases.ReadAllCounters.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CounterMonitor.UseCases.ReadAllCounters;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddReadAllCounters(this IEndpointRouteBuilder app)
  {
    // ToDo - Add OpenApi
    app.MapGet("api/counters",
                async ([FromServices] ReadCountersService service,
                       CancellationToken cancellationToken) => await service.ReadAll(cancellationToken));

    return app;
  }
}