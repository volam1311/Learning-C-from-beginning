using System;

namespace Ex_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();
        public void Push (object obj)
        {
            _stack.Add(obj);
        }
        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("There is no element inside the stack");
            }
            else
            {
                var top = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1);
                return top;
            }
        }
    }
}
