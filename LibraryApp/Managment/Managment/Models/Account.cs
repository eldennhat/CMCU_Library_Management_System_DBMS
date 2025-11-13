using Managment.Enumeration;

namespace Managment.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
	    public string PasswordHash { get; set; }
	    public role Role { get; set; }
        public int StaffId { get; set; } // liên kết với nhân viên (có thể null cho admin hệ thống)
    }
}
