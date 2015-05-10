using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class NPC
    {
		public int ID { get; set; }
        public string NPCName { get; set; }
		public bool Alive { get; set; }
		public Location Location { get; set;}
        public bool UniqueNPC { get; set; }

        public NPC(int id, string npcName, Location npcLocation)
        {
            ID = id;
            NPCName = npcName;
            Location = npcLocation;
        }
    }
}
