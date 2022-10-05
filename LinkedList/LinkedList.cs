using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;
        public void insertFirst(T value)
        {
            head = new Node<T>(value, head);
        }
        public void insertLast(T value)
        {
            Node<T> node = new Node<T>(value, null);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node<T> currentNode = head;
                while (currentNode.nextNode != null)
                {
                    currentNode = currentNode.nextNode;
                }
                currentNode.nextNode = node;
            }
            
        }
        
        public void insertAt(T value, int position)
        {
            Node<T> currentNode = head;
            for (int i = 0; i < position; i++)
            {
                currentNode = currentNode.nextNode;
            }
            Node<T> node = new Node<T>(value, currentNode.nextNode);
            currentNode = node;
        }
        public void Pop()
        {
            head = head.nextNode;
        }
        public int count()
        {
            Node<T> node = head;
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
            Node<T> current = head;
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
