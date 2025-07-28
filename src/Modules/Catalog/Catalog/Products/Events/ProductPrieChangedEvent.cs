

namespace Catalog.Products.Events;

    public record ProductPrieChangedEvent(Product Product)
        : IDomainEvent;
    

