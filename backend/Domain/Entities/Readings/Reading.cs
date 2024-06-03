using GeneralDomain.Entities;

namespace CounterMotinor.Domain.Entities.Readings;

public sealed class Reading : Entity<ReadingId, Guid>
{
  public DateTimeOffset Date { get; }

  public NonNegativeDouble Value { get; }

  private Reading(ReadingId id, DateTimeOffset date, NonNegativeDouble value) : base(id) =>
    (Date, Value) = (date, value);

  public static Reading Create(DateTimeOffset date, double value) =>
    new(ReadingId.Empty, date, NonNegativeDouble.Create(value));
}