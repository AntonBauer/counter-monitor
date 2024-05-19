using CounterMonitor.UseCases.ReadAllCounters.Responses;
using CounterMotinor.Domain.Entities.Counters;

namespace CounterMonitor.UseCases.ReadAllCounters.Extensions;

internal static class MappingExtensions
{
  public static CounterDto ToDto(this Counter counter) =>
    new()
    {
      Id = counter.Id,
      Name = counter.Name,
    };
}