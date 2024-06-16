using CounterMonitor.UseCases.ReadingsForCounter.Responses;
using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;
using CSharpFunctionalExtensions;

namespace CounterMonitor.UseCases.ReadingsForCounter.Services;

internal sealed class ReadingsForCounterService(CounterMonitorContext context)
{
  public async Task<Result<ReadingDto[]>> ReadForCounter(Guid counterId, CancellationToken cancellationToken)
  {
    var id = CounterId.CreateFrom(counterId);
    // var readings = await context.Counters

    throw new NotImplementedException();
  }
}