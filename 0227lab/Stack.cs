using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0227lab
{
	class Stack<T>
	{
		const int Empty = -1; 
		const int Full = 20;
		T[] Arr;
		int Top;

		Stack()
		{
			Top = Empty;
			Arr = new T[Full + 1];
		}

		public void Show()
		{
			for (int i = 0; i < Top + 1; i++)
			{
				Console.WriteLine(Arr[i]);
			}
			Console.WriteLine();
		}

		public T Peek()
		{
			return Arr[Top];
		}

		public int Count()
		{
			return Top + 1;
		}

		public void Push(T t)
		{
			if (Top != Full)
				Arr[++Top] = t;
		}

		public T Pop()
		{
			if (Top != Empty)
				return Arr[Top--];
			else
				throw new Exception("Can't pop");
		}
	}
}
