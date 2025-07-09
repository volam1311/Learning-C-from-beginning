namespace Abstraction
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }
}