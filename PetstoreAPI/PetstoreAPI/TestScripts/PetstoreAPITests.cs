using Newtonsoft.Json;
using PetstoreAPI.Utilities;
using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreAPI.TestScripts
{
    public class PetstoreAPITests:CoreCodes
    {
        [Test]
        [Order(1)]
        public void GetLogsUserIntoSystemTest()
        {
            test = extent.CreateTest("Get Logs User Into System");
            Log.Information("Get Logs User Into System Test Started");

            var request = new RestRequest("/login?username=test&password=abc123", Method.Get);
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);

                Assert.NotNull(user);
                Log.Information("User returned");
                Assert.That(user.Code, Is.EqualTo(200));
                Log.Information($"User Code matches with fetch {user.Code}");
                Assert.That(user.Type, Is.EqualTo("unknown"));
                Log.Information($"User Type matches with fetch {user.Type}");
                Assert.IsNotEmpty(user.Message);
                Log.Information($"User Message matches with fetch");
                

                Log.Information("Get Logs User Into System test passed");
                test.Pass("Get Logs User Into System Test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Get Logs User Into System test failed");
            }
        }

        [Test]
        [Order(2)]
        public void GetLogsOutCurrentLoggedInUserSessionTest()
        {
            test = extent.CreateTest("Get Logs Out Current Logged In User Session");
            Log.Information("Get Logs Out Current Logged In User Session Test Started");

            var request = new RestRequest("/logout", Method.Get);
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);

                Assert.NotNull(user);
                Log.Information("User returned");
                Assert.That(user.Code, Is.EqualTo(200));
                Log.Information($"User Code matches with fetch {user.Code}");
                Assert.That(user.Type, Is.EqualTo("unknown"));
                Log.Information($"User Type matches with fetch {user.Type}");
                Assert.That(user.Message, Is.EqualTo("ok"));
                Log.Information($"User Message matches with fetch {user.Message}");


                Log.Information("Get Logs Out Current Logged In User Session test passed");
                test.Pass("Get Logs Out Current Logged In User Session Test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Get Logs Out Current Logged In User Session test failed");
            }
        }

        [Test]
        [Order(3)]
        public void CreateUserTest()
        {
            test = extent.CreateTest("Create User");
            Log.Information("Create User Test Started");

            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new
            {
                id = 100,
                username = "user2",
                firstName = "Ajay",
                lastName = "Kumar",
                email = "ajaykumar@gmail.com",
                password = "12345",
                phone = "9875775673",
                userStatus = 1
            });

            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);
                Assert.NotNull(user);
                Assert.That(user.Code, Is.EqualTo(200));
                Log.Information($"User Code matches with fetch {user.Code}");
                Assert.That(user.Type, Is.EqualTo("unknown"));
                Log.Information($"User Type matches with fetch {user.Type}");
                Assert.That(user.Message, Is.EqualTo("100"));
                Log.Information($"User Message matches with fetch {user.Message}");

                Log.Information("Create User test passed");

                test.Pass("Create User Test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Create User test failed");
            }
        }

        [Test]
        [Order(4)] 
        public void UpdateUserTest()
        {
            test = extent.CreateTest("Update User");
            Log.Information("Update User Test Started");

            var request = new RestRequest("/user1", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new
            {
                id = 100,
                username = "user1",
                firstName = "Ajaay",
                lastName = "Kumar",
                email = "ajaykumar@gmail.com",
                password = "12345",
                phone = "9875775673",
                userStatus = 1
            });

            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);
                Assert.NotNull(user);
                Log.Information("User updated and returned");
                Assert.That(user.Code, Is.EqualTo(200));
                Log.Information($"User Code matches with fetch {user.Code}");
                Assert.That(user.Type, Is.EqualTo("unknown"));
                Log.Information($"User Type matches with fetch {user.Type}");
                Assert.That(user.Message, Is.EqualTo("100"));
                Log.Information($"User Message matches with fetch {user.Message}");

                Log.Information("Update User test passed");

                test.Pass("Update User Test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Update User test failed");
            }
        }

        [Test]
        [Order(5)]
        public void DeleteUserTest()
        {
            test = extent.CreateTest("Delete User");
            Log.Information("Delete User Test Started");

            var request = new RestRequest("/user1", Method.Delete);
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);
                Assert.That(user.Code, Is.EqualTo(200));
                Log.Information($"User Code matches with fetch {user.Code}");
                Assert.That(user.Type, Is.EqualTo("unknown"));
                Log.Information($"User Type matches with fetch {user.Type}");
                Assert.That(user.Message, Is.EqualTo("user1"));
                Log.Information($"User Message matches with fetch {user.Message}");
               
                Log.Information("Delete User test passed");
                test.Pass("Delete User test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Delete User test failed");
            }
        }
    }
}
