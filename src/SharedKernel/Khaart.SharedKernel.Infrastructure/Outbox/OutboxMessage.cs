namespace Khaart.SharedKernel.Infrastructure.Outbox;

internal sealed class OutboxMessage(
    Guid id,
    string topic,
    string payload,
    DateTimeOffset occurredOnUtc)
{
    public Guid Id { get; private init; } = id;

    public string Topic { get; private init; } = topic;

    public string Payload { get; private init; } = payload;

    public DateTimeOffset OccurredOnUtc { get; private init; } = occurredOnUtc;

    public DateTimeOffset? ProcessedOnUtc { get; private set; }

    public string? Error { get; private set; }

    public void SetProcessedOnUtc(DateTimeOffset processedOnUtc) => ProcessedOnUtc = processedOnUtc;

    public void SetError(string error) => Error = error;
}
