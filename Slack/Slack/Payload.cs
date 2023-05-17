using System.Text.Json.Serialization;

namespace Slack.Data.ExternalEntities.Slack;

//This class serializes into the Json payload required by Slack Incoming WebHooks
public class Payload
{
    [JsonPropertyName("channel")]
    public string Channel { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
