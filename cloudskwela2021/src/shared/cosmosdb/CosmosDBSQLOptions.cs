using Microsoft.Azure.Cosmos;

namespace shared
{
    public class CosmosDBSQLOptions
    {
 
        public string EndpointUri { get; set; }
        public string Key { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
        public int DefaultRU { get; set; }

        public ConnectionMode ConnectionMode { get; set; }
        public CosmosSerializer Serializer { get; set; }
    
    }
}