using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COAssignment.Publisher.Db;

namespace COAssignment.Publisher.Api.Controllers
{
    public class BookController : ApiController
    {
        private MongoDbContext context;

        public BookController()
        {
            context = new MongoDbContext();
        }

        public IEnumerable<Book> Get(int pageSize = 200, int skip = 0, string title = "", string publisher = "")
        {
            var a = (
                from book in context.Books
                where (
                (string.IsNullOrEmpty(title) || book.Title.Contains(title))
                && (string.IsNullOrEmpty(publisher) || book.Publisher.Contains(publisher))
                )
                select book
                    ).Skip(skip)
                    .Take(pageSize)
                    .ToList()
                    ;

            return a;
        }
    }
}
