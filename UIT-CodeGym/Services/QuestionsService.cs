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

        public async Task<bool> InsertQuestionToQuestionDB(QuestionModel newQuestion)
        {
            var questionCollection = db.GetCollection<QuestionModel>("QuestionDB");
            try
            {
                await questionCollection.InsertOneAsync(newQuestion);
                return true; // Indicate success
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions appropriately
                //Console.WriteLine("Error inserting question: {0}", ex.Message);
                return false; // Indicate failure
            }
        }


        public bool IsAdmin(string username) {
            var adminCollection = db.GetCollection<UserModel>("AdminAcount");
            var filter = Builders<UserModel>.Filter.Eq("user", username);
            var documents = adminCollection.Find(filter).ToList();
            if (documents.Count > 0) { return true; }
            
            return false;
        }
        public async void UpdateUsersRecord(string username, int point)
        {
            if(point == 10)
            {
                var userRecordCollection = db.GetCollection<UserRecordModel>("UserRecord");
                var filter = Builders<UserRecordModel>.Filter.Eq("username", username); ;
                var documents = userRecordCollection.Find(filter).ToList();
                if (documents.Count > 0)
                {
                    var oldValue = documents[0].Score;
                    var update = Builders<UserRecordModel>.Update.Set("score", oldValue + 1);
                    await userRecordCollection.UpdateOneAsync(filter, update);
                }
                else
                {
                    //add a new record
                    try
                    {
                        UserRecordModel newRecord = new()
                        {
                            UserName = username,
                            Score = 1
                        };
                        await userRecordCollection.InsertOneAsync(newRecord);
                       
                    }
                    catch (Exception ex)
                    {
                        
                    }

                }
                

            }    
        }

        public System.Collections.Generic.List<QuestionModel> FetchQuestions(string title) 
        {
            var operatorsQuestionCollection =  db.GetCollection<QuestionModel>("QuestionDB");
            var filter =  Builders<QuestionModel>.Filter.Eq("title", title);
            var documents =  operatorsQuestionCollection.Find(filter).ToList();

            return documents;
        }

        //public System.Collections.Generic.List<QuestionModel> FetchPointerQuestions()
        //{
        //    var operatorsQuestionCollection = db.GetCollection<QuestionModel>("QuestionDB");
        //    var filter = Builders<QuestionModel>.Filter.Eq("title", "pointer"); ;
        //    var documents = operatorsQuestionCollection.Find(filter).ToList();

        //    return documents;
        //}

        //public System.Collections.Generic.List<QuestionModel> FetchSwitchQuestions()
        //{
        //    var operatorsQuestionCollection = db.GetCollection<QuestionModel>("QuestionDB");
        //    var filter = Builders<QuestionModel>.Filter.Eq("title", "switch"); ;
        //    var documents = operatorsQuestionCollection.Find(filter).ToList();

        //    return documents;
        //}


        public System.Collections.Generic.List<UserRecordModel> FetchUsersRecord(string title)
        {
            var operatorsQuestionCollection = db.GetCollection<UserRecordModel>("UserRecord");
            var filter = Builders<UserRecordModel>.Filter.Eq("title", title); ;
            var documents = operatorsQuestionCollection.Find(filter).ToList();
            return documents;
        }
    }
}
