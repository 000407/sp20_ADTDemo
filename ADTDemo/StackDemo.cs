using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    interface IStack {
        void Push(sbyte item);

        sbyte Pop();

        sbyte Peek();

        bool IsFull();

        bool IsEmpty();
    }

    class MyByteStack : IStack {
        private sbyte[] stackArray; // Storage of stack data in the memory
        private sbyte top; // Always points to the TOP OF THE STACK

        public MyByteStack(sbyte stackSize) {
            stackArray = new sbyte[stackSize];
            top = -1; // At the beginning, stack has NOTHING. That's why to pointer TOP is set to -1
        }

        public void Push(sbyte item) {
            if (IsFull()) {
                Console.WriteLine("Stack is already full!");
                return;
            }
            stackArray[++top] = item;
        }

        public sbyte Pop() {
            if (!IsEmpty())
            {
                return stackArray[top--];
            }
            Console.WriteLine("Stack is already empty!");
            return -1;
        }

        public sbyte Peek() {
            return stackArray[top];
        }

        public bool IsFull() {
            return top == stackArray.Length - 1;
        }

        public bool IsEmpty() {
            return top == -1;
        }
    }
    
}
