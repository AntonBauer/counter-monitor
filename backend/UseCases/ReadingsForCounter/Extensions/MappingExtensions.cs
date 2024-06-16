using CounterMonitor.UseCases.ReadingsForCounter.Responses;
using CounterMotinor.Domain.Entities.Readings;

namespace CounterMonitor.UseCases.ReadingsForCounter.Extensions;

internal static class MappingExtensions
{
  public static ReadingDto ToCreatedExampleDto(this Reading reading) =>
    new()
    {
      Id = reading.Id,
      Date = reading.Date,
      Value = reading.Value
    };
}