namespace Evently.Common.Application.EventBus;

public abstract class IntegrationEvent(Guid id, DateTime occurredOn) : IIntegrationEvent
{
    public Guid Id { get; init; } = id;

    public DateTime OccurredOn { get; init; } = occurredOn;
}
