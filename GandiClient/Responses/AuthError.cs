using System.Text.Json.Serialization;

namespace GandiClient.Responses
{
    public class AuthError
    {
        [JsonPropertyName("caus")]
        public string Cause { get; }

        [JsonPropertyName("code ")]
        public int Code { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("object")]
        public string Object { get; }
    }
}
