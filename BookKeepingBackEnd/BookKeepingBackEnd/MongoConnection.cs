using MongoDB.Driver;

namespace BookKeepingBackEnd
{
    /// <summary>
    /// This class creates the connection needed to reach a Mongo DB
    /// </summary>
    public class MongoConnection
    {
        MongoClient _client;
        public MongoConnection()
        {
            _client = new MongoClient(WebApplication.CreateBuilder().Configuration.GetConnectionString("AtlasString"));
        }
    }
}
