using System;

namespace AlgoTheory_LAB5
{
    public static class InsertionSortingDoublyNode
    {
        public static Node GetNode(int data)
        {
            Node newNode = new Node(data);

            newNode.prev = newNode.next = null;
            return newNode;
        }

        public static Node SortedInsert(Node head_ref, Node newNode)
        {
            Node current;

            if (head_ref == null)
                head_ref = newNode;

            else if ((head_ref).data >= newNode.data)
            {
                newNode.next = head_ref;
                newNode.next.prev = newNode;
                head_ref = newNode;
            }

            else
            {
                current = head_ref;

                while (current.next != null &&
                       current.next.data < newNode.data)
                    current = current.next;

                newNode.next = current.next;

                if (current.next != null)
                    newNode.next.prev = newNode;

                current.next = newNode;
                newNode.prev = current;
            }
            return head_ref;
        }


        public static Node Sort(Node head_ref)
        {
            Node sorted = null;

            Node current = head_ref;
            while (current != null)
            {
                Node next = current.next;

                current.prev = current.next = null;

                sorted = SortedInsert(sorted, current);

                current = next;
            }

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

        public static Node Push(Node head_ref, int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = (head_ref);
            new_node.prev = null;

            if ((head_ref) != null)
                (head_ref).prev = new_node;

            (head_ref) = new_node;

            return head_ref;
        }
    }
}
