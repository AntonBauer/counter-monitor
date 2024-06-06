using CounterMonitor.UseCases.CreateCounter.Extensions;
using CounterMonitor.UseCases.CreateCounter.Responses;
using CounterMotinor.Domain.Entities.Counters;
using CounterMotinor.Infrastructure.DataAccess;
using CSharpFunctionalExtensions;

namespace CounterMonitor.UseCases.CreateCounter.Services;

internal sealed class CreateCounterService(CounterMonitorContext context)
{
    public async Task<Result<CreatedCounterDto>> Create(string name, CancellationToken cancellationToken) =>
      await Counter.Create(name)
                   .Tap(counter => context.Counters.Add(counter))
                   .Tap(async _ => await context.SaveChangesAsync(cancellationToken))
                   .Map(counter => counter.ToCreatedCounterDto());
}