﻿namespace CatalogAPI.Products.CreateProduct;

public record CreateProductRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
public record CreateProductResponse(Guid Id);
public class CreateProductEndPoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductRequest request, ISender sender) =>
        {
            var command = request.Adapt<CreateProductCommand>();
            var result = await sender.Send(command);

            var response = result.Adapt<CreateProductResponse>();
            return Results.Created($"/products/{response.Id}", response);
        })
            .WithName("Created Products")
            .Produces<CreateProductResponse>(StatusCodes.Status201Created)
            .WithSummary("Created Product")
            .WithDescription("Created Product");
    }
}

