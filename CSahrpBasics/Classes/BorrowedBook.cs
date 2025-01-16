using CSahrpBasics.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Classes
{
    public class BorrowedBook : LibraryItem
    {
       

        public Book BookDetalis {  get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }
        public BorrowedBook(int itemId, Book bookDetalis, string borrowerName, DateTime borrowedDate) : base(itemId)
        {
            BookDetalis = bookDetalis;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;

        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }
    }
}
