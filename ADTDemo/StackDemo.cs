using System;

namespace ADTDemo
{
    class StackDemo {
        public static void DemoMain(string[] args) {
            MyByteStack stack = new MyByteStack(3);

            stack.Push(13);
            stack.Push(-9);
            stack.Push(23);
            stack.Push(-56); // Will display error message

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(17);
            stack.Push(21);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        public static void GenericStackDemoMain(string[] args) {
            MyStack<string> myStringStack = new MyStack<string>(5); // Instance of MyStack that lets you put string values

            myStringStack.Push("10.01D");
            myStringStack.Push("20.015");

            MyStack<double> myDoubleStack = new MyStack<double>(10); // Instance of MyStack that lets you put double values

            myDoubleStack.Push(10.01D);
            myDoubleStack.Push(20.015);
            
            MyStack<CompactDisc> myCDBulk = new MyStack<CompactDisc>(50); // Instance of MyStack that lets you put CDs in that
        }

        public static void GenericLinkedStackDemoMain(string[] args)
        {
            MyLLStack<double> myDoubleStack = new MyLLStack<double>(); // Instance of MyLLStack that lets you put double values

            myDoubleStack.Push(10.01D);
            myDoubleStack.Push(20.015);

            //myDoubleStack.PrintStack();

            Console.WriteLine("POP: " + myDoubleStack.Pop());
            Console.WriteLine("POP: " + myDoubleStack.Pop());
            Console.WriteLine("POP: " + myDoubleStack.Pop());

            myDoubleStack.PrintStack();
        }
    }

    interface IStack {
        void Push(sbyte item);

        sbyte Pop();

        sbyte Peek();

        bool IsFull();

        bool IsEmpty();
    }

    interface IGenericStack<T> {
        void Push(T item);

        T Pop();

        T Peek();

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

    class MyStack<T> : IGenericStack<T> {
        private T[] stackArray; // Storage of stack data in the memory
        private sbyte top; // Always points to the TOP OF THE STACK

        public MyStack(sbyte stackSize)
        {
            stackArray = new T[stackSize];
            top = -1; // At the beginning, stack has NOTHING. That's why to pointer TOP is set to -1
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is already full!");
                return;
            }
            stackArray[++top] = item;
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                return stackArray[top--];
            }
            Console.WriteLine("Stack is already empty!");
            return default;
        }

        public T Peek()
        {
            return stackArray[top];
        }

        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

    class MyLLStack<T> : IGenericStack<T>
    {
        private LinkedList<T> stackLinkedList; // Storage of stack data in the memory

        public MyLLStack() {
            stackLinkedList = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return stackLinkedList.Head == null;
        }

        public bool IsFull()
        {
            return false; //TODO: Not an ideal solution, you will figure this out laaaaaater
        }

        public T Peek()
        {
            return stackLinkedList.Tail.Value;
        }

        public T Pop()
        {
            return stackLinkedList.Remove();
        }

        public void Push(T item)
        {
            stackLinkedList.Add(item);
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("EMPTY");
            }
            else
            {
                while (!IsEmpty())
                {
                    Console.WriteLine("|" + Pop() + "|");
                }
            }
            
        }
    }
}
