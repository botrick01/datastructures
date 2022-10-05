using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList.LinkedList<int> linkedList = new LinkedList.LinkedList<int>();
        linkedList.insertLast(1);
        linkedList.insertLast(2);
        linkedList.insertLast(3);
        linkedList.insertLast(4);
        linkedList.insertLast(6);
        linkedList.insertLast(7);
        linkedList.insertAt(5, 0);
        linkedList.printAllNodes();
    }
}