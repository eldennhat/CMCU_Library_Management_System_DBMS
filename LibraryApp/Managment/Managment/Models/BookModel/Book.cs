using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.BookModel
{
    public class Book
    {
        public int BookId { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? CategoryName { get; set; }
	    public string? BookAuthor { get; set; }
	    public int PublishYear { get; set; }
    }
}
