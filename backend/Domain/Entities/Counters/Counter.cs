namespace CounterMotinor.Domain.Entities.Counters;

public sealed class Counter
{
  public CounterId Id { get; }

  public NonEmptyString Name { get; }

  private Counter(CounterId id, NonEmptyString name) => (Id, Name) = (id, name);

  public static Counter Create(string name) =>
    new(CounterId.Empty, NonEmptyString.Create(name));
}