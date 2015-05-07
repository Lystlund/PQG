﻿using System;

namespace PCG
{
	public class LearnRule : Rule
	{
        public Location LearnedLocation { get; set; }

		public LearnRule ()
		{
			// TODO: Random location, already learned

			LearnedLocation = World.RandomLocation();

			switch (RandomNumberGenerator.NumberBetween (0, 4)) {
			case 0:
				Text = "You already know that location is " + LearnedLocation.LocationName;
				break;

            case 1:
                var npc = World.RandomNPC();
                outcomes.Add(new GotoRule(World.RandomLocation()));
                outcomes.Add(new subquestRule());
                outcomes.Add(new Rule("Listen to " + npc.NPCName));
                break;

			case 2:
				var readOn = World.RandomItem ();
				Text = "Read location on " + readOn.ItemName;
				outcomes.Add (new GotoRule (World.RandomLocation ()));
				outcomes.Add (new GetRule (readOn));
				outcomes.Add (new Rule ("Read location"));
				break;

            case 3:
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
