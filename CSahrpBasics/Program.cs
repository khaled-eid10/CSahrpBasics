using CSahrpBasics.Classes;
using CSahrpBasics.Structs;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace CSahrpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Book book = new Book("Clean Code" , "Atomic Hapits" , "Rich Dad Poor Dad");
          BorrowedBook borrowedBook = new BorrowedBook(1, book , "Khaled" , DateTime.Now.AddDays(-5));
          Console.WriteLine($"Book: {borrowedBook.BookDetalis.Title}, Borrowed by: {borrowedBook.BorrowerName}, Borrowed Date: {borrowedBook.BorrowedDate}, Is Available: {borrowedBook.IsAvailable}");

          borrowedBook.CheckOut(); 
          Console.WriteLine($"Is Available: {borrowedBook.IsAvailable}");

          borrowedBook.ReturnItem(); 
          Console.WriteLine($"Is Available: {borrowedBook.IsAvailable}");

          int borrowDuration = borrowedBook.CalculateBorrowDuration(); 
          Console.WriteLine($"Book has been borrowed for {borrowDuration} days.");

        }
    }
}
