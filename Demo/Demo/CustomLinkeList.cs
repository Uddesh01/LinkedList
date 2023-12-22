using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class CustomLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CustomLinkedList()
        {
            size = 0;
        }
        public class Node
        {
            public int Value;
            public Node Next;

            public Node(int Value)
            {
                this.Value = Value;
            }
        }

        public void insertFirst(int Value)
        {
            Node node = new Node(Value);
            node.Next = head;
            head = node;

            if (tail == null)
            {
                tail = node;
            }
            size++;
        }

        public void insertLast(int Value)
        {
            if (size == 0)
            {
                insertFirst(Value);
                return;
            }
            Node node = new Node(Value);
            tail.Next = node;
            tail = node;
            size++;
        }
        public int RemoveFirst()
        {
            if (size == 0)
            {
                return -1;
            }
            int tempValue = head.Value;
            head = head.Next;
            size--;
            return tempValue;
        }
        public int RemoveLast()
        {
            Node node = head;
            while (node.Next != tail)
            {
                node = node.Next;
            }
            int temp = tail.Value;
            node.Next = null;
            tail = node;
            size--;
            return temp;
        }
        public void insertInBtw(int Value, int index)
        {
            if (size == 0)
            {
                insertFirst(Value);
                return;
            }
            if (index == size)
            {
                insertLast(Value);
                return;
            }
            Node node = head;
            Node newNode = new Node(Value);
            for (int i = 1; i < index; i++)
            {
                node = node.Next;
            }
            newNode.Next = node.Next;
            node.Next = newNode;
            size++;
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write("{0}" + "-> ", temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine("Null\n");
        }
    }
}
