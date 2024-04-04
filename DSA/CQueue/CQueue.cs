using System;
using System.Collections;

namespace DSA.CQueue
{
	public class CQueue
	{
		private ArrayList cqueue;

		public CQueue()
		{
			cqueue = new ArrayList();
		}

		public void Enqueue(object item)
		{
			cqueue.Add(item);
		}

		public void Dequeue()
		{
			cqueue.RemoveAt(0);
		}

		public object Peek()
		{
			return cqueue[0];
		}

		public int Count()
		{
			return cqueue.Count;
		}

		public void Clear()
		{
			cqueue.Clear();
		}
	}
}

