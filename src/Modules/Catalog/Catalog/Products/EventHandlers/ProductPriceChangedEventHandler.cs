
namespace Catalog.Products.EventHandlers;

public class ProductPriceChangedEventHandler(ILogger<ProductCreatedEventHandler> logger)
    : INotificationHandler<ProductPrieChangedEvent>
{
    public Task Handle(ProductPrieChangedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);
        return Task.CompletedTask;
    }
}
