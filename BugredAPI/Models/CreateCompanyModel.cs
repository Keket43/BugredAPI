using Newtonsoft.Json;
using System.Collections.Generic;

namespace BugredAPI.Models
{
    class CreateCompanyModel
    {
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_type")]
        public string CompanyType { get; set; }

        [JsonProperty("company_users")]
        public List<string> CompanyUsers { get; set; }

        [JsonProperty("email_owner")]
        public string EmailOwner { get; set; }
      
    }
}
