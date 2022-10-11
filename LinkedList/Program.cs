using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
        linkedList.insertLast(1);
        linkedList.insertLast(2);
        linkedList.insertLast(3);
        linkedList.insertLast(4);
        linkedList.insertLast(5);
        linkedList.insertLast(6);
        linkedList.insertAt(7, 0);
        linkedList.deleteFirst();
        linkedList.printAllNodes();
        Console.WriteLine(linkedList.count());
    }
}