using System;

namespace ADTDemo
{
    class GenericsDemo
    {
        public static void DemoMain(string[] args) {
            MyList<int> myIntList = new MyList<int>();

            for (int i = 0; i < 10; i++) {
                myIntList.Add(i + 10);
            }

            myIntList.DisplayList();

            MyList<char> myCharList = new MyList<char>();

            for (int i = 0; i < 10; i++)
            {
                myCharList.Add((char) (i + 65));
            }

            myCharList.DisplayList();
        }
    }

    class MyList<T> { // Within the diamond operator, you have a TYPE PARAMETER
        private T[] listContent;
        private int nextIdx;

        public MyList() {
            listContent = new T[10];
        }

        public void DisplayList() {
            foreach (T v in listContent) {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }

        public void Add(T item) {
            if (nextIdx == listContent.Length) {
                throw new Exception("The list is full!");
            }

            listContent[nextIdx++] = item;
        }
    }
}
