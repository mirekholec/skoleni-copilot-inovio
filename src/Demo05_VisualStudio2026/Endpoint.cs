using Demolice.Demo03_CopilotChat;

namespace Demolice.Demo05_VisualStudio2026;

public static class Endpoint
{
    public static void AddBrokenService(this IEndpointRouteBuilder route)
    {
        route.MapGet("/broken", (BrokenService brokenService) =>
        {
            return Results.Ok(brokenService.GetCode());
        })
        .WithName("GetBrokenServiceCode")
        .WithTags("Debug")
        .WithSummary("Z�sk� k�d z BrokenService")
        .WithDescription("Vrac� k�d z BrokenService pro debugging ��ely");


        route.MapGet("/vs2026", () =>
        {
            int a = 1;
            int b = 2;
            int c = 3;

            // Vyhodnocení výrazu + delegování na Copilota
            if (a > b && a > c || (c > a && b > 0))
            {
                Console.WriteLine("c is the largest.");
            }

            return Results.Ok();

        })
        .WithName("GetVS2026Demo")
        .WithTags("Debug");
    }
}