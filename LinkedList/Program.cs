using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
        linkedList.InsertFirst(1);
        linkedList.InsertLast(2);
        linkedList.InsertLast(3);
        linkedList.InsertLast(4);
        linkedList.DeleteNode(0);
        linkedList.PrintAllNodes();
        Console.WriteLine(linkedList.GetNode(4).Value);
        Console.WriteLine(linkedList.Count());
    }
}