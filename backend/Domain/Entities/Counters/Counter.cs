using System.Collections.Immutable;
using CounterMotinor.Domain.Entities.Readings;

namespace CounterMotinor.Domain.Entities.Counters;

public sealed class Counter
{
  public CounterId Id { get; }

  public NonEmptyString Name { get; }

  public ImmutableHashSet<Reading> Readings { get; } = [];

  private Counter(CounterId id, NonEmptyString name) => (Id, Name) = (id, name);

  public static Counter Create(string name) =>
    new(CounterId.Create(), NonEmptyString.CreateFrom(name));
}