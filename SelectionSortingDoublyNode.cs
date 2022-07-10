using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTheory_LAB5
{
    public static class SelectionSortingDoublyNode
    {
        public static Node head = null;
        // Add new Node at end of linked list
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
                // Find the last node
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                // Append the node at last position
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

        // Swap the given node value
        public static void SwapData(Node a, Node b)
        {
            var temp = a.data;
            a.data = b.data;
            b.data = temp;
        }

        // Sort using selection sort
        public static void Sort()
        {
            var auxiliary = head;
            Node temp = null;
            Node node = null;
            // Execute linked list node
            while (auxiliary != null)
            {
                node = auxiliary;
                temp = auxiliary.next;
                // Find the minimum node
                while (temp != null)
                {
                    if (node.data > temp.data)
                    {
                        node = temp;
                    }
                    // Visit to next node
                    temp = temp.next;
                }
                if (auxiliary.data > node.data)
                {
                    // Transfer minimum value to initial position
                    // Swap the node value
                    SwapData(auxiliary, node);
                }
                // Visit to next node
                auxiliary = auxiliary.next;
            }
        }
    }
}
