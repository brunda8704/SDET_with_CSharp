using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenericCollection
    {
        public void ListHandling()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            list.Reverse();
            Console.WriteLine("\nAfter reverse:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nContains 10:"+list.Contains(10));
            Console.WriteLine("Index of 20:"+list.IndexOf(20));
        }


        public void StackHandling()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("C");
            stack.Push("A");
            stack.Push("B");
            stack.Push("D");
            stack.Push("E");
            foreach (string item in stack)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\nAfter pop:");
            stack.Pop();
            foreach (string item in stack)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\nAfter peek:");
            Console.WriteLine(stack.Peek());
            foreach (string item in stack)
            {
                Console.WriteLine(item);

            }
        }

        public void QueueHandling()
        {
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(34.7);
            foreach (double item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAfter dequeue:");
            queue.Dequeue();
            foreach (double item in queue)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\nAfter peek:");
            Console.WriteLine(queue.Peek());
            foreach (double item in queue)
            {
                Console.WriteLine(item);

            }
        }

        public void SortedListHandling()
        {
            //keys will be in sorted order
            SortedList<int,int> sortedList = new SortedList<int,int>();
            sortedList.Add(3, 30);
            sortedList.Add(4, 40);
            sortedList.Add(1, 10);
            sortedList.Add(2, 20);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

        }

        public void DictionaryHandling()
        {
            Dictionary<string,string> dictionary= new Dictionary<string,string>();
            dictionary.Add("Name", "John");
            dictionary.Add("Domain", "IT");
            dictionary.Add("Place", "Kochi");
            foreach (string item in dictionary.Keys)
            {
                Console.WriteLine(item);

            }
            foreach (string item in dictionary.Values)
            {
                Console.WriteLine(item);

            }
            dictionary.Remove("Place");
            foreach (string item in dictionary.Keys)
            {
                Console.WriteLine(item);

            }
        }
    }
}
