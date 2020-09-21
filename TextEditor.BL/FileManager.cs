using System.IO;
using System.Text;

namespace TextEditor.BL
{
    public class FileManager
    { 
        public string GetContent(string filePath,Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
    }
}
