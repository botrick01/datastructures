using Stack;

class Program
{
    static void Main(string[] args)
    {
        CustomStack<int> stack = new CustomStack<int>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.pop();
        Console.WriteLine(stack.size());
    }
}