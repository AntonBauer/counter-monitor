using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using CounterMonitor.UseCases.CreateReading.Requests;
using CounterMonitor.UseCases.CreateReading.Services;

namespace CounterMonitor.UseCases.CreateReading.Extensions;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddCreateReading(this IEndpointRouteBuilder app)
  {
    app.MapPost("api/counters/{counterId:guid}/readings",
                async ([FromRoute] Guid counterId,
                       [FromBody] CreateReadingRequest request,
                       [FromServices] CreateReadingService service,
                       CancellationToken cancellationToken) => await service.Create(counterId, request.Date, request.Value, cancellationToken));

    return app;
  }
}