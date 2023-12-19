using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UIT_CodeGym.Models
{
    
    public class QuestionModel
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("title")]
        public string title { get; set; }

        [BsonElement("question")]
        public string question { get; set; }

        [BsonElement("a")]
        public string a { get; set; }

        [BsonElement("b")]
        public string b { get; set; }

        [BsonElement("c")]
        public string c { get; set; }

        [BsonElement("d")]
        public string d { get; set; }

        [BsonElement("correct_answer")]
        public string correct_answer { get; set; }
    }
}
