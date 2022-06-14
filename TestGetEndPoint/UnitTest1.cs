using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGetEndPoint
{
    [TestClass]
    public class UnitTest1
    {
        private string getUrl = "https://api.spotify.com/v1/me";
        private string myToken = "Bearer BQD8wtGACa3bl7H9g--CFvp7WHYh-OF-eal2DteipAULDAAr2O0lcv8Mv8yRHBFln8frx6_" +
            "zGprh8KfrmD0IftxzU1zLAHjh0akAGHcQVTvnZuON119C8C7UUptS3CE-IiKZGFgFPVw1AWGVl-7qcIWIDHazXgS3ne223Jw_" +
            "fybdUD8cuGLvgsN-y991ZzDZo7OW9GE-58ux5GhXDhb4WcIHcPgp7qfmunjs8GNyi7i8bFZpcs2KnDB-KCYgpl1K-ZkSlwHETA-" +
            "dL4txgd19NhHWf1E8Ml1uUckoUonT";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);

            restRequest.AddHeader("Authorization", "token" + myToken);
            restResponse = restClient.Get(restRequest);
            Assert.AreEqual(200, (int)restResponse.StatusCode);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code:" + restResponse.StatusCode);
                Console.WriteLine("Response: " + restResponse.Content);
            }
            Console.WriteLine(restResponse.ErrorMessage);
            Console.WriteLine(restResponse.ErrorException);
        }
    }
}
