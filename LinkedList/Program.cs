using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
        linkedList.InsertLast(1);
        linkedList.InsertLast(2);
        linkedList.InsertLast(3);
        linkedList.InsertLast(4);
        linkedList.InsertLast(5);
        linkedList.InsertLast(6);
        linkedList.InsertAt(7, 0);
        linkedList.DeleteFirst();
        linkedList.PrintAllNodes();
        Console.WriteLine(linkedList.Count());
    }
}