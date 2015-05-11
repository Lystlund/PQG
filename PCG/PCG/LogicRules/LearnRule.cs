using System;

namespace PCG
{
	public class LearnRule : Rule
	{
        public Location LearnedLocation { get; set; }

		public LearnRule ()
		{
			LearnedLocation = World.RandomLocation();

                if (World.SubQuestDone)
                {
                    switch (RandomNumberGenerator.NumberBetween(0, 2))
                    {
                    case 0:
                        Text = "You already know that location is " + LearnedLocation.LocationName;
                        break;

                    case 1:
                        var readOn = World.RandomItem();
                        Text = "Read location on " + readOn.ItemName;
                        outcomes.Add(new GotoRule(World.RandomLocation(), false, true));
                        outcomes.Add(new GetRule(readOn));
                        outcomes.Add(new Rule("Read location"));
                        break;
                   }
              } else {
                    switch (RandomNumberGenerator.NumberBetween(0, 4))
                    {
                    case 0:
                        Text = "You already know that location is " + LearnedLocation.LocationName;
                        break;

                    case 1:
                        World.SubQuestDone = true;
                        var npc = World.RandomNPC();
                        Text = "Go someplace, perform subquest, get info from " + npc.NPCName;
                        outcomes.Add(new GotoRule(npc.Location, false, true));
                        outcomes.Add(new subquestRule());
                        outcomes.Add(new Rule("Listen to " + npc.NPCName));
                        break;

                    case 2:
                        var readOn = World.RandomItem();
                        Text = "Read location on " + readOn.ItemName;
                        outcomes.Add(new GotoRule(World.RandomLocation(), false, true));
                        outcomes.Add(new GetRule(readOn));
                        outcomes.Add(new Rule("Read location"));
                        break;

                    case 3:
                        World.SubQuestDone = true;
                        Text = "Get something, perform subquest, give to NPC in return for info.";
                        var item = World.RandomItem();
                        var npc2 = World.RandomNPC();
                        outcomes.Add(new GetRule(item));
                        outcomes.Add(new subquestRule());
                        outcomes.Add(new Rule("Give " + item.ItemName + "to " + npc2.NPCName));
                        break;
                   }
            }
		}
	}
}

