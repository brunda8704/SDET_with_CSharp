using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonGenericCollection
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            arrayList.Add("aaa");
            arrayList.Add("True");
            arrayList.Add("False");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            Console.WriteLine("\nAfter reverse:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains(10));
            Console.WriteLine(arrayList.IndexOf(20));
        }

        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push("AAA");
            stack.Push(23.5);
            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }
           
            Console.WriteLine("\nAfter pop:");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }
            
            Console.WriteLine("\nAfter peek:");
            Console.WriteLine(stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }
        }

        public void QueueHandling()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(34.7);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAfter dequeue:");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\nAfter peek:");
            Console.WriteLine(queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);

            }
        }

        public void HashTableHandling()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("Name", "John");
            hashTable.Add("RollNumber", 12);
            hashTable.Add("Place", "Kochi");
            foreach (var item in hashTable.Keys)
            {
                Console.WriteLine(item);

            }
            foreach (var item in hashTable.Values)
            {
                Console.WriteLine(item);

            }
            hashTable.Remove("Place");
            foreach (var item in hashTable)
            {
                Console.WriteLine(item);

            }
        }

        public void SortedListHandling()
        {
            //keys will be in sorted order
            SortedList sortedList = new SortedList();
            sortedList.Add(3, 30);
            sortedList.Add(4, "BBB");
            sortedList.Add(1,10);
            sortedList.Add(2,20);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
