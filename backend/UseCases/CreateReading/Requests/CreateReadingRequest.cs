namespace CounterMonitor.UseCases.CreateReading.Requests;

internal readonly record struct CreateReadingRequest
{
  public required DateTimeOffset Date { get; init; }
  public required double Value { get; init; }
}