using NUnit.Framework;
using System;
using RestSharp;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace KNAB_Assessment.Tests
{
    [TestFixture]
    public class APITests
	{
        private static string url = "https://api.trello.com";
        private static string appKey = "1e3fa39780c1b75c5acb8c3ba9390883";
        private static string token = "5b90beb8391be3a47acb3cd6a80aa72564ce397577f1b37d80f3fe4e167d0252";
        private static string sep = "&";
        private static string addCredentials = sep + "key=" + appKey + sep + "token=" + token;
        
        //operations
        private static string createBoard = url + "/1/boards?";
        private static string onBoard = url + "/1/boards/";
        private static string createList = "/lists?";
        private static string createCard = url + "/1/cards?";

        //attributes
        private static string assignName = sep + "name=";

        //targets
        private static string onIdList = sep + "idList=";

        [Test]
        public void createBoardListAndCardTest()
        {
            string idBoard = createNewBoard("New Board A");
            string idList = createNewList(idBoard, "New List B");
            string idCard = createNewCard(idList, "New Card C");
        }

        public string createNewBoard(string boardName)
        {
            string stringToPostBoard = createBoard + assignName + boardName + addCredentials;
            return postRequest(stringToPostBoard); ;
        }

        public string createNewList(string idBoard, string listName)
        {
            string stringToPostList = onBoard + idBoard + createList + assignName + listName + addCredentials;
            return postRequest(stringToPostList);
        }

        public string createNewCard(string idList, string cardName)
        {
            string stringToPostCard = createCard + onIdList + idList + assignName + cardName + addCredentials;
            return postRequest(stringToPostCard);
        }


        public static string postRequest(string stringToPost)
        {
            Console.WriteLine("posting:" + stringToPost);
            RestClient client = new RestClient(stringToPost);
            RestRequest request = new RestRequest();
            var response = client.Post(request);
            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"), "error: request not accepted, status code: " + response.StatusCode.ToString());
            string responseBody = response.Content.ToString();
            string id = responseBody.Substring(responseBody.IndexOf("id") + 5, responseBody.IndexOf("id") + 22);
            //Console.WriteLine("ID = " + id);
            return id;
        }

        [TearDown]
        public void TearDown()
        {
            //todo: remove board, list, card
        }
    }
}

