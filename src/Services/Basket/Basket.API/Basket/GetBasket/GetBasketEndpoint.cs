namespace Basket.API.Basket.GetBasket;

public record GetBasketResponse(ShoppingCart cart);

public class GetBasketEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/basket/{userName}", async (string userName, ISender sender) =>
        {
            //result.cart returns wih new shopping cart item 
            var result = await sender.Send(new GetBasketQuery(userName));
            //i had to put this explicit mapping 
            TypeAdapterConfig<GetBasketResult, GetBasketResponse>
                            .NewConfig()
                            .Map(dest => dest.cart, src => src.cart);

            //although response.cart return null after this line 
            var respose = result.Adapt<GetBasketResponse>();
            return Results.Ok(respose);
        })
        .WithName("GetProductById")
        .Produces<GetBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Product By Id")
        .WithDescription("Get Product By Id");
    }
}

