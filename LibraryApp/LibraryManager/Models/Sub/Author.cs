using LibraryManager.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Sub
{
    public class Author : Person
    {
        public string PenName { get; set; } = string.Empty;

        public Author(int id, string fullName, string penName, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            PenName = penName;
            PhoneNumber = phoneNumber;
        }
    }
}
