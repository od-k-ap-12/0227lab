using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0227lab
{
	class Queue<T>
	{
		T[] Wait;
		int MaxQueueLength;
		int QueueLength;

		public void Show()
		{
			Console.WriteLine();
			for (int i = 0; i < QueueLength; i++)
			{
				Console.WriteLine(Wait[i]);
			}
			Console.WriteLine();
		}
		public Queue(int m)
		{
			MaxQueueLength = m;
			Wait = new T[MaxQueueLength];
			QueueLength = 0;
		}

		public T Peek()
		{
			return Wait[0];
		}

		public void Enqueue(T c)
		{
			if (QueueLength!=MaxQueueLength)
				Wait[QueueLength++] = c;
		}

		public T Dequeue()
		{
			if (QueueLength!=0)
			{
				T temp = Wait[0];

				for (int i = 1; i < QueueLength; i++)
				{
					Wait[i - 1] = Wait[i];
				}
				Wait[QueueLength - 1] = temp;
				return temp;
			}

			else 
				throw new Exception("Can't dequeue");
		}
	}
}
