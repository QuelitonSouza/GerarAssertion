using Newtonsoft.Json;
using RestSharp;

namespace GerarAssertion
{
    public static class GerarToken
    {
        public static string GerarClientToken(string clientId, string assertion, string scopes, string url)
        {
            var client = new RestClient($"{url}");

            var request = new RestRequest("/connect/token", Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", clientId);
            request.AddParameter("scope", scopes);
            request.AddParameter("client_assertion_type", "urn:ietf:params:oauth:client-assertion-type:jwt-bearer");
            request.AddParameter("client_assertion", assertion);

            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
                var resultToken = $"{result.token_type} {result.access_token}";
                return resultToken;
            }

            throw new ArgumentException(response.Content);
        }
    }

    public class TokenResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }
}
