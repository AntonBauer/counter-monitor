namespace CounterMonitor.UseCases.CreateReading.Responses;

internal readonly record struct CreatedExampleDto
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}