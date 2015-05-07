using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    class subquestRule : Rule
    {
        public subquestRule()
		{
            switch (RandomNumberGenerator.NumberBetween(0, 2)){
           
            case 0:
                Text = "Subquest to goto somewhere";
                outcomes.Add(new GotoRule(World.LocationByID(RandomNumberGenerator.NumberBetween(0,World.Locations.Count))));
                break;

            case 1:
                Text = "Subquest go somewhere perform a subquest, and return";
                outcomes.Add(new GotoRule(World.LocationByID(RandomNumberGenerator.NumberBetween(0, World.Locations.Count))));
                //Motivation outcome
                outcomes.Add(new Rule("Return"));
                break;
            }
		}
    }
}
