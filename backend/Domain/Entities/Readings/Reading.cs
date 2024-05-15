using CounterMotinor.Domain.Entities.Counters;

namespace CounterMotinor.Domain.Entities.Readings;

public sealed class Reading
{
  public ReadingId Id { get; }

  public DateTimeOffset Date { get; }

  public NonNegativeDouble Value { get; }

  private Reading(ReadingId id, DateTimeOffset date, NonNegativeDouble value) =>
    (Id, Date, Value) = (id, date, value);

  public static Reading Create(DateTimeOffset date, double value) =>
    new(ReadingId.Empty, date, NonNegativeDouble.Create(value));
}