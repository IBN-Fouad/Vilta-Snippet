using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilta_Logic.Vilta_Functions
{
    public class clsUtil
    {
        public enum enSection { eAll = 0, eFavorites = 1, eTrash = 2, eProfile = 4 };
        public static enSection Section;

        private static bool _CreateFolderIfDoesNotExist(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            return true;
        }

        private static string _GenerateGuid()
        {
            return Guid.NewGuid().ToString();
        }

        private static string _ReplaceFileName(string SourcePath)
        {
            string Path = SourcePath;
            FileInfo info = new FileInfo(Path);
            string Ext = info.Extension;

            return _GenerateGuid() + Ext;
        }

        public static bool CopyImageToProjectImagesFolder(ref string SoursePath)
        {
            string NewPath = @"D:\Users_Profile_Images_Vilta_Snippet\";
            if (!_CreateFolderIfDoesNotExist(NewPath))
                return false;

            string DestinationFile = NewPath + _ReplaceFileName(SoursePath);

            try
            {
                File.Copy(SoursePath, DestinationFile, true);
            }
            catch (Exception e)
            {
                return false;
            }

            SoursePath = DestinationFile;
            return true;
        }
    }
}
