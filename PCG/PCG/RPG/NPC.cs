using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class NPC
    {
        public enum job
        {
            Farmer, Bard, Blacksmith, Merchant, Guard,
            Mayor, Knight, Priest,
            King
        };

		public int ID { get; set; }
        public string NPCName { get; set; }
		public bool Alive { get; set; }
		public Location Location { get; set;}
        public bool UniqueNPC { get; set; }
        public job jobs { get; set; }

        public NPC(int id, string npcName, Location npcLocation, job job)
        {
            ID = id;
            NPCName = npcName;
            Location = npcLocation;
            jobs = job;
        }
    }
}
