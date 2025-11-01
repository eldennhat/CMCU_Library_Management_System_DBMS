using LibraryManager.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Sub
{
    public class Staff : Person
    {
        public string Role { get; set; }

        public Staff(string id, string fullName, string phoneNumber, string role, bool isActive)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Role = role;
            IsActive = isActive;
        }
    }
}
