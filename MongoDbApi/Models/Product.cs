using System.Collections.Generic;
using System.Linq;
using System;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbApi.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public DateTime Expery   { get; set; }
        public string caegory { get; set; } 
    }
}
