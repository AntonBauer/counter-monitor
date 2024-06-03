using CounterMonitor.UseCases.CreateCounter.Extensions;
using CounterMonitor.UseCases.CreateCounter.Responses;
using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;

namespace CounterMonitor.UseCases.CreateCounter.Services;

internal sealed class CreateCounterService(CounterMonitorContext context)
{
  public async Task<CreatedCounterDto> Create(string name, CancellationToken cancellationToken)
  {
    // ToDo: check how to deal with IO
    var counter = Counter.Create(name).ToArr().First().Success;

    context.Counters.Add(counter);
    await context.SaveChangesAsync(cancellationToken);

    return counter.ToCreatedCounterDto();
  }
}