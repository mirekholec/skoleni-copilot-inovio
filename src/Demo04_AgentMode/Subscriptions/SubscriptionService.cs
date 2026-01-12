using Demolice.Data;
using Microsoft.EntityFrameworkCore;

namespace Demolice.Demo04_AgentMode.Subscriptions;

public class SubscriptionService(AppDbContext db) : ISubscriptionService
{
    public List<SubscriptionDto> Get(string plan)
    {
        var subscriptions = GetInternal(plan);
        return subscriptions.Select(x => new SubscriptionDto()
        {
            Id = x.Id,
            UserId = x.UserId,
            StartDate = x.StartDate,
            EndDate = x.EndDate,
            Plan = x.Plan
        }).ToList();
    }

    private List<Subscription> GetInternal(string plan)
    {
        var query = db
                        .Subscriptions.AsNoTracking();

        if (!string.IsNullOrEmpty(plan))
        {
            query = query.Where(x => x.Plan == plan);
        }

        return query.ToList();
    }
}