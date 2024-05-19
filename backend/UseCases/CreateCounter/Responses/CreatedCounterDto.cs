namespace CounterMonitor.UseCases.CreateCounter.Responses;

internal readonly record struct CreatedCounterDto
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}