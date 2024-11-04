namespace Ordering.Application.Orders.EventHandlers.Domain;
public class OrderCreatedEventHandler(ILogger<OrderCreatedEventHandler> logger)
    : INotificationHandler<OrderCreatedEvent>
{
    public Task Handle(OrderCreatedEvent domain, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", domain.GetType().Name);

        return Task.CompletedTask;
    }
}
