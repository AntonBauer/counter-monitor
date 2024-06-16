namespace CounterMonitor.UseCases.ReadingsForCounter.Responses;

internal readonly record struct ReadingDto
{
    public required Guid Id { get; init; }
    public required DateTimeOffset Date { get; init; }
    public required double Value { get; init; }
}