using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
        linkedList.InsertLast(0);
        linkedList.InsertLast(1);
        linkedList.InsertLast(2);
        linkedList.InsertLast(3);
        linkedList.InsertLast(4);
        linkedList.InsertLast(5);
        var node0 = linkedList.GetNode(0);
        var node5 = linkedList.GetNode(5);
        linkedList.SwitchNodes(node0, node5);
        linkedList.PrintAllNodes();
    }
}