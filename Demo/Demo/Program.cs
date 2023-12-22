using Demo;
class program
{
    static void Main(string[] args)
    {
        CustomLinkedList LinkedList = new CustomLinkedList();
        LinkedList.insertFirst(5);
        LinkedList.insertFirst(4);
        LinkedList.insertFirst(3);
        LinkedList.insertFirst(2);
        LinkedList.insertFirst(1);

        Console.WriteLine("Linked List:");
        LinkedList.Print();

        LinkedList.insertLast(100);
        LinkedList.insertLast(200);
        Console.WriteLine("After inserting the element at the last:");
        LinkedList.Print();

        Console.WriteLine("Removed first node value is {0}", LinkedList.RemoveFirst());
        Console.WriteLine("After removing the first element modified linked list:");
        LinkedList.Print();

        Console.WriteLine("Removed last node value is {0}", LinkedList.RemoveLast());
        Console.WriteLine("After removing the last element modified linked list:");
        LinkedList.Print();

        int Index = 3;
        Console.WriteLine("Insert node at postion {0}", Index);
        LinkedList.insertInBtw(50, Index);
        Console.WriteLine("After inserting element at position {0} ,modified linked list:", Index);
        LinkedList.Print();
    }
}