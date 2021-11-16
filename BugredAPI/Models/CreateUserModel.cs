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
        
        [JsonProperty("tasks")]
        public List<int> Tasks { get; set; }

        [JsonProperty("companies")]
        public List<int> Companies { get; set; }

    }
}
