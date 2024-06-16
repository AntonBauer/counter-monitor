using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using CounterMonitor.UseCases.CreateReading.Requests;
using CounterMonitor.UseCases.CreateReading.Services;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Http;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace CounterMonitor.UseCases.CreateReading.Extensions;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddCreateReading(this IEndpointRouteBuilder app)
  {
    app.MapPost("api/counters/{counterId:guid}/readings", CreateReading);
    return app;
  }

  private static async Task<IResult> CreateReading([FromRoute] Guid counterId,
                                                   [FromBody] CreateReadingRequest request,
                                                   [FromServices] CreateReadingService service,
                                                   CancellationToken cancellationToken)
  {
    var result = await service.Create(counterId, request.Date, request.Value, cancellationToken);
    return result.Finally(result => result.IsSuccess
      ? Results.Ok()
      : Results.BadRequest()
    );
  }
}