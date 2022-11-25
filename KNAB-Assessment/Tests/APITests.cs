using NUnit.Framework;
using System;
using RestSharp;


namespace KNAB_Assessment.Tests
{
    [TestFixture]
    public class APITests
	{
        private static string url = "https://api.trello.com";
        private static string appKey = "1e3fa39780c1b75c5acb8c3ba9390883";
        private static string token = "5b90beb8391be3a47acb3cd6a80aa72564ce397577f1b37d80f3fe4e167d0252";
        private static string sep = "&";
        private static string credentials = "?key=" + appKey + sep + "token=" + token;
        
        //operations
        private static string createCard = url + "/1/cards" + credentials;

        //attributes
        private static string assignName = sep + "name=";

        //targets
        private static string onIdList = sep + "idList=";


        [Test]
        public static void apiTest()
        {
            string idList = "6380ad590ff28d0c9a276f1d";
            string stringToPost = createCard + onIdList + idList + assignName + "test card visual studio 2";
            Console.WriteLine("posting:" + stringToPost);

            RestClient client = new RestClient(stringToPost);
            RestRequest request = new RestRequest();
            var response = client.Post(request);
            Console.WriteLine("response: " + response.Content.ToString());
            Console.Read();

        }
        
        [TearDown]
        public void TearDown()
        {
            //todo: remove board, list, card
        }
    }
}

