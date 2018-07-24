using System.Text;
using System.IO;

namespace AppBusLogic
{
    public interface IFileManager
    {
        bool IsExist(string path);
        string GetContent(string path, Encoding encoding);
        string GetContent(string path);
        void SaveContent(string path, string contents, Encoding encoding);
        void SaveContent(string path, string contents);
        int GetSymbolCount(string contents);
        int GetWordCount(string contents);
    }

    public class FileManager : IFileManager
    {
        // Default Windows encoding
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        // Check file existence
        public bool IsExist(string path)
        {
            return File.Exists(path);
        }

        // Getting content of the file
        public string GetContent(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }
        
        public string GetContent(string path)
        {
            return GetContent(path, _defaultEncoding);
        }

        // Save the contents to a file
        public void SaveContent(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }

        public void SaveContent(string path, string contents)
        {
            File.WriteAllText(path, contents, _defaultEncoding);
        }

        // Get the number of characters in the content
        public int GetSymbolCount(string contents)
        {
            return contents.Length;
        }

        public int GetWordCount(string contents)
        {
            return contents.Split(new[] { ' ', '\r' }).Length;
        }
    }
}