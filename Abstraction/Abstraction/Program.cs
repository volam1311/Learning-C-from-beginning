namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
            circle.Copy();
            //var shape = new Shape(); We cannot do this as the shape class is abstract 
        }
    }
}