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
					min = priorityI; //the pqItem with the lowest priority level
					minindex = i;  //set the minimum index to the index of the item with the lowest priority level
				}

			}

            this.Clear();

            for (int y = 0; y < items.Length; y++)
            {
                
                if (y != minindex && ((pqItem)items[y]).Name != "")
				{
					this.Enqueue(items[y]);
				}
            }

            return items[minindex];

        }
    }
}

