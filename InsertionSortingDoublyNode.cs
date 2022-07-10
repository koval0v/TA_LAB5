using System;

namespace AlgoTheory_LAB5
{
    public static class InsertionSortingDoublyNode
    {
        // function to create and return a new node
        // of a doubly linked list
        public static Node GetNode(int data)
        {
            // allocate node
            Node newNode = new Node(data);
            // put in the data
            newNode.prev = newNode.next = null;
            return newNode;
        }

        // function to insert a new node in sorted way
        // in a sorted doubly linked list
        public static Node SortedInsert(Node head_ref, Node newNode)
        {
            Node current;
            // if list is empty
            if (head_ref == null)
                head_ref = newNode;
            // if the node is to be inserted at the beginning
            // of the doubly linked list
            else if ((head_ref).data >= newNode.data)
            {
                newNode.next = head_ref;
                newNode.next.prev = newNode;
                head_ref = newNode;
            }

            else
            {
                current = head_ref;
                // locate the node after which
                // the new node is to be inserted
                while (current.next != null &&
                       current.next.data < newNode.data)
                    current = current.next;
                //Make the appropriate links
                newNode.next = current.next;
                // if the new node is not inserted
                // at the end of the list
                if (current.next != null)
                    newNode.next.prev = newNode;

                current.next = newNode;
                newNode.prev = current;
            }
            return head_ref;
        }

        // function to sort a doubly linked list
        // using insertion sort
        public static Node Sort(Node head_ref)
        { // Initialize 'sorted' - a sorted doubly linked list
            Node sorted = null;
            // Traverse the given doubly linked list and
            // insert every node to 'sorted'
            Node current = head_ref;
            while (current != null)
            { 
                // Store next for next iteration
                Node next = current.next;
                // removing all the links so as to create
                // 'current' as a new node for insertion
                current.prev = current.next = null;
                // insert current in 'sorted' doubly linked list
                sorted = SortedInsert(sorted, current);
                // Update current
                current = next;
            }
            // Update head_ref to point to
            // sorted doubly linked list
            head_ref = sorted;

            return head_ref;
        }

        public static void Display(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }

        // function to insert a node at the beginning of
        // the doubly linked list
        public static Node Push(Node head_ref, int new_data)
        {
            // allocate node and put in the data
            Node new_node = new Node(new_data);

            // Make next of new node as head
            // and previous as null
            new_node.next = (head_ref);
            new_node.prev = null;
            // change prev of head node to new node
            if ((head_ref) != null)
                (head_ref).prev = new_node;
            // move the head to point to the new node
            (head_ref) = new_node;

            return head_ref;
        }
    }
}
