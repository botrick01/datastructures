using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;
        public void insertFirst(object value)
        {
            head = new Node(value, head);
        }
        public void insertLast(object value)
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
        
        public void insertAt(object value, int position)
        {
            if (position == 0)
            {
                insertFirst(value);
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
        public void deleteFirst()
        {
            head = head.nextNode;
        }
        public int count()
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
        public void printAllNodes()
        {
            Node current = head;
            String printString = "";
            while (current != null)
            {
                printString += current.Value + "\n";
                current = current.nextNode;
            }
            Console.WriteLine(printString);
        }
    }
}
