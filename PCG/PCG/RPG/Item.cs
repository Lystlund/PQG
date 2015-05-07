using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Item
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
		public bool InPossession { get; set; }

        public Item(int id, string itemName)
        {
            ID = id;
            ItemName = itemName;
        }
    }
}
