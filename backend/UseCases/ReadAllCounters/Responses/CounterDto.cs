namespace CounterMonitor.UseCases.ReadAllCounters.Responses;

internal readonly record struct CounterDto
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}