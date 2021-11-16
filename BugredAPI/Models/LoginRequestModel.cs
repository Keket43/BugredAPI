using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugredAPI
{
    public class LoginRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public LoginRequestModel(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
