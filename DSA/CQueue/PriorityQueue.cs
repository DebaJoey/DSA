using System;
using System.Collections;
namespace DSA.CQueue
{

	struct pqItem
	{
		public int Priority;
		public string Name;
	}

	public class PriorityQueue:Queue 
	{
		public PriorityQueue() : base()
		{
			
		}

        public override object Dequeue()
        {
			object[] items;
			int min, minindex = 0;
			items = this.ToArray();
			min = ((pqItem)items[0]).Priority;

			for(int i = 1; i < items.Length; i++)
			{
				int priorityI = ((pqItem)items[i]).Priority;
                if (priorityI < min)
				{
					min = priorityI;
					minindex = i;
				}

			}

            this.Clear();

            for (int y = 0; y < items.Length; y++)
            {
                int priorityY = ((pqItem)items[y]).Priority;
                if (y != minindex && ((pqItem)items[y]).Name != "")
				{
					this.Enqueue(items[y]);
				}
            }

            return items[minindex];

        }
    }
}

