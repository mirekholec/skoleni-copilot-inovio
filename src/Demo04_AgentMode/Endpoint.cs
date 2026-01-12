using Demolice.Demo04_AgentMode.Products;
using Demolice.Demo04_AgentMode.Subscriptions;

namespace Demolice.Demo04_AgentMode;

public static class Endpoint
{
    public static void AddApis(this IEndpointRouteBuilder route)
    {
        route.AddProducts();
        route.AddSubscriptions();
    }
}