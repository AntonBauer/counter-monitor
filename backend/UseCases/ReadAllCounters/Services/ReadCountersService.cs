using CounterMonitor.UseCases.ReadAllCounters.Extensions;
using CounterMonitor.UseCases.ReadAllCounters.Responses;
using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CounterMonitor.UseCases.ReadAllCounters.Services;

internal sealed class ReadCountersService(CounterMonitorContext context)
{
  public async Task<CounterDto[]> ReadAll(CancellationToken cancellationToken)
  {
    var counters = await context.Counters.AsNoTracking()
                                         .TagWith("Read all counters")
                                         .ToArrayAsync(cancellationToken);

    return counters.Select(counter => counter.ToDto())
                   .ToArray();
  }
}