using System;

namespace BugredAPI
{
    class Helper
    {
        public static string GenerateEmail()
        {
            string data = DateTime.Now.ToString("yyyyMMddHHmmss");
            return data + "@fake.com";
        }

        public static string GenerateName()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + "Name";
        }

    }
}
