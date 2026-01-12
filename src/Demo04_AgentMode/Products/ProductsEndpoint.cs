using Demolice.Demo02_NextEditSuggestions;
using Microsoft.AspNetCore.Mvc;

namespace Demolice.Demo04_AgentMode.Products;

public static class ProductsEndpoint
{
    public static void AddProducts(this IEndpointRouteBuilder route)
    {
        var api = route.MapGroup("products")
            .WithTags("Products");

        api.MapGet("", (ProductService products, [FromQuery] string category) =>
        {
            var data = products.Get(category);

            return Results.Ok(new
            {
                Items = data,
            });
        })
        .WithName("GetProducts")
        .WithSummary("Z�sk� seznam produkt� podle kategorie")
        .WithDescription("Vrac� seznam produkt� filtrovan�ch podle zadan� kategorie");
    }
}