using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.MainSettings
{
    public class clsUtil
    {
        static bool CreateImageFileIfNotExist(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                try
                {
                    Directory.CreateDirectory(filePath);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error : {e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        static string ReplaceImageNameWithGUID(FileInfo fileInfo)
        {
            return Guid.NewGuid().ToString() + fileInfo.Extension;
        }

        public static bool CopyImageToImagesFolder(ref string imagePath)
        {
            string newImagePath = "";
            string filePath = @"Images File\";

            if (CreateImageFileIfNotExist(filePath))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(imagePath);
                    newImagePath = $"{filePath}{ReplaceImageNameWithGUID(fileInfo)}";
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error : {e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    File.Copy(imagePath, newImagePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error : {e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                imagePath = newImagePath;
                return true;
            }
            
            return false;
        }
    }
}
