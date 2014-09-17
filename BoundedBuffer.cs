using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerFramework
{
    class BoundedBuffer
    {
        private Queue<int> _queue;
        private int _bufferSize;

        public BoundedBuffer(int bufferSize)
        {
            _bufferSize = bufferSize;
            _queue = new Queue<int>();
        }

        public bool IsFull()
        {
            bool result = _queue.Count >= _bufferSize;
            return result;
        }

        public void Put(int inputValue)
        {
            if (IsFull())
            {
                _queue.Enqueue(inputValue);
            }
        }

        public int Take()
        {
            return _queue.Dequeue();
        }
    }
}
