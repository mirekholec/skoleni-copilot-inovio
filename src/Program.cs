using Demolice.Data;
using Demolice.Demo02_NextEditSuggestions;
using Demolice.Demo03_CopilotChat;
using Demolice.Demo04_AgentMode;
using Demolice.Demo04_AgentMode.Subscriptions;
using Demolice.Demo05_VisualStudio2026;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddSingleton<BrokenService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();
builder.Services.AddHostedService<DbInit>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapStaticAssets();

app.AddBrokenService();
app.AddApis();

app.Run();