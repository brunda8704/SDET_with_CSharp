using GorestAPI.Helper;
using GorestAPI.Utilities;
using Newtonsoft.Json;
using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GorestAPI.TestScripts
{
    internal class GorestAPITests:CoreCodes
    {
        [Test]
        [Order(1)]
        [Category("GET")] //Grouping based on Https methods
        public void GetAllUsersTest()
        {
            test = extent.CreateTest("Get All User");
            Log.Information("Get All User Test Started");

            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");
                Log.Information("****************************");

                List<UserData> users = JsonConvert.DeserializeObject<List<UserData>>(response.Content);

                Assert.NotNull(users);
                Log.Information("Get All User test passed");
                Log.Information("\n");

                test.Pass("Get All User test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Get All User test failed");
            }
        }

        [Test]
        [Order(2)]
        [TestCase(5837962)]
        [Category("GET")]
        public void GetSingleUserTest(int userId)
        {
            test = extent.CreateTest("Get Single User");
            Log.Information("Get Single User Test Started");

            var request = new RestRequest("/" + userId, Method.Get);
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);

                Assert.NotNull(user);
                Log.Information("User returned");
                Assert.That(user.Id, Is.EqualTo(5837962));
                Log.Information($"User Id matches with fetch {user.Id}");
                Assert.That(user.Name, Is.EqualTo("Chandraketu Verma CPA"));
                Log.Information($"User Name matches with fetch {user.Name}");
                Assert.That(user.Email, Is.EqualTo("chandraketu_verma_cpa@greenholt-marks.test"));
                Log.Information($"User Email matches with fetch {user.Email}");
                Assert.That(user.Gender, Is.EqualTo("female"));
                Log.Information($"User Gender matches with fetch {user.Gender}");
                Assert.That(user.Status, Is.EqualTo("active"));
                Log.Information($"User Status matches with fetch {user.Status}");

                Log.Information("Get Single User test passed");
                test.Pass("Get Single User Test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Get Single User test failed");
            }
        }

        [Test]
        [Order(3)]
        [Category("POST")]
        public void CreateUserTest()
        {
            test = extent.CreateTest("Create User");
            Log.Information("Create User Test Started");

            string bearerToken = "2a57653a96ce31d1b6ebfd4946277174476489c46382c9a59f0628827fc6e5c3";
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            request.AddJsonBody(new 
            {
                name = "Arya",
                email = "arya@gmail.com",
                gender = "male",
                status = "active"
            });
            
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Created));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);
                Assert.NotNull(user);
                Log.Information("User created and returned");
                Assert.That(user.Name, Is.EqualTo("Arya"));
                Log.Information($"User Name matches with fetch {user.Name}");
                Assert.That(user.Email, Is.EqualTo("arya@gmail.com"));
                Log.Information($"User Email matches with fetch {user.Email}");
                Assert.That(user.Gender, Is.EqualTo("male"));
                Log.Information($"User Gender matches with fetch {user.Gender}");
                Assert.That(user.Status, Is.EqualTo("active"));
                Log.Information($"User Status matches with fetch {user.Status}");

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
        [TestCase(5836135)]
        [Category("PUT")]
        public void UpdateUserTest(int userId)
        {
            test = extent.CreateTest("Update User");
            Log.Information("Update User Test Started");

            string bearerToken = "2a57653a96ce31d1b6ebfd4946277174476489c46382c9a59f0628827fc6e5c3";
            var request = new RestRequest("/" + userId, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            request.AddJsonBody(new 
            {
                name = "AshwiniRaj",
                email = "ashwiniRaj@gmail.com",
                gender = "female",
                status = "active"
            });

            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);
                Assert.NotNull(user);
                Log.Information("User updated and returned");
                Assert.That(user.Name, Is.EqualTo("AshwiniRaj"));
                Log.Information($"User Name matches with fetch {user.Name}");

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
        [TestCase(5836135)]
        [Category("PATCH")]
        public void PartialUpdateUserTest(int userId)
        {
            test = extent.CreateTest("Partial Update User");
            Log.Information("Partial Update User Test Started");

            string bearerToken = "2a57653a96ce31d1b6ebfd4946277174476489c46382c9a59f0628827fc6e5c3";
            var request = new RestRequest("/" + userId, Method.Patch);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            request.AddJsonBody(new
            {
                status = "inactive"
            });

            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
                Log.Information($"API Response: {response.Content}");

                var user = JsonConvert.DeserializeObject<UserData>(response.Content);
                Assert.NotNull(user);
                Log.Information("User updated and returned");
                Assert.That(user.Status, Is.EqualTo("inactive"));
                Log.Information($"User Status matches with fetch {user.Status}");

                Log.Information("Partial Update User test passed");

                test.Pass("Partial Update User Test passed");
            }
            catch (AssertionException)
            {
                test.Fail("Partial Update User test failed");
            }
        }

        [Test]
        [Order(6)]
        [TestCase(5837958)]
        [Category("DELETE")]
        public void DeleteUserTest(int userId)
        {
            test = extent.CreateTest("Delete User");
            Log.Information("Delete User Test Started");

            string bearerToken = "2a57653a96ce31d1b6ebfd4946277174476489c46382c9a59f0628827fc6e5c3";
            var request = new RestRequest("/" + userId, Method.Delete);
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            var response = client.Execute(request);

            try
            {
                Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.NoContent));
                Log.Information($"API Response: {response.Content}");

                Log.Information("User deleted");
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
