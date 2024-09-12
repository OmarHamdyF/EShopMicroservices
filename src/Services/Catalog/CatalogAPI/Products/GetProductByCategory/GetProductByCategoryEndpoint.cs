
using CatalogAPI.Products.GetProductById;
using CatalogAPI.Products.GetProducts;

namespace CatalogAPI.Products.GetProductByCategory;

public record GetProductByByCategoryResponse(IEnumerable<Product> Products);

public class GetProductByCategoryEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/category/{category}", async (string category, ISender sender) =>
        {
            var result = await sender.Send(new GetProductByByCategoryQuery(category));
            var response = result.Adapt<GetProductByByCategoryResponse>();
            return Results.Ok(response);
        }).WithName("GetProductByCategory")
            .Produces<GetProductByByCategoryResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Product By Category")
            .WithDescription("Get Product By Category")
            ;
    }
}
