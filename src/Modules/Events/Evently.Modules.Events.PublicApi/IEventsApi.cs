﻿namespace Evently.Modules.Events.PublicApi;

public interface IEventsApi
{
    Task<TicketTypeResponse?> GetTicketTypeAsync(Guid ticketTypeId, CancellationToken cancellationToken = default);
}

public sealed record TicketTypeResponse(
    Guid Id,
    string Name,
    decimal Price,
    string Currency,
    decimal Quantity);
