using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugredAPI.Models
{
    class CreateUserModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }          
 
    }
}
