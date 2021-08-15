using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    class LinkedListDemo
    {
        public static void LinkedListDemoMain(string[] args) {
            LinkedList<int> myIntList = new LinkedList<int>();
            myIntList.Add(35); //myIntList.Head = new ListItem<int>(35);
            myIntList.Add(75); //myIntList.Head.Next = new ListItem<int>(75);
            myIntList.Add(50); //myIntList.Head.Next.Next = new ListItem<int>(50);
            myIntList.Add(20); //myIntList.Head.Next.Next.Next = new ListItem<int>(20);

            myIntList.Print();
        }
    }

    class ListItem<T> {
        public T Value {
            get; set;
        }

        public ListItem<T> Next {
            get; set;
        }

        public ListItem(T value) {
            this.Value = value;
        }
    }

    interface ILinkedList<T> { // Contract for the linked list
        void Add(T item);

        void Print();
    }

    class LinkedList<T> :ILinkedList<T> {
        public int Size {
            get; private set;
        }

        public ListItem<T> Head {
            get; set;
        }

        public ListItem<T> Tail
        {
            get; set;
        }

        public void Add(T item) {
            if (Head == null)
            { //Head is null means the list is empty
                Head = new ListItem<T>(item);
                Tail = Head;
            }
            else { //The list isn't empty. Add new item after the tail
                Tail.Next = new ListItem<T>(item);
                Tail = Tail.Next;
            }
        }

        public void Print() {
            ListItem<T> tmp = Head;

            while (tmp != null) {
                Console.Write(tmp.Value.ToString() + "~>");
                tmp = tmp.Next;
            }
         }
    }
}
