using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerFramework
{
    class Producer
    {
        public void Run(BoundedBuffer buffer, int numberOfInts)
        {
            for (int i = 0; i < numberOfInts; i++)
            {
                buffer.Put(i);
                Console.WriteLine("Produced: " + i);
            }
        }
    }
}
