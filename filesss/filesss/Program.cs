using System.IO;
namespace filesss
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"C:\temp\myfile.jpg",@"D:\temp\myfile.jpg",true);
            File.Delete(path);
            var content  = File.ReadAllText(path);
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(content);
        }
    }
}
