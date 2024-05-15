using CounterMonitor.UseCases.CreateCounter.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CounterMonitor.UseCases.CreateCounter;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddCreateCounter(this IEndpointRouteBuilder app)
  {
    app.MapPost("api/counters",
                async ([FromBody] CreateCounterRequest request,
                       [FromServices] CreateCounterService service,
                       CancellationToken cancellationToken) => await service.Create(request.Name, cancellationToken));

    return app;
  }
}