using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace ProniaWepCoreApp.utilize
{
    public static class FileManage
    {
        public static string SaveImg(this IFormFile file , string root , string path ,string fileName) 
        {
            string rootPath = Path.Combine(root, path);
            string fullPath = Path.Combine(rootPath, fileName);
            using (FileStream fs = new FileStream (fullPath ,FileMode.Create))
            {
                file.CopyTo(fs);
            }
           
            return fileName;
        }
        public static void DeleteFile(string path)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

        }
        public static void DeleteFileFromFolder(string root , string path , string fileName)
        {

            string rootPath = Path.Combine (root, path);
            string fullPath = Path.Combine(rootPath, path);
            string strFileFullPath = rootPath + fullPath;

            if (System.IO.File.Exists(strFileFullPath))
            {
                System.IO.File.Delete(strFileFullPath);
            }


        }
    }
}
