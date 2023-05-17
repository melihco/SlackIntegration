using Marti.Core.Integrations.Abstract;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Marti.Core.Integrations.Concrete.Slack;

public class BaseSlackClient : ISlackClient
{

    private readonly Uri _uri;
    private readonly Encoding _encoding = new UTF8Encoding();

    protected BaseSlackClient(string urlWithAccessToken)
    {
        _uri = new Uri(urlWithAccessToken);
    }

    public async Task PostMessage(string text, string username = null, string channel = null)
    {
        using var client = new HttpClient();
        var payload = new
        {
            text,
            username,
            channel
        };
            
        var content = new StringContent(JsonSerializer.Serialize(payload), _encoding, "application/json");
        await client.PostAsync(_uri, content);
    }
}

