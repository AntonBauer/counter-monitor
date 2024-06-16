using CounterMonitor.UseCases.ReadAllCounters.Responses;
using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CounterMonitor.UseCases.ReadAllCounters.Services;

internal sealed class ReadCountersService(CounterMonitorContext context)
{
  public async Task<CounterDto[]> ReadAll(CancellationToken cancellationToken) =>
    await context.Counters.AsNoTracking()
                          .TagWith("Read all counters")
                          .Select(counter => new CounterDto
                          {
                            Id = counter.Id,
                            Name = counter.Name
                          })
                          .ToArrayAsync(cancellationToken);
}