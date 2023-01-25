using Microsoft.AspNetCore.Routing.Constraints;
using System.Security.Cryptography.X509Certificates;

namespace EmailApiLocobuzz.Models
{
    public class EmailAttachment
    {
        public EmailAttachment(string filePath)
        {
            
            if (File.Exists(filePath))
            {
                FilePath = filePath;
                FileName = Path.GetFileName(filePath);
                FileType = Path.GetExtension(filePath);
            } 
            else
            {
                throw new FileNotFoundException();  
            }
        }

        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
    }
}
