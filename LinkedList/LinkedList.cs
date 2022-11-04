using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head { get; private set; }
        public void InsertFirst(object value)
        {
            head = new Node(value, head);
        }
        public void InsertLast(object value)
        {
            Node node = new Node(value, null);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.nextNode != null)
                {
                    currentNode = currentNode.nextNode;
                }
                currentNode.nextNode = node;
            }
            
        }

        public void InsertAfter(object argNewNode, object argPreviousNode)
        {
            Node PreviousNode = GetNode(argPreviousNode);
            Node NewNode = new Node(argNewNode, PreviousNode?.nextNode);
            PreviousNode.nextNode = NewNode;
        }
        
        public void InsertAt(object value, int position)
        {
            if (position == 0)
            {
                InsertFirst(value);
                return;
            }
            int count = 0;
            Node currentNode = head;
            while (count < position - 1)
            {
                
                if (currentNode.nextNode == null)
                {
                    Console.WriteLine(count + " doesn't exist");
                    return;
                }
                currentNode = currentNode.nextNode;
                count++;
            }

            Node node = new Node(value, currentNode?.nextNode);
            currentNode.nextNode = node;
        }
        public Node GetNode(object value)
        {
            Node currentNode = head;
            while (!currentNode.Value.Equals(value))
            {
                if (currentNode.nextNode == null)
                {
                    return null;
                }
                currentNode = currentNode.nextNode;
            }
            return currentNode;
        }
        public void DeleteFirst()
        {
            head = head.nextNode;
        }
        public bool DeleteNode(object argValue)
        {
            Node currentNode = head;
            Node previousNode = head;
            while (!currentNode.Value.Equals(argValue))
            {
                if (currentNode.nextNode == null)
                {
                    return false;
                }
                previousNode = currentNode;
                currentNode = currentNode.nextNode;
            }
            previousNode.nextNode = currentNode.nextNode ?? null;
            return true;
        }
        public int Count()
        {
            Node node = head;
            int i = 0;
            while (node != null)
            {
                i++;
                node = node.nextNode;
            }

            return i;
        }
        public void PrintAllNodes()
        {
            Node current = head;
            string printString = "";
            while (current != null)
            {
                printString += current.Value + "\n";
                current = current.nextNode;
            }
            Console.WriteLine(printString);
        }
        public string stringifyAllNodes()
        {
            Node current = head;
            string output = "";
            while (current != null)
            {
                output += current.Value + " ";
                current = current.nextNode;
            }
            return output;
        }
        public Node GetPreviousNode(object argData)
        {
            Node currentNode = head;
            Node previousNode = head;
            while(!currentNode.Value.Equals(argData))
            {
                if(currentNode.nextNode == null)
                {
                    return null;
                }
                previousNode = currentNode;
                currentNode = currentNode.nextNode;
            }
            return previousNode;
        }
        public void SwitchNodes(Node argFirstNode, Node argSecondNode)
        {
            Node previousFirstNode = GetPreviousNode(argFirstNode.Value) ?? null;
            Node previousSecondNode = GetPreviousNode(argSecondNode.Value) ?? null;
            if (previousFirstNode != null && previousSecondNode != null)
            {
                if (argFirstNode == head)
                {
                    Node firstNode = new Node(argFirstNode.Value, head.nextNode);
                    Node secondNode = new Node(argSecondNode.Value, previousFirstNode.nextNode);
                    head = secondNode;
                    previousSecondNode.nextNode = firstNode;
                }
                else if (argSecondNode == head)
                {
                    Node firstNode = new Node(argFirstNode.Value, previousSecondNode.nextNode);
                    Node secondNode = new Node(argSecondNode.Value, head.nextNode);
                    previousFirstNode.nextNode = secondNode;
                    head = firstNode;
                }
                else
                {
                    Node firstNode = new Node(argFirstNode.Value, previousSecondNode.nextNode.nextNode);
                    Node secondNode = new Node(argSecondNode.Value, previousFirstNode.nextNode.nextNode);
                    previousFirstNode.nextNode = secondNode;
                    previousSecondNode.nextNode = firstNode;
                }
            }
        }
        public void SwitchNodeCheaterVersion(Node argFirstNode, Node argSecondNode)
        {
            (argFirstNode.Value, argSecondNode.Value) = (argSecondNode.Value, argFirstNode.Value);
        }
    }
}
