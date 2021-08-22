using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    namespace DoublyLinkedList
    {
        class DoublyLinkedListDemo
        {
            public static void DoublyLinkedListDemoMain(string[] args)
            {
                try
                {
                    var myIntDll = new DoublyLinkedList<int>();

                    myIntDll.Add(73);
                    myIntDll.Add(54);
                    myIntDll.Add(29);

                    myIntDll.PrintList();

                    myIntDll.Remove();
                    myIntDll.Remove();

                    myIntDll.PrintList();

                    myIntDll.Remove();
                    myIntDll.Remove();
                    myIntDll.PrintList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        class DoublyLinkedList<T>
        {
            public int Size
            {
                get; private set;
            }

            public DoublyLinkedListItem<T> Head
            {
                get; private set;
            }

            public DoublyLinkedListItem<T> Tail
            {
                get; private set;
            }

            public void Add(T item)
            {
                var itemObj = new DoublyLinkedListItem<T>(item);

                if (IsEmpty())
                {
                    Head = itemObj;
                    Tail = itemObj;
                }
                else
                {
                    Tail.Next = itemObj;
                    itemObj.Prev = Tail;

                    Tail = itemObj;
                }

                Size++;
            }

            public T Remove()
            {
                if (IsEmpty())
                {
                    throw new Exception("List is already empty!");
                }

                T value = Tail.Value;

                if (Size == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail = Tail.Prev;
                    Tail.Next = null;
                }

                Size--;

                return value;
            }

            public bool IsEmpty()
            {
                return Head == null;
            }

            public void PrintList()
            {
                var tmp = Head;

                if (tmp == null)
                {
                    Console.WriteLine("List is empty!");
                    return;
                }

                while (tmp != null)
                {
                    Console.Write(tmp.Value + "~>");
                    tmp = tmp.Next;
                }
                Console.WriteLine();
            }
        }

        class DoublyLinkedListItem<T>
        {
            public T Value {
                get; set;
            }

            public DoublyLinkedListItem<T> Prev
            {
                get; set;
            }

            public DoublyLinkedListItem<T> Next
            {
                get; set;
            }

            public DoublyLinkedListItem(T value)
            {
                Value = value;
            }
        }
    }
}
