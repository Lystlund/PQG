using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    class CaptureRule : Rule
    {
        public CaptureRule(NPC npc, Item item)
		{
			if (npc.Alive) {
				Text = npc.NPCName + " is dead";
			} else {
				npc.Alive = false;
				Text = "Get something, Go someplace and use it to capture " + npc.NPCName;

                outcomes.Add(new GetRule(item));
                outcomes.Add(new GotoRule(npc.Location));
                outcomes.Add(new Rule("Capture " + npc.NPCName));
			}
		}
    }
}
