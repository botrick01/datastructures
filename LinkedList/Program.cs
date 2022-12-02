using Common;
using Common;
class Program
{
    static void Main(string[] args)
    {
        Common.LinkedList linkedList = new Common.LinkedList();
        linkedList.InsertLast(5);
        linkedList.InsertLast(9);
        linkedList.InsertLast(4);
        linkedList.InsertLast(3);
        linkedList.InsertLast(7);
        linkedList.InsertLast(2);
        linkedList.SetSortStrategy(new BubbleSortReverse());
        Console.WriteLine(linkedList.ToString());
        linkedList.Sort();
        Console.WriteLine(linkedList.ToString());
    }
}