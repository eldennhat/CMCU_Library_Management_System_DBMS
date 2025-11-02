using LibraryManager.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Other
{
    public class RegisterUser
    {
        public int id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
        public string? phoneNumber { get; set; }
    }
}
