using GeneralDomain.Entities;

namespace CounterMotinor.Domain.Entities.Counters;

public record CounterId : Id<Guid>
{
    private CounterId(Guid value): base(value) { }

    public static CounterId CreateNew() => new(Guid.NewGuid());

    public static CounterId CreateFrom(Guid value) => new(value);
}