using MongoDB.Bson;

namespace COAssignment.Publisher.Db
{
    public abstract class MongoEntity
    {
        public ObjectId id { get; set; }
    }
}