using BugredAPI.Models;
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

        //[Test]
        //public void Test1()
        //{
        //    RestClient client = new RestClient("http://users.bugred.ru/tasks/rest/doregister")
        //    {
        //        Timeout = 100000
        //    };
        //    RestRequest request = new RestRequest(Method.POST);
        //    request.AddHeader("content-type", "application/json");

        //    Dictionary<string, string> body = DoRegisterUserData();
        //    request.AddJsonBody(body);

        //    IRestResponse response = client.Execute(request);

        //    JObject json = JObject.Parse(response.Content);

        //    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        //    Assert.AreEqual(body["email"], json["accounts"]["email"].ToString());
        //    Assert.AreEqual(body["name"], json["name"]?.ToString());
        //}

        //public Dictionary<string, string> DoRegisterUserData()
        //{
        //    string now = DateTime.Now.ToString("hhmmssMMddyy");
        //    string email = now + "@Fake.com";
        //    string userName = "Shopopalo" + now;
        //    return new Dictionary<string, string>()
        //    {
        //        { "email", email },
        //        { "name", userName },
        //        { "password", "mySecretPass123" },
        //    };
        //}

        [Test]
        public void RegistrationTestValidData()
        {
            RequestHelper requestHelper = new RequestHelper("/doregister"); //URL куда отправляем запрос

            SignInRequestModel body = new SignInRequestModel() // В созданую модель присваиваем данные
            { 
                Email = Helper.GenerateEmail(), 
                Name = Helper.GenerateName(), 
                Password = "mySecretPass123" 
            };

           
            IRestResponse response = requestHelper.SendPostRequest(body); //Отправляем запрос

            JObject json = JObject.Parse(response.Content); //Считываем ответ в JSON

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Email, json["email"]?.ToString());
            Assert.AreEqual(body.Name, json["name"]?.ToString());

        }

        [Test]
        public void RegistrationEmptyPassword()
        {
            RequestHelper requestHelper = new RequestHelper("/doregister");
            SignInRequestModel body = new SignInRequestModel
            {
                Email = "Shopopalo@fake.com",
                Name = "Jiuk",
                Password = ""
            };            
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual(" не правильный пароль", json["message"]?.ToString());//должен не проходить потому что Бага
        }

        [TestCase("")]
        [TestCase("Shopopalofake.com")]
        [TestCase("Shopopalo@fakecom")]
        [TestCase("@fake.com")]
        [TestCase("Shopopalo @fake.com")]
        [TestCase("Shopopalo@")]
        [TestCase("  Shopopalo@fake.com")]
        [TestCase(" 12.com")]
        public void RegistrationInvalidEmail(string email)
        {
            RequestHelper requestHelper = new RequestHelper("/doregister");
            SignInRequestModel body = new SignInRequestModel
            {
                Email = email,
                Name = "Juk",
                Password = "mySecretPass123"
            };            
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual(" Некоректный  email " + email, json["message"]?.ToString());
        }

        [Test]
        public void CreateUser()
        {
            RequestHelper requestHelper = new RequestHelper("tasks/rest/createuser");
            CreateUserModel body = new CreateUserModel
            {
                Email = Helper.GenerateEmail(),
                Name = Helper.GenerateName(),
                Tasks = new List<int> { 6 },
                Companies = new List<int> { 36, 37 }
            };

            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);
          
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(body.Email, json["email"]?.ToString());
            Assert.AreEqual(body.Name, json["name"]?.ToString());
        }
    }
}