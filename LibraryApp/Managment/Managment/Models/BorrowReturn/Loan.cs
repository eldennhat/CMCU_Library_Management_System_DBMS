using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Models.BorrowReturn
{
    public class Loan
    {
        // Thông tin chi tiết phiếu mượn sách
        public int LoanDetailId { get; set; }          // ID chi tiết
        public int LoanId { get; set; }                 // ID phiếu mượn
        public int CopyId { get; set; }                 // ID bản sao sách
        public DateTime? ReturnedDate { get; set; }     // Ngày trả thực tế
        public decimal? Fine { get; set; }              // Tiền phạt
        public decimal? Deposit { get; set; }           // Tiền cọc

        // Thông tin phiếu mượn
        public int ReaderId { get; set; }               // ID độc giả
        public string? ReaderName { get; set; }         // Tên độc giả
        public string? ReaderPhone { get; set; }        // SĐT độc giả

        public int StaffId { get; set; }                // ID nhân viên
        public string? StaffName { get; set; }          // Tên nhân viên

        public DateTime LoanDate { get; set; }          // Ngày mượn
        public DateTime DueDate { get; set; }           // Ngày hẹn trả
        public string? LoanNote { get; set; }           // Ghi chú phiếu mượn

        // Thông tin sách
        public int BookId { get; set; }                 // ID đầu sách
        public string? Barcode { get; set; }            // Mã vạch
        public string? BookTitle { get; set; }          // Tên sách
        public string? BookAuthor { get; set; }         // Tác giả
        public string? ISBN { get; set; }               // ISBN
        public decimal? BookMoney { get; set; }         // Giá sách
        public string? PublisherName { get; set; }      // Nhà xuất bản

        // Tự động tính
        public bool IsReturned => ReturnedDate.HasValue;

        public bool IsOverdue => !IsReturned && DateTime.Now > DueDate;

        public int DaysOverdue
        {
            get
            {
                if (IsReturned) return 0;
                if (DateTime.Now <= DueDate) return 0;
                return (DateTime.Now - DueDate).Days;
            }
        }

        public string Status
        {
            get
            {
                if (IsReturned) return "Đã trả";
                if (IsOverdue) return $"Quá hạn {DaysOverdue} ngày";
                return "Đang mượn";
            }
        }

        public decimal TotalFine
        {
            get
            {
                // Tính phạt 
                if (!IsOverdue || IsReturned) return Fine ?? 0;

                int daysFromLoan = (DateTime.Now - LoanDate).Days;
                int daysLate = (DateTime.Now - DueDate).Days;

                if (daysFromLoan <= 10)
                    return daysLate * 20000;
                else
                    return (BookMoney ?? 0) * 2;
            }
        }
    }
}

