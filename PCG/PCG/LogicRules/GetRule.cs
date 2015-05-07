using System;

namespace PCG
{
	public class GetRule : Rule
	{
		public GetRule (Item item)
		{
			Text = "Get " + item.ItemName;
			if (item.InPossession) {
				outcomes.Add (new Rule ("Already have " + item.ItemName));
			} else {

                switch (RandomNumberGenerator.NumberBetween(0, 3))
                {
                case 0:
                    NPC stealFrom = World.RandomNPC();
				    outcomes.Add (new StealRule (stealFrom, item));
                    break;

                case 1:
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Gather " + item.ItemName));
                    break;

                case 2:
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new subquestRule());
                    outcomes.Add(new Rule("Exchange " + item.ItemName));
                    break;
                }

			}
		}
	}
}

