using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    public  class CustomQueue<T>: IEnumerable<T>
    {

        private T[] _array;
        private int size;
        private const int defaultCapacity = 10;
        private int capacity;//количество элементов под которые выделено памяти
        private int head;
        private int tail;//переменная которая указывает на задний элемент.

        public CustomQueue()
        {
            capacity = defaultCapacity;
            this._array = new T[defaultCapacity];
            this.size = 0;
            this.head = -1;
            this.tail = 0;
        }
        public int Count
        {
            get
            {
                return this.size;
            }
        }

       /* public bool isEmpty() //проверка на пустоту
        {
            return size == 0;
        }*/

        public void Enqueue(T newElement)
        {
            if (this.size == this.capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(_array, 0, newQueue,0, _array.Length);
                _array = newQueue;
                capacity *= 2;
            }
            size++;
            _array[tail++%capacity] = newElement;
        }

        public T Dequeue()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            var temp = _array[0];//_array[++head%capacity];
            size--;
            for (int i = 0; i < size; i++)
            {
                _array[i] = _array[i + 1];
            }
            _array[size] = default(T);
            return temp;
        }


        public T Peek()
        {
            if (Count > 0)
                return _array[0];
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
                    if (position > queue.Count)
                        throw new InvalidOperationException();
                    return queue._array[position];
                }
            }

            public bool MoveNext()
            {
                if (position < queue.Count)
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
                get { throw new NotImplementedException(); }
            }
        }

    }
}
