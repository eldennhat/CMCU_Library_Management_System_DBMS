using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Models.HumanModel
{
    public class Reader : Person
    {
        public string Address { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        
        public Reader(int id, string fullName, string phoneNumber, string address, DateTime createAt, string fine, string deposit)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Address = address;
            CreateAt = createAt;
        }
    }
}
