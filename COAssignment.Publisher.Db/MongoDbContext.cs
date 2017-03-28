using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace COAssignment.Publisher.Db
{
    public class MongoDbContext
    {
        private IMongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Book> _publisherCollection;

        public MongoDbContext()
        {
            const string connectionString = "mongodb://localhost";

            // Create a MongoClient object by using the connection string
            client = new MongoClient(connectionString);

            // Use the server to access the 'test' database
            database = client.GetDatabase("Crossover");

            _publisherCollection = database.GetCollection<Book>("Book");
        }

        public IMongoQueryable<Book> Books => _publisherCollection.AsQueryable();
    }
}
