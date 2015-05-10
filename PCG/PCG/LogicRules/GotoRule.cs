using System;

namespace PCG
{
	public class GotoRule : Rule
	{
		public GotoRule(Location location, bool knowWhereToGo = false) {
			if (World.CurrentLocation == location) {
				Text = "You are already at " + location.LocationName;
			} else if (World.CurrentLocation != location && knowWhereToGo) {
				Text = "Go to " + location.LocationName;
				World.CurrentLocation = location;
			} else {
				switch (RandomNumberGenerator.NumberBetween (0, 2)) {
				case 0:
					Text = "Explore the nearby area";
					break;

				case 1:
					Text = "Learn where to go";
					var learn = new LearnRule ();
					outcomes.Add (learn);
					outcomes.Add(new GotoRule(learn.LearnedLocation, true));
					break;
				}
			}
		}
	}

}

