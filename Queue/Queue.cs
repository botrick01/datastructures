using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Queue
{
    public class Queue : ISubject
    {
        private LinkedList internalList = new LinkedList();
        private List<IObserver> observers = new List<IObserver>();

        public void Notify()
        {
            foreach(var observer in observers)
            {
                observer.Update(this);
            }
        }
        public Node Enqueue(object argValue)
        {
            internalList.InsertLast(argValue);
            Notify();
            return internalList.GetNode(argValue);
        }

        public Node Dequeue()
        {
            Node first = internalList.GetFirst();
            internalList.DeleteFirst();
            Notify();
            return first;
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Dettach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public override string ToString()
        {
            return internalList.ToString();
        }
    }
}
