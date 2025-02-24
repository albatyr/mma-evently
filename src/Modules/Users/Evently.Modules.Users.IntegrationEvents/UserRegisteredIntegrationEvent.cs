using Evently.Common.Application.EventBus;

namespace Evently.Modules.Users.IntegrationEvents;

public class UserRegisteredIntegrationEvent(
    Guid id,
    DateTime occurredOn,
    Guid userId,
    string email,
    string firstName,
    string lastName)
    : IntegrationEvent(id, occurredOn)
{
    public Guid UserId { get; } = userId;

    public string Email { get; } = email;

    public string FirstName { get; } = firstName;

    public string LastName { get; } = lastName;
}
