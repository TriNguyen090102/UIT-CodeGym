using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIT_CodeGym.Models
{
    public class UserRecordModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("username")]
        public string UserName { get; set; }
        [BsonElement("score")]
        public int Score { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
    }
}
