using Newtonsoft.Json.Linq;
using RestSharp;

namespace BugredAPI
{
    public class RequestHelper
    {
        private RestClient _client;

        private const string BaseUrl = "http://users.bugred.ru/tasks/rest";

        public RequestHelper(string path)
        {
            _client = new RestClient(BaseUrl + path);
        }

        public IRestResponse SendPostRequest(object body)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(body);

            IRestResponse response = _client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            return response;
        }
    }
}
