using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManager.Models.BorrowPayback
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int ReaderId { get; set; }
        public string? ReaderName { get; set; }
        public int StaffId { get; set; }
        public string? StaffName { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal FineAmount { get; set; }
        public string? Note { get; set; }
    }
}
