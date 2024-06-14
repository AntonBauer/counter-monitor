using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;

namespace CounterMonitor.UseCases.CreateReading.Services;

internal sealed class CreateReadingService(CounterMonitorContext context)
{
  public async Task Create(Guid counterId, DateTimeOffset date, double value, CancellationToken cancellationToken)
  {
    var counter = await context.Counters
                               .FindAsync(CounterId.CreateFrom(counterId),
                                          cancellationToken);

    counter.AddReading(date, value);

    await context.SaveChangesAsync(cancellationToken);
  }
}