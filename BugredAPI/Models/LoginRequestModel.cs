using Newtonsoft.Json;

namespace BugredAPI
{
    public class LoginRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
      
    }
}
