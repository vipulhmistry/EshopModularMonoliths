using System.Reflection.Metadata;
using Catalog.Products.Features.GetProducts;

namespace Catalog.Products.Features.GetProductByCategory;

public record GetProductByIdQuery(Guid Id)
    : IQuery<GetProductByIdResult>;

public record GetProductByIdResult(IEnumerable<ProductDto> Products);


internal class GetProductByIdHandler(CatalogDbContext dbContext)
    : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = await dbContext.Products
            .AsNoTracking()
            .SingleOrDefaultAsync(p => p.Id == query.Id, cancellationToken);

        if (product is null)
        {
            throw new Exception($"Product not found: {query.Id}");
        }

        var productDto = product.Adapt<List<ProductDto>>();
        return new GetProductByIdResult(productDto);
    }
}
