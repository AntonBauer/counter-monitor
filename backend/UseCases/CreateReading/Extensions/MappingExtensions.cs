using CounterMonitor.Domain.Entities.Examples;
using CounterMonitor.UseCases.CreateReading.Responses;

namespace CounterMonitor.UseCases.CreateReading.Extensions;

internal static class MappingExtensions
{
  public static CreatedExampleDto ToCreatedExampleDto(this ExampleEntity counter) =>
    new()
    {
      Id = counter.Id,
      Name = counter.Name
    };
}