using CSharpFunctionalExtensions;
using GeneralDomain.Entities;
using GeneralDomain.UtilityTypes;

namespace CounterMotinor.Domain.Entities.Readings;

public sealed class Reading : Entity<ReadingId, Guid>
{
  public DateTimeOffset Date { get; }

  public NonNegativeDouble Value { get; }

  private Reading(ReadingId id, DateTimeOffset date, NonNegativeDouble value) : base(id) =>
    (Date, Value) = (date, value);

  public static Result<Reading> Create(DateTimeOffset date, double value) =>
    NonNegativeDouble.Create(value)
                     .Map(validatedValue => new Reading(ReadingId.Empty, date, validatedValue));
}