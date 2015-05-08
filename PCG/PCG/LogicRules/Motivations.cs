using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    class Motivations : Rule
    {

        public Motivations()
        {
            switch (RandomNumberGenerator.NumberBetween(0, 9))
            {
            case 0:
                switch (RandomNumberGenerator.NumberBetween(0, 4))
                {
                case 0:
                    Text = "Deliver item for study";
                    var item = World.RandomItem();
                    var npc = World.RandomNPC();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Give " + item.ItemName + " to " + npc.NPCName));
                    break;

                case 1:
                    Text = "Spy";
                    outcomes.Add(new SpyRule(World.RandomNPC()));
                    break;

                case 2:
                    var npc2 = World.RandomNPC();
                    Text = "Interview " + npc2.NPCName;
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Listen to " + npc2.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Report"));
                    break;
                    
                case 3:
                    var item2 = World.RandomItem();
                    Text = "Use " + item2.ItemName + " in the field";
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;
                }
                break;

            case 1:
                break;

            case 2:
                break;

            }
        }

        public Motivations(int motivationType, int motivationNumber)
        {
        }



    }
}
