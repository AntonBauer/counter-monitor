namespace CounterMotinor.Domain.Entities.Counters;

public readonly record struct CounterId
{
    public Guid Value { get; }

    public static CounterId Empty { get; } = new(Guid.Empty);

    private CounterId(Guid value) => Value = value;

    public static CounterId Create() => new(Guid.NewGuid());

    public static CounterId CreateFrom(Guid value) => new(value);

    public static implicit operator Guid(CounterId id) => id.Value;

    override public string ToString() => Value.ToString();
}