using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.Net
{
    public class BookRepository
    {
        public string connectionString = @"Server=localhost;Database=bookish_dataBase;Trusted_Connection=True;";
        public IEnumerable<Book> GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>("SELECT * FROM Books");
        }
    }
}
