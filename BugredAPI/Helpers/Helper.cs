using System;

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
