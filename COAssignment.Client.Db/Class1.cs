using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COAssignment.Client.Db
{
    public class LibraryDbContext : DbContext
    {

    }

    public class MemberBookRequestLogs
    {
        public int UserId { get; set; }
        public DateTime RequestDateTime { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }

    public class Member
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
}
