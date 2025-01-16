using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Relationships.Aggregation
{
    public class Library
    {
        public List<Book> books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Title} Successfully Added!");
        }
    }
}
