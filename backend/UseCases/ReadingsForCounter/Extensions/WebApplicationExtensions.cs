using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using CounterMonitor.UseCases.ReadingsForCounter.Services;
using Microsoft.AspNetCore.Http;
using CSharpFunctionalExtensions;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace CounterMonitor.UseCases.ReadingsForCounter.Extensions;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddReadingsForCounter(this IEndpointRouteBuilder app)
  {
    app.MapGet("api/counters/{counterId:guid}/readings", ReadForCounter);
    return app;
  }

  private static async Task<IResult> ReadForCounter([FromRoute] Guid counterId,
                                                    [FromServices] ReadingsForCounterService service,
                                                    CancellationToken cancellationToken)
  {
    var result = await service.ReadForCounter(counterId, cancellationToken);
    return result.Finally(result => result.IsSuccess
      ? Results.Ok(result)
      : Results.BadRequest());
  }
}