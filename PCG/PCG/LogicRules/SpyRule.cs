using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    class SpyRule : Rule
    {
        public SpyRule(NPC npc)
		{
			Text = "Spy on " + npc.NPCName + ". Return afterwards";
            
            var returnTo = World.RandomNPC();
            outcomes.Add(new GotoRule(npc.Location));
            outcomes.Add(new Rule("You spy on " + npc.NPCName));
            outcomes.Add(new GotoRule(returnTo.Location, true));
            outcomes.Add(new Rule("You return to " + returnTo.NPCName));
		}
    }
}