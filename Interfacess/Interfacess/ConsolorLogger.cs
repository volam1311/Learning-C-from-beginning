using System.IO;
namespace Interfacess
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }
        public void LogInfo(string message)
        {
            Log(message, "ERROR");
        }
        private void Log(string message, string messageType)
        {
            using (var st = new StreamWriter(_path,true))
            {
                st.WriteLine(messageType,messageType);
            }
        }
    }

    public class ConsolorLogger : ILogger
    {
        public void LogInfo(string message) {
            Console.WriteLine(message);
        }
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
