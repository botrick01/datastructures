using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
        linkedList.InsertLast(5);
        linkedList.InsertLast(9);
        linkedList.InsertLast(4);
        linkedList.InsertLast(3);
        linkedList.InsertLast(7);
        linkedList.InsertLast(2);
        Console.WriteLine(linkedList.ToString());
        linkedList.InsertionSortReverse();
        Console.WriteLine(linkedList.ToString());
    }
}