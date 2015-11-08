using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    public  class CustomQueue<T>: IEnumerable<T>
    {

        private T[] array;
        private int size;
        private const int defaultCapacity = 1;
        private int capacity;

        public CustomQueue()
        {
            capacity = defaultCapacity;
            this.array = new T[defaultCapacity];
            this.size = 0;
        }
        public int Count
        {
            get
            {
                return this.size;
            }
        }


        public void Enqueue(T newElement)
        {
            size++;
            if (this.size == this.capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(array, 0, newQueue, 1, array.Length);
                array = newQueue;
                capacity = 2 * capacity;
            }
            else
            {
                for (int i = size-1; i >= 0; i--)
                    array[i + 1] = array[i];
            } 
            array[0] = newElement;
        }

        public T Dequeue()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            size--;
            var temp = array[size];
            array[size] = default(T);
            return temp;
        }


        public T Peek()
        {
            if (Count > 0)
                return array[size-1];
            throw new InvalidOperationException("Queue is empty.");
        }

       
        
        
        public IEnumerator<T> GetEnumerator()
        {
            return new QueueIterator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class QueueIterator : IEnumerator<T>
        {
            private readonly CustomQueue<T> queue;
            private int position;

            public QueueIterator(CustomQueue<T> queue)
            {
                this.position = -1;
                this.queue = queue;
            }


            public T Current
            {
                get
                {
                    if (position > queue.Count-1)
                        throw new InvalidOperationException();
                    return queue.array[position];
                }
            }

            public bool MoveNext()
            {
                if (position < queue.Count-1)
                {
                    position++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                position = -1;
            }

            public void Dispose()
            {               
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    if (position > queue.Count)
                        throw new InvalidOperationException();
                    return queue.array[position];
                }
            }
        }

    }
}
