using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebMachine.Models {
    class Client {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public long IdClient { get; set; }
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; } = "";
        public bool IsUpdate { get; set; }
    }
}