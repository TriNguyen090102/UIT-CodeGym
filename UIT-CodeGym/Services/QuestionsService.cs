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
            setUpDB();
        }

        private void setUpDB()
        {
            client = new MongoClient("mongodb+srv://admin1:admin123@cluster0.ud0f6fw.mongodb.net/?retryWrites=true&w=majority");
            db = client.GetDatabase("UIT-CodeGym");
        }


         public System.Collections.Generic.List<QuestionModel> fetchOperatorsQuestions() 
        {
            var operatorsQuestionCollection =  db.GetCollection<QuestionModel>("QuestionDB");
            var filter =  Builders<QuestionModel>.Filter.Eq("title", "operators"); ;
            var documents =  operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }

        public System.Collections.Generic.List<QuestionModel> fetchPointerQuestions()
        {
            var operatorsQuestionCollection = db.GetCollection<QuestionModel>("QuestionDB");
            var filter = Builders<QuestionModel>.Filter.Eq("title", "pointer"); ;
            var documents = operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }

        public System.Collections.Generic.List<QuestionModel> fetchSwitchQuestions()
        {
            var operatorsQuestionCollection = db.GetCollection<QuestionModel>("QuestionDB");
            var filter = Builders<QuestionModel>.Filter.Eq("title", "switch"); ;
            var documents = operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }
    }
}
