using Evently.Modules.Events.Domain.Events;

namespace Evently.Modules.Events.Domain.Abstractions;

public abstract class DomainEvent(Guid id, DateTime occurredOnUtc) : IDomainEvent
{
    protected DomainEvent() : this(Guid.CreateVersion7(), DateTime.UtcNow)
    {
    }

    public Guid Id { get; } = id;
    public DateTime OccuredOnUtc { get; } = occurredOnUtc;
}
