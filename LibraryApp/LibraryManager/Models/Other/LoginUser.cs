using LibraryManager.Models.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Other
{
    public class LoginUser
    {
        public int AccountId { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
        public int? StaffId { get; set; } // Nếu cần liên kết với nhân viên
    }
}
