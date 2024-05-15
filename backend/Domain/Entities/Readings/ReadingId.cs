namespace CounterMotinor.Domain.Entities.Readings;

public readonly record struct ReadingId
{
    public Guid Value { get; }

    public static ReadingId Empty { get; } = new(Guid.Empty);

    private ReadingId(Guid value) => Value = value;

    public static ReadingId Create(Guid value) => new(value);

    public static implicit operator Guid(ReadingId id) => id.Value;

    override public string ToString() => Value.ToString();
}