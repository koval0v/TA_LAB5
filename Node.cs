using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTheory_LAB5
{
    // Node of a doubly linked list
    public class Node
    {
        public int data;
        public Node prev, next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
