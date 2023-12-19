using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;
using UIT_CodeGym.Models;
using static Realms.ThreadSafeReference;

namespace UIT_CodeGym.database
{
    internal class QuestionsService
    {

        private MongoClient client;
        private IMongoDatabase db;

        public QuestionsService() {
            SetUpDB();
        }

        private void SetUpDB()
        {
            client = new MongoClient("mongodb+srv://admin1:admin123@cluster0.ud0f6fw.mongodb.net/?retryWrites=true&w=majority");
            db = client.GetDatabase("UIT-CodeGym");
        }

        public bool IsAdmin(string username) {
            var adminCollection = db.GetCollection<UserModel>("AdminAcount");
            var filter = Builders<UserModel>.Filter.Eq("user", username);
            var documents = adminCollection.Find(filter).ToList();
            if (documents.Count > 0) { return true; }
            
            return false;
        }

         public System.Collections.Generic.List<QuestionModel> FetchOperatorsQuestions() 
        {
            var operatorsQuestionCollection =  db.GetCollection<QuestionModel>("QuestionDB");
            var filter =  Builders<QuestionModel>.Filter.Eq("title", "operators"); ;
            var documents =  operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }

        public System.Collections.Generic.List<QuestionModel> FetchPointerQuestions()
        {
            var operatorsQuestionCollection = db.GetCollection<QuestionModel>("QuestionDB");
            var filter = Builders<QuestionModel>.Filter.Eq("title", "pointer"); ;
            var documents = operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }

        public System.Collections.Generic.List<QuestionModel> FetchSwitchQuestions()
        {
            var operatorsQuestionCollection = db.GetCollection<QuestionModel>("QuestionDB");
            var filter = Builders<QuestionModel>.Filter.Eq("title", "switch"); ;
            var documents = operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }
    }
}
