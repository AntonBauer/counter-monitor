using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;
using CSharpFunctionalExtensions;

namespace CounterMonitor.UseCases.CreateReading.Services;

internal sealed class CreateReadingService(CounterMonitorContext context)
{
    public async Task<Result<Counter, string>> Create(Guid counterId, DateTimeOffset date, double value, CancellationToken cancellationToken) =>
      await (await context.Counters.FindAsync(CounterId.CreateFrom(counterId),
                                              cancellationToken))
        .ToResult($"Counter {counterId} not found")
        .Tap(counter => counter.AddReading(date, value))
        .Tap(async () => { await context.SaveChangesAsync(cancellationToken);});
}