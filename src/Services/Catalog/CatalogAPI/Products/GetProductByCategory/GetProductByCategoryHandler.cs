
namespace CatalogAPI.Products.GetProductByCategory;

public record GetProductByByCategoryQuery(string Category) : IQuery<GetProductByByCategoryResult>;
public record GetProductByByCategoryResult(IEnumerable<Product> Products);
internal class GetProductByCategoryQueryHandler(IDocumentSession session) : IQueryHandler<GetProductByByCategoryQuery, GetProductByByCategoryResult>
{
    public async Task<GetProductByByCategoryResult> Handle(GetProductByByCategoryQuery query, CancellationToken cancellationToken)
    {
        var products = await session.Query<Product>()
            .Where(p => p.Category.Contains(query.Category))
            .ToListAsync();
        return new GetProductByByCategoryResult(products);
    }
}
