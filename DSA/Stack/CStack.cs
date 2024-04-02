using System;
using System.Collections;

namespace DSA.Stack
{
	public class CStack
	{
		private int p_index;
		private ArrayList list;

		public CStack()
		{
			list = new ArrayList();

            //Initialize the index to -1 so that any item pushed will cause a +1 increment
            p_index = -1;   

		}

		public int Count
		{
			get
			{
				return list.Count;
			}
		}

		public void push(object item)
		{
			list.Add(item);
			p_index++;
		}

		public object pop()
		{
			object obj = list[p_index];
			list.RemoveAt(p_index);
			p_index--;
			return obj;
		}

		public void clear()
		{
			list.Clear();
			p_index = -1;
		}

		public object peek()
		{
			return list[p_index];
			
		}

	}
}

