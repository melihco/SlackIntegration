using System.Threading.Tasks;

namespace Slack.Core.Integrations.Abstract
{
    public interface ISlackClient
    {
        Task PostMessage(string text, string username = null, string channel = null);
    }
}
