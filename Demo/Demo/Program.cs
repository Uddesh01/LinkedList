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
    }
}