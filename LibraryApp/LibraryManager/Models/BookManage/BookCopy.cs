using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.BookManage
{
    public class BookCopy
    {
        public enum status
        {
            Lost = -1,
            Available = 0,
            OnLoan = 1,
            Damaged = 2
        }

        public int CopyId { get; set; }
        public int BookId { get; set; }
        public string? Barcode { get; set; }

        public string? StorageNote { get; set; }
        public decimal BookMoney { get; set; }
        public string? PublisherName { get; set; }
        public status Status { get; set; }
    }
}
