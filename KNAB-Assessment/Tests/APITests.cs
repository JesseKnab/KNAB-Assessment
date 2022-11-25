using NUnit.Framework;
using System;
using RestSharp;


namespace KNAB_Assessment.Tests
{
    [TestFixture]
    public class APITests
	{
        private string token = "1e3fa39780c1b75c5acb8c3ba9390883";
        private string appKey = "5b90beb8391be3a47acb3cd6a80aa72564ce397577f1b37d80f3fe4e167d0252";

        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public static void apiTest()
        {
            //string url = "https://api.trello.com";
            string url = "https://api.trello.com/1/cards?key=1e3fa39780c1b75c5acb8c3ba9390883&token=5b90beb8391be3a47acb3cd6a80aa72564ce397577f1b37d80f3fe4e167d0252&idList=6380ad590ff28d0c9a276f1d&name=test card visual studio";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            var response = client.Post(request);

            Console.WriteLine(response.Content.ToString());
            Console.Read();

        }
        
        [TearDown]
        public void TearDown()
        {
            //remove board, list, card
        }
    }
}

