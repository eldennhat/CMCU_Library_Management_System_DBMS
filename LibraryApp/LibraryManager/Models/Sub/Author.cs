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

        public Author(string id, string fullName, string penName)
        {
            Id = id;
            FullName = fullName;
            PenName = penName;
        }
    }
}
