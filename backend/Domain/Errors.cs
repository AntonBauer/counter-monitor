using CounterMotinor.Domain.Entities.Counters;

namespace CounterMotinor.Domain;

public abstract record Error;

public record CounterNotFound(CounterId Id) : Error;