using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;

namespace RestSharpTest
{
    [TestClass]
    public class TestDeleteEndPoint
    {
        string Authorization = "Bearer BQD8wtGACa3bl7H9g--CFvp7WHYh-OF-eal2DteipAULDAAr2O0lcv8Mv8yRHBFln8frx6_" +
            "zGprh8KfrmD0IftxzU1zLAHjh0akAGHcQVTvnZuON119C8C7UUptS3CE-IiKZGFgFPVw1AWGVl-7qcIWIDHazXgS3ne223Jw_" +
            "fybdUD8cuGLvgsN-y991ZzDZo7OW9GE-58ux5GhXDhb4WcIHcPgp7qfmunjs8GNyi7i8bFZpcs2KnDB-KCYgpl1K-ZkSlwHETA-" +
            "dL4txgd19NhHWf1E8Ml1uUckoUonT";

        string deleteUrl = "https://api.spotify.com/v1/playlists/7wxTR8fsh1RacMA8xcmAyl/tracks";

        string json = "{ \"tracks\":" +
                         "[{ \"uri\": \"spotify:track:7mtYsNBYTDPa8Mscf166hg\"}]}";

        private static IRestResponse restResponse { get; set; }

        [TestMethod]

        public void TestDeleteWithJson()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(deleteUrl);

            restRequest.AddHeader("Authorization", "token" + Authorization);

            restRequest.AddJsonBody(json);

            restResponse = restClient.Delete(restRequest);

            Assert.AreEqual(200, (int)restResponse.StatusCode);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine((int)restResponse.StatusCode);
                Console.WriteLine(restResponse.Content);
            }
            else
            {
                Console.WriteLine(restResponse.ErrorMessage);
                Console.WriteLine(restResponse.ErrorException);
            }
        }
    }

    internal interface IRestClient
    {
    }
}

    
