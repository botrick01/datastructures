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
        linkedList.DeleteNode(2);
        linkedList.InsertAfter(2, 1);
        linkedList.printAllNodes();
        Console.WriteLine(linkedList.GetNode(4).Value);
    }
}