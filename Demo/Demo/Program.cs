using Demo;
class program
{
    static void Main(string[] args)
    {
        CustomLinkedList<string> LinkedList = new CustomLinkedList<string>();
        LinkedList.insertFirst("Uddesh");
        LinkedList.insertFirst("Rohan");
        LinkedList.insertFirst("Saurabh");
        LinkedList.insertFirst("Omkar");
        LinkedList.insertFirst("Babu");

        Console.WriteLine("Linked List:");
        LinkedList.Print();

        LinkedList.insertLast("Tejas");
        LinkedList.insertLast("Sai");
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
        LinkedList.insertInBtw("Sai", Index);
        Console.WriteLine("After inserting element at position {0} ,modified linked list:", Index);
        LinkedList.Print();

        int removeat = 3;
        Console.WriteLine("Delete node from postion {0}", removeat);
        Console.WriteLine("Removed node value is {0}", LinkedList.removeAt(removeat));
        Console.WriteLine("After removing element from position {0} ,modified linked list:", removeat);
        LinkedList.Print();
    }
}