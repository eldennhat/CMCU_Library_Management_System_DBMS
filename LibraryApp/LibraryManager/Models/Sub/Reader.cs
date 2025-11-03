using LibraryManager.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Sub
{
    public class Reader : Person
    {
        public string Address { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public string Fine { get; set; } // tiền phạt
        public string Deposit { get; set; } // tiền đặt cọc bằng 150% hoặc 200% tiền thuê sách (luôn > tiền sách + tiền phạt)
        public Reader(int id, string fullName, string phoneNumber, string address,  DateTime createAt, string fine, string deposit)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Address = address;
            CreateAt = createAt;
            Fine = fine;
            Deposit = deposit;
        }
    }
}
