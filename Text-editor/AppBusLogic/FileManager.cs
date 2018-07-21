using System.Text;
using System.IO;

namespace AppBusLogic
{
    public static class FileManager
    {
        // Default Windows encoding
        private static Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        // Check file existence
        public static bool IsExist(string path)
        {
            return File.Exists(path);
        }

        // Getting content of the file
        public static string GetContent(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }
        
        public static string GetContent(string path)
        {
            return GetContent(path, _defaultEncoding);
        }

        // Save the contents to a file
        public static void SaveContent(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }

        public static void SaveContent(string path, string contents)
        {
            File.WriteAllText(path, contents, _defaultEncoding);
        }

        // Get the number of characters in the content
        public static int GetSymbolCount(string contents)
        {
            return contents.Length;
        }
    }
}