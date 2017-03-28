using System.Collections.Generic;

namespace COAssignment.Publisher.Db
{
    public class Book : MongoEntity
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public List<string> Authors { get; set; }



    }
}