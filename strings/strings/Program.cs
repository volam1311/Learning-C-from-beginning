using System.Text;
namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Phuc Lam Vo     ";
            // Trim
            Console.WriteLine(fullName.Trim());
            // Upper
            Console.WriteLine(fullName.ToUpper());
            // Lower
            Console.WriteLine(fullName.ToLower());
            // Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            Console.WriteLine(firstName);
            // Spilt (which will return an array of string)
            var names = fullName.Split(' ');
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            // Replace
            Console.WriteLine(fullName.Replace(' ', '\0'));

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }
            var new_int = "1234";
            Console.WriteLine(int.Parse(new_int));
            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // Convert into the currency one
            // With StringBuilder we can manipulate the string with Append, Replace, Remove, Insert. But we can not search for a certain element inside the StringBuilder.
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.Append('-', 10);
            Console.WriteLine(builder);
        }
    }
}