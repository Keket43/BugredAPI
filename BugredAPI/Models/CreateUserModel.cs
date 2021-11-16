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
        public List<Task> Tasks { get; set; }

        [JsonProperty("companies")]
        public List<int> Companies { get; set; }

        [JsonProperty("hobby")]
        public string Hobby { get; set; }

        [JsonProperty("adres")]
        public string Adres { get; set; }

        [JsonProperty("name1")]
        public string Name1 { get; set; }

        [JsonProperty("surname1")]
        public string Surname1 { get; set; }

        [JsonProperty("fathername1")]
        public string Fathername1 { get; set; }

        [JsonProperty("cat")]
        public string Cat { get; set; }

        [JsonProperty("dog")]
        public string Dog { get; set; }        

        [JsonProperty("cavy")]
        public string Cavy { get; set; }

        [JsonProperty("hamster")]
        public string Hamster { get; set; }       

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }


        [JsonProperty("date_start")]
        public string Date_start { get; set; }
    }
}
