using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleSingly
{
    public class LinkedQueue<E> : Queue<E>
    {
        private SList<E> list;

        public LinkedQueue()
        {
            list = new SList<E>();
        }
        public E Dequeue()
        {
            return list.RemoveFirst();
        }

        public void Enqueue(E element)
        {
            list.AddLast(element);
        }

        public E First()
        {
            return list.First();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public int Size()
        {
            return list.Size();
        }
    }
}
