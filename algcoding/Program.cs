using System;
using System.Collections;
using algcoding.chap1;

namespace algcoding
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new StackGetMin();
            stack.push(5);
            stack.push(3);
            stack.push(3);
            Console.WriteLine(stack.GetMin());
            stack.push(1);
            stack.GetMin();
            stack.pop();

        }
    }
}
