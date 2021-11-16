using Newtonsoft.Json;


namespace BugredAPI.Models
{
    class SignInRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public SignInRequestModel(string email, string name, string password)
        {
            this.Email = email;
            this.Name = name;
            this.Password = password;
        }
    }
}
