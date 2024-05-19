using CounterMonitor.UseCases.CreateCounter.Responses;
using CounterMotinor.Domain.Entities.Counters;

namespace CounterMonitor.UseCases.CreateCounter.Extensions;

internal static class MappingExtensions
{
  public static CreatedCounterDto ToCreatedCounterDto(this Counter counter) =>
    new()
    {
      Id = counter.Id,
      Name = counter.Name
    };
}