using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTheory_LAB5
{
    public static class SelectionSortingDoublyNode
    {
        public static Node head = null;

        public static void AddNode(int data)
        {
            var node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                var temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public static void Display()
        {
            if (head == null)
            {
                Console.Write("\n Empty linked list\n");
                return;
            }
            var temp = head;
            while (temp != null)
            {
                Console.Write("{0} ", temp.data);
                temp = temp.next;
            }
        }

        public static void SwapData(Node a, Node b)
        {
            var temp = a.data;
            a.data = b.data;
            b.data = temp;
        }

        public static void Sort()
        {
            var auxiliary = head;
            Node temp = null;
            Node node = null;
            while (auxiliary != null)
            {
                node = auxiliary;
                temp = auxiliary.next;
                while (temp != null)
                {
                    if (node.data > temp.data)
                    {
                        node = temp;
                    }
                    temp = temp.next;
                }
                if (auxiliary.data > node.data)
                {
                    SwapData(auxiliary, node);
                }
                auxiliary = auxiliary.next;
            }
        }
    }
}
