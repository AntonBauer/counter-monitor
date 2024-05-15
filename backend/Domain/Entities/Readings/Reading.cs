using CounterMotinor.Domain.Entities.Counters;

namespace CounterMotinor.Domain.Entities.Readings;

public sealed class Reading
{
  public ReadingId Id { get; }

  public DateTimeOffset Date { get; }

  public Counter Counter { get; }

  public NonNegativeDouble Value { get; }

  private Reading(ReadingId id, DateTimeOffset date, Counter counter, NonNegativeDouble value) =>
    (Id, Date, Counter, Value) = (id, date, counter, value);

  public static Reading Create(DateTimeOffset date, Counter counter, double value) =>
    new(ReadingId.Empty, date, counter, NonNegativeDouble.Create(value));
}