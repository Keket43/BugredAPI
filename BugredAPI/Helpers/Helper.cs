using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugredAPI
{
    class Helper
    {
        public string GenerateEmail()
        {
            string data = DateTime.Now.ToString("yyyyMMddHHmmss");
            return data + "@fake.com";
        }

        public string GenerateName()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + "Name";
        }
    }
}
