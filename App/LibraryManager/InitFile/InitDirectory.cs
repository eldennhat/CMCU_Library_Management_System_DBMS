using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.InitFile
{
    public class InitDirectory
    {
        private static void CreateFolder()
        {
            try
            {
                if (!Directory.Exists(PathStrings.folderPath))
                    Directory.CreateDirectory(PathStrings.folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo folder: " + ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreateAccountFile()
        {
            CreateFolder();
            string filePath = Path.Combine(PathStrings.folderPath, PathStrings.accountFileName);

            try
            {
                if (!File.Exists(filePath))
                    File.Create(filePath).Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo file account: " + ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void autoPathCreator()
        {
            CreateFolder();
            CreateAccountFile();
        }
    }
}
