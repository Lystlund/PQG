using System;

namespace PCG
{
	public class KillRule : Rule
	{
		public KillRule (NPC npc)
		{
			if (npc.Alive) {
				Text = npc.NPCName + "is already dead";
			} else {
				npc.Alive = false;
				Text = "Kill " + npc.NPCName;
			}
		}
	}
}

