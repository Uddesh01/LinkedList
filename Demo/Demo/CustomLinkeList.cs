using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class CustomLinkedList<T>
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
            public T Value;
            public Node Next;

            public Node(T Value)
            {
                this.Value = Value;
            }
        }

        public void insertFirst(T Value)
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

        public void insertLast(T Value)
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
        public T RemoveFirst()
        {
            if (size == 0)
            {
                return default(T);
            }
            T tempValue = head.Value;
            head = head.Next;
            size--;
            return tempValue;
        }
        public T RemoveLast()
        {
            Node node = head;
            while (node.Next != tail)
            {
                node = node.Next;
            }
            T temp = tail.Value;
            node.Next = null;
            tail = node;
            size--;
            return temp;
        }
        public void insertInBtw(T Value, int index)
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

        public T removeAt(int index)
        {
            if (size == 0)
            {
                Console.WriteLine("Nothing to delete");
                return default(T);
            }
            if (index == size)
            {
                RemoveLast();
            }
            if (index == 0)
            {
                return RemoveFirst();
            }

            Node node = head;
            for (int i = 1; i < index; i++)
            {
                node = node.Next;
            }
            Node temp = node.Next;
            T removedValue = temp.Value;
            node.Next = temp.Next;
            return removedValue;
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
