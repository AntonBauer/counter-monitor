using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;

namespace CounterMonitor.UseCases.CreateCounter.Services;

internal sealed class CreateCounterService(CounterMonitorContext context)
{
  public async Task<Counter> Create(string name, CancellationToken cancellationToken)
  {
    var counter = Counter.Create(name);

    context.Counters.Add(counter);
    await context.SaveChangesAsync(cancellationToken);
    
    return counter;
  }
}