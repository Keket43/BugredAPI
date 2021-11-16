using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;


namespace BugredAPI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        public void Test1()
        {
            //1. 
            //урл, добавить хедеры,  создать тело запроса, добавить тело к запросу, отправить запрос


            RestClient client = new RestClient("http://users.bugred.ru/tasks/rest/doregister")
            {
                Timeout = 300000
            };
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", "Bearer YTg3MjBkMGYtNDNmNC00MWQyLWFhM2MtMjFhNTkyYmFkOTc0");

            Dictionary<string, string> body = DoRegisterUserData();
            request.AddJsonBody(body);

            IRestResponse response = client.Execute(request);

            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body["email"], json["accounts"]["email"].ToString());

        }
       
        //{
        //  

        //    Assert.AreEqual(body["email"], json["email"]?.ToString());
        //    Assert.AreEqual(body["name"], json["name"]?.ToString());

        //}


        public Dictionary<string, string> DoRegisterUserData()
        {
            string now = DateTime.Now.ToString("hhmmssMMddyy");
            string email = now + "@Fake.com";
            string userName = "Shopopalo" + now;
            return new Dictionary<string, string>()
            {
                { "email", email },
                { "name", userName },
                { "password", "mySecretPass123" },
            };
        }
    }
}