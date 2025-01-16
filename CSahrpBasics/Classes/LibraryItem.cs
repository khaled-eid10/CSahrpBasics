using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Classes
{
    public class LibraryItem
    {
        [Key]
        public int ItemId {  get; set; }
        public bool IsAvailable { get; set; }

        public LibraryItem(int itemId) 
        { 
            ItemId = itemId; 
            IsAvailable = true; 
        }

        public void CheckOut()
        {
            IsAvailable = false;

        }
        public void ReturnItem()
        {
            IsAvailable = true;

        }
    }
}
