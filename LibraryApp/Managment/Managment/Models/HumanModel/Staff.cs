using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Models.HumanModel
{
    public class Staff : Person
    {
        public string Role { get; set; }
        public TimeOnly DefaultStart { get; set; }
        public TimeOnly DefaultEnd { get; set; }

        public Staff(int id, string fullName, string phoneNumber, string role, TimeOnly defaultStart, TimeOnly defaultEnd)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Role = role;
            DefaultStart = defaultStart;
            DefaultEnd = defaultEnd;
        }
    }
}
