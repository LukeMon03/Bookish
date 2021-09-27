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
            // sort in to aplha
            return connection.Query<Book>("SELECT * FROM Books");
        }
        public IEnumerable<Book> GetAllUserCopies(int UserID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>($"SELECT * FROM Copies WHERE UserID = {UserID}");
        }
        public IEnumerable<Book> SearchForBooks(string Search)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            // change or statement
            return connection.Query<Book>($"SELECT * FROM Books WHERE Author CONTAINS {Search} OR Book_Name CONTAINS {Search}");
        }
        public IEnumerable<Copy> CopiesInfo(int Book_ID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            // find out how many copies
            // number of copies without a userID
            // copies with a user ID, get date due to return and username
            
            return connection.Query<Copy>($"SELECT * FROM Copies WHERE BookID = {Book_ID}");
        }
        public IEnumerable<Book> AddBook()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>("INSERT (BookDetails) INTO Books");
        }
        
    }
}


