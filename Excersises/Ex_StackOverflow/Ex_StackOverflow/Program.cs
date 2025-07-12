using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
namespace StackOverflow
{
    public class StackOverflowPost
    {
        private string _title { get; set; } 
        private string _description { get; set; }  
        private DateTime _createdTime{ get; set; }

        private int _countVote = 0;

        public StackOverflowPost(string title, string description) 
        {
            _title = title;
            _description = description;
            _createdTime = DateTime.Now;
        }
        public void DownVote()
        {
            _countVote--;
        }
        public void UpVote()
        {
            _countVote++;
        }
        public void ShowVote()
        {
            Console.WriteLine(_countVote);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new StackOverflowPost("abcd","xyz");
            post1.DownVote();
            post1.UpVote();
            post1.UpVote();
            post1.ShowVote();
        }
    }
}
