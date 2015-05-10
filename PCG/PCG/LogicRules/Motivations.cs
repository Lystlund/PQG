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
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                    
                case 3:
                    var item2 = World.RandomItem();
                    Text = "Use " + item2.ItemName + " in the field";
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;
                }
                break;

            case 1:
                switch (RandomNumberGenerator.NumberBetween(0, 2))
                {
                case 0:
                    Text = "Obtain luxuries";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 1:
                    Text = "Kill Pests";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage Pest"));
                    outcomes.Add(new GotoRule(World.RandomLocation(),true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 2:
                switch (RandomNumberGenerator.NumberBetween(0, 3))
                {
                case 0:
                    Text = "Obtain rare item";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 1:
                    Text = "Kill enemies";
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new KillRule(npc));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 2:
                    Text = "Visit a dangerous place";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 3:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    Text = "Revenge, Justice";
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Damage " + npc.NPCName));
                    break;

                case 1:
                    Text = "Capture Criminal(1)";
                    var npc2 = World.RandomNPC();
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 2:
                    Text = "Capture Criminal(2)";
                    var npc3 = World.RandomNPC();
                    var item2 = World.RandomItem();
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new Rule("Capture " + npc3.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 3:
                    Text = "Check on NPC(1)";
                    var npc4 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc4.Location));
                    outcomes.Add(new Rule("Listen to " + npc4.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 4:
                    Text = "Check on NPC(2)";
                    var npc5 = World.RandomNPC();
                    var item3 = World.RandomItem();
                    outcomes.Add(new GotoRule(npc5.Location));
                    outcomes.Add(new Rule("Take " + item3.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item3.ItemName));
                    break;

                case 5:
                    Text = "Recover lost/stolen item";
                    var item4 = World.RandomItem();
                    var npc6 = World.RandomNPC();
                    outcomes.Add(new GetRule(item4));
                    outcomes.Add(new GotoRule(npc6.Location));
                    outcomes.Add(new Rule("Give " + item4.ItemName + " to " + npc6.NPCName));
                    break;

                case 6:
                    Text = "Rescue captured NPC";
                    var npc7 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc7.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("escort " + npc7.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 4:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    Text = "Attack threatening entities";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage entities"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 1:
                    Text = "Treat or repair (1)";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    break;

                case 2:
                    Text = "Treat or repair (2)";
                    var item2 = World.RandomItem();
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair using " + item2.ItemName));
                    break;

                case 3:
                    Text = "Create Diversion (1)";
                    var item3 = World.RandomItem();
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Use " + item3.ItemName));
                    break;

                case 4:
                    Text = "Create Diversion (2)";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 5:
                    Text = "Assemble fortification";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair"));
                    break;

                case 6:
                    Text = "Guard Entity";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;
                }
                break;

            case 5:
                switch (RandomNumberGenerator.NumberBetween(0, 2))
                {
                case 0:
                    Text = "Attack enemy";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage enemy"));
                    break;

                case 1:
                    var item = World.RandomItem();
                    var npc = World.RandomNPC();
                    Text = "Steal " + item.ItemName;

                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new StealRule(npc, item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;
                }
                break;

            case 6:
                switch (RandomNumberGenerator.NumberBetween(0, 3))
                {
                case 0:
                    Text = "Gather raw materials";
                    var item = World.RandomItem();
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new GetRule(item));
                    break;

                case 1:
                    Text = "Steal valuables for resale";
                    var item2 = World.RandomItem();
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new StealRule(npc, item2));
                    break;

                case 2:
                    Text = "Make valuables for resale";
                    outcomes.Add(new Rule("Craft valuables"));
                    break;
                }
                break;

            case 7:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    Text = "Assemble tool for new skill";
                    outcomes.Add(new Rule("Repair"));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 1:
                    Text = "Obtain training materials";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 2:
                    Text = "Use existing tools";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 3:
                    Text = "Practice Combat";
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 4:
                    Text = "Practice skill";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 5:
                    Text = "Research a skill (1)";
                    var item2 = World.RandomItem();
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 6:
                    Text = "Research a skill (2)";
                    var item3 = World.RandomItem();
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new Rule("Experiment"));
                    break;
                }
                break;

            case 8:
                switch (RandomNumberGenerator.NumberBetween(0, 4))
                {
                case 0:
                    Text = "Assemble";
                    outcomes.Add(new Rule("Use"));
                    break;
                    
                case 1:
                    Text = "Deliver supplies";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Give supplies"));
                    break;

                case 2:
                    Text = "Steal supplies";
                    var item2 = World.RandomItem();
                    var npc = World.RandomNPC();
                    outcomes.Add(new StealRule(npc, item2));
                    break;

                case 3:
                    Text = "Trade for supplies";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Exchange"));
                    break;
                }
                break;
            }
        }

        public Motivations(int motivationType, int motivationNumber)
        {
            switch (motivationType)
            {
            case 0:
                switch (motivationNumber)
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
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 3:
                    var item2 = World.RandomItem();
                    Text = "Use " + item2.ItemName + " in the field";
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;
                }
                break;

            case 1:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Obtain luxuries";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 1:
                    Text = "Kill Pests";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage Pest"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 2:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Obtain rare item";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 1:
                    Text = "Kill enemies";
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new KillRule(npc));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 2:
                    Text = "Visit a dangerous place";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 3:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Revenge, Justice";
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Damage " + npc.NPCName));
                    break;

                case 1:
                    Text = "Capture Criminal(1)";
                    var npc2 = World.RandomNPC();
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 2:
                    Text = "Capture Criminal(2)";
                    var npc3 = World.RandomNPC();
                    var item2 = World.RandomItem();
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new Rule("Capture " + npc3.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 3:
                    Text = "Check on NPC(1)";
                    var npc4 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc4.Location));
                    outcomes.Add(new Rule("Listen to " + npc4.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 4:
                    Text = "Check on NPC(2)";
                    var npc5 = World.RandomNPC();
                    var item3 = World.RandomItem();
                    outcomes.Add(new GotoRule(npc5.Location));
                    outcomes.Add(new Rule("Take " + item3.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item3.ItemName));
                    break;

                case 5:
                    Text = "Recover lost/stolen item";
                    var item4 = World.RandomItem();
                    var npc6 = World.RandomNPC();
                    outcomes.Add(new GetRule(item4));
                    outcomes.Add(new GotoRule(npc6.Location));
                    outcomes.Add(new Rule("Give " + item4.ItemName + " to " + npc6.NPCName));
                    break;

                case 6:
                    Text = "Rescue captured NPC";
                    var npc7 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc7.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("escort " + npc7.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 4:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Attack threatening entities";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage entities"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 1:
                    Text = "Treat or repair (1)";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    break;

                case 2:
                    Text = "Treat or repair (2)";
                    var item2 = World.RandomItem();
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair using " + item2.ItemName));
                    break;

                case 3:
                    Text = "Create Diversion (1)";
                    var item3 = World.RandomItem();
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Use " + item3.ItemName));
                    break;

                case 4:
                    Text = "Create Diversion (2)";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 5:
                    Text = "Assemble fortification";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair"));
                    break;

                case 6:
                    Text = "Guard Entity";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;
                }
                break;

            case 5:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Attack enemy";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage enemy"));
                    break;

                case 1:
                    var item = World.RandomItem();
                    var npc = World.RandomNPC();
                    Text = "Steal " + item.ItemName;

                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new StealRule(npc, item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;
                }
                break;

            case 6:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Gather raw materials";
                    var item = World.RandomItem();
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new GetRule(item));
                    break;

                case 1:
                    Text = "Steal valuables for resale";
                    var item2 = World.RandomItem();
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new StealRule(npc, item2));
                    break;

                case 2:
                    Text = "Make valuables for resale";
                    outcomes.Add(new Rule("Craft valuables"));
                    break;
                }
                break;

            case 7:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Assemble tool for new skill";
                    outcomes.Add(new Rule("Repair"));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 1:
                    Text = "Obtain training materials";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 2:
                    Text = "Use existing tools";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 3:
                    Text = "Practice Combat";
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 4:
                    Text = "Practice skill";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 5:
                    Text = "Research a skill (1)";
                    var item2 = World.RandomItem();
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 6:
                    Text = "Research a skill (2)";
                    var item3 = World.RandomItem();
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new Rule("Experiment"));
                    break;
                }
                break;

            case 8:
                switch (motivationNumber)
                {
                case 0:
                    Text = "Assemble";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 1:
                    Text = "Deliver supplies";
                    var item = World.RandomItem();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Give supplies"));
                    break;

                case 2:
                    Text = "Steal supplies";
                    var item2 = World.RandomItem();
                    var npc = World.RandomNPC();
                    outcomes.Add(new StealRule(npc, item2));
                    break;

                case 3:
                    Text = "Trade for supplies";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Exchange"));
                    break;
                }
                break;
            }
        }



    }
}
