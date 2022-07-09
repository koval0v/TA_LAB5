using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgoTheory_LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> data = new List<int>();
            List<int> dataSize = new List<int>() { 10, 100, 500, 1000, 2000, 5000, 10000 };

            foreach (int i in dataSize)
            {
                Console.WriteLine($"\n=*=*=*= DATA SIZE: {i} =*=*=*=");
                for (int j = i; j > 0; j--)
                {
                    data.Add(rnd.Next(-i, i));
                }

                Console.WriteLine("==== Selection Sorting <DoublyNode/LinkedList> ===");

                Stopwatch swSelectionLL = new Stopwatch();

                foreach (int k in data)
                {
                    SelectionSortingDoublyNode.AddNode(k);
                }
                //Console.WriteLine("Before sort:");
                //SelectionSortingDoublyNode.Display();

                swSelectionLL.Start();
                SelectionSortingDoublyNode.Sort();
                swSelectionLL.Stop();

                //Console.WriteLine("\nAfter sort:");
                //SelectionSortingDoublyNode.Display();

                Console.WriteLine("\nTime elapsed: {0}", swSelectionLL.Elapsed);

                Console.WriteLine("\n==== Insertion Sorting <Array> ===");

                Stopwatch swInsertionA = new Stopwatch();

                int[] arr = data.ToArray();

                //Console.WriteLine("Before sort:");
                //InsertionSortingArray.Display(arr, arr.Length);

                swInsertionA.Start();
                InsertionSortingArray.Sort(arr, arr.Length);
                swInsertionA.Stop();

                //Console.WriteLine("After sort:");
                //InsertionSortingArray.Display(arr, arr.Length);

                Console.WriteLine("\nTime elapsed: {0}", swInsertionA.Elapsed);

                Console.WriteLine("\n==== Insertion Sorting <DoublyNode/LinkedList> ===");

                Stopwatch swInsertionLL = new Stopwatch();

                Node head = null;

                for (int k = data.Count - 1; k >= 0; k--)
                {
                    head = InsertionSortingDoublyNode.Push(head, data[k]);
                }

                //Console.WriteLine("Before sort:");
                //InsertionSortingDoublyNode.Display(head);

                swInsertionLL.Start();
                head = InsertionSortingDoublyNode.Sort(head);
                swInsertionLL.Start();

                //Console.WriteLine("\nAfter sort:");
                //InsertionSortingDoublyNode.Display(head);

                Console.WriteLine("\nTime elapsed: {0}", swInsertionLL.Elapsed);

                data.Clear();
            }
        }
    }
}
