using System;

namespace PCG
{
	public class StealRule : Rule
	{
		public StealRule (NPC npc, Item item)
		{
			Text = "Steal " + item.ItemName + " from " + npc.NPCName;

            switch (RandomNumberGenerator.NumberBetween(0, 2)){
       
            case 0:
                outcomes.Add(new GotoRule(npc.Location));
                if (npc.Alive)
                {
                    outcomes.Add(new Rule(npc.NPCName + " is already dead"));
                    outcomes.Add(new Rule("Take " + item.ItemName));
                }else{
                    outcomes.Add(new Rule("Sneak up on " + npc.NPCName));
                    outcomes.Add(new Rule("Take " + item.ItemName));
                }
                break;

            case 1:
                outcomes.Add (new GotoRule (npc.Location));
			    outcomes.Add (new KillRule (npc));
			    outcomes.Add (new Rule ("Take " + item.ItemName));
                break;
            }
		}
	}
}

