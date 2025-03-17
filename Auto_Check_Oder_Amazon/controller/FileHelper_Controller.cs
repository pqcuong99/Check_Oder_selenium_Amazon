using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller
{
    public class FileHelper_Controller
    {
        public static void WirteFileAppendTxt(string path, string content)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(content);
            }
        }
        public static void WriteFileTxt(string path,string content)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }

            // Ghi nội dung vào file
            File.WriteAllText(path, content);
        }
        public static string ReadFileTxt(string path) {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                return  content;
            }
            return null;
        }
    }
}
