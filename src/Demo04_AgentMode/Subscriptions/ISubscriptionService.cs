namespace Demolice.Demo04_AgentMode.Subscriptions;

public interface ISubscriptionService
{
    List<SubscriptionDto> Get(string plan);
}