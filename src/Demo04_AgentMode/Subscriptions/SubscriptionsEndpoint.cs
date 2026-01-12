using Microsoft.AspNetCore.Mvc;

namespace Demolice.Demo04_AgentMode.Subscriptions;

public static class SubscriptionsEndpoint
{
    public static void AddSubscriptions(this IEndpointRouteBuilder route)
    {
        var api = route.MapGroup("subscriptions")
            .WithTags("Subscriptions");

        api.MapGet("", (ISubscriptionService subscriptions, [FromQuery] string plan) =>
        {
            var data = subscriptions.Get(plan);

            return Results.Ok(new
            {
                Items = data,
            });
        })
        .WithName("GetSubscriptions")
        .WithSummary("Získá seznam pøedplatných podle plánu")
        .WithDescription("Vrací seznam pøedplatných filtrovaných podle zadaného plánu");
    }
}