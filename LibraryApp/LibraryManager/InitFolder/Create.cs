using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.InitFolder
{
    public class Create
    {
        private static void CreateFolder()
        {
            try
            {
                if (!Directory.Exists(Path.folderPath))
                    Directory.CreateDirectory(Path.folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo folder Data: " + ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreateBookFolder()
        {
            CreateFolder();
            try
            {
                if (!Directory.Exists(Path.bookPath))
                    Directory.CreateDirectory(Path.bookPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo folder Book: " + ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreateBorrowPaybackFolder()
        {
            CreateFolder();
            try
            {
                if (!Directory.Exists(Path.borrowpaybackPath))
                    Directory.CreateDirectory(Path.borrowpaybackPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo folder BorrowPayback: " + ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreatPersonFolder()
        {
            CreateFolder();
            try
            {
                if (!Directory.Exists(Path.personPath))
                    Directory.CreateDirectory(Path.personPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo folder Person: " + ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void InitFolder()
        {
            CreateFolder();
            CreateBookFolder();
            CreateBorrowPaybackFolder();
            CreatPersonFolder();
        }
    }
}
