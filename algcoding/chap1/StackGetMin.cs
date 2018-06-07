using System;
using System.Collections;

namespace algcoding.chap1
{
    public class StackGetMin
    {
        private Stack stackData;
        private Stack stackMin;

        public StackGetMin()
        {
            stackData = new Stack();
            stackMin = new Stack();
        }

        public void push(int newNum)
        {
            stackData.Push(newNum);
            if (stackMin.Count==0)
            {
                stackMin.Push(newNum);
            }
            else if (newNum <= this.GetMin())
            {
                stackMin.Push(newNum);
            }
        }

        public int pop()
        {
            if(stackData.Count == 0)
            {
                throw new InvalidOperationException("Your stack has no number!");
            }
            int num = Convert.ToInt32(stackData.Pop());
            if(num == this.GetMin())
            {
                stackMin.Pop();
            }
            return num;
        }

        public int GetMin()
        {
            if (stackMin.Count == 0)
            {
                throw new InvalidOperationException("Your stack has no number!");
            }
            return Convert.ToInt32(this.stackMin.Peek());
        }
    }
}
