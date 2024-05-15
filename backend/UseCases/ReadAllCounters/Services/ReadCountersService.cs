using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CounterMonitor.UseCases.ReadAllCounters.Services;

internal sealed class ReadCountersService(CounterMonitorContext context)
{
  public async Task<Counter[]> ReadAll(CancellationToken cancellationToken) =>
    await context.Counters.AsNoTracking()
                          .TagWith("Read all counters")
                          .ToArrayAsync(cancellationToken);
}