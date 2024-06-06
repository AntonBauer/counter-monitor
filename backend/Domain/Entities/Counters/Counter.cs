using System.Collections.Immutable;
using CounterMotinor.Domain.Entities.Readings;
using CSharpFunctionalExtensions;
using GeneralDomain.Entities;
using GeneralDomain.UtilityTypes;

namespace CounterMotinor.Domain.Entities.Counters;

public sealed class Counter : Entity<CounterId, Guid>
{
  public NonEmptyString Name { get; }

  public ImmutableHashSet<Reading> Readings { get; } = [];

  private Counter(CounterId id, NonEmptyString name) : base(id) =>
    Name = name;

  public static Result<Counter> Create(string name) => 
    NonEmptyString.Create(name)
                  .Map(validatedName => new Counter(CounterId.CreateNew(), validatedName));
}