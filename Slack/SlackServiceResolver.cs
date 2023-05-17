using Marti.Core.Integrations.Abstract;
namespace Marti.Core.Integrations.Concrete.Slack;

public delegate ISlackClient SlackServiceResolver(SlackHooks key);


public enum SlackHooks
{
    SystemNotification = 1,
    ControlCenterNotification = 2
}