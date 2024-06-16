using CounterMonitor.UseCases.CreateCounter.Services;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace CounterMonitor.UseCases.CreateCounter.Extensions;

internal static class WebApplicationExtensions
{
  public static IEndpointRouteBuilder AddCreateCounter(this IEndpointRouteBuilder app)
  {
    app.MapPost("api/counters", CreateCounter);
    return app;
  }

  private static async Task<IResult> CreateCounter([FromBody] CreateCounterRequest request,
                                                   [FromServices] CreateCounterService service,
                                                   CancellationToken cancellationToken)
  {
    var result = await service.Create(request.Name, cancellationToken);
    return result.Finally(result => result.IsSuccess
      ? Results.Ok()
      : Results.BadRequest()
    );
  }
}