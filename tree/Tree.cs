namespace tree
{
    public class Tree
    {
        public Node root;
        public void Insert(int value)
        {
            if (root == null)
                root = new Node(value, null, null);
            else
            {
                Node previous = root;
                Node node = root;
                bool left = false;
                while (node != null)
                {
                    previous = node;
                    if (node.Value < value)
                    {
                        node = node.right;
                        left = false;
                    }
                    else if (node.Value > value)
                    {
                        node = node.left;
                        left = true;
                    }
                }
                if(left)
                    previous.left = new Node(value, null, null);
                else
                    previous.right = new Node(value, null, null);
            }
        }
        public void Print()
        {
            Print(this.root, 4);
        }
        public void Print(Node p, int padding)
        {
            if (p != null)
            {
                if (p.right != null)
                {
                    Print(p.right, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.right != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Value.ToString() + "\n ");
                if (p.left != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.left, padding + 4);
                }
            }
        }
    }
}