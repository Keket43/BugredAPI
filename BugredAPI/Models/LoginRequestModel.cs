﻿using Newtonsoft.Json;


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
