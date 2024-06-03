using GeneralDomain.Entities;

namespace CounterMotinor.Domain.Entities.Readings;

public record ReadingId : Id<Guid>
{
    public static readonly ReadingId Empty = new(Guid.Empty);

    private ReadingId(Guid value) : base(value) { }

    public static ReadingId CreateNew() => new(Guid.NewGuid());

    public static ReadingId CreateFrom(Guid value) => new(value);
}