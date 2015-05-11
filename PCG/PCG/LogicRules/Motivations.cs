﻿using System;
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
                    Text = "[Deliver item for study]";
                    var item = World.RandomItem(0);
                    var npc = World.RandomNPC();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc.Location, true));
                    outcomes.Add(new Rule("Give " + item.ItemName + " to " + npc.NPCName));
                    break;

                case 1:
                    Text = "[Spy]";
                    outcomes.Add(new SpyRule(World.RandomNPC()));
                    break;

                case 2:
                    var npc2 = World.RandomNPC();
                    Text = "[Interview " + npc2.NPCName + "]";
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Listen to " + npc2.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                    
                case 3:
                    var item2 = World.RandomItem(RandomNumberGenerator.NumberBetween(0,2));
                    Text = "[Use " + item2.ItemName + " in the field]";
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
                    Text = "[Obtain luxuries]";
                    var item = World.RandomItem(2);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 1:
                    Text = "[Kill Pests]";
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
                    Text = "[Obtain rare item]";
                    int holder = RandomNumberGenerator.NumberBetween(0, 2);
                    var item = World.RandomItem();
                    if (holder == 0)
                    {
                        item = World.RandomItem(0);
                    }else
                    {
                        item = World.RandomItem(2);
                    }
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give rare " + item.ItemName));
                    break;

                case 1:
                    Text = "[Kill enemies]";
                    var npc = World.RandomNPC();
                    npc.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new KillRule(npc));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 2:
                    Text = "[Visit a dangerous place]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 3:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    Text = "[Revenge, Justice]";
                    var npc = World.RandomNPC();
                    npc.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Damage " + npc.NPCName));
                    break;

                case 1:
                    Text = "[Capture Criminal(1)]";
                    var npc2 = World.RandomNPC();
                    var item = World.RandomItem(2);
                    npc2.Location = World.RandomLocation(1);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc2.Location, true));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 2:
                    Text = "[Capture Criminal(2)]";
                    var npc3 = World.RandomNPC();
                    var item2 = World.RandomItem(2);
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(npc3.Location, true));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new Rule("Capture " + npc3.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 3:
                    Text = "[Check on NPC(1)]";
                    var npc4 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc4.Location));
                    outcomes.Add(new Rule("Listen to " + npc4.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 4:
                    Text = "[Check on NPC(2)]";
                    var npc5 = World.RandomNPC();
                    var item3 = World.RandomItem(1);
                    outcomes.Add(new GotoRule(npc5.Location));
                    outcomes.Add(new Rule("Take " + item3.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item3.ItemName));
                    break;

                case 5:
                    Text = "[Recover lost/stolen item]";
                    var item4 = World.RandomItem(RandomNumberGenerator.NumberBetween(0,3));
                    var npc6 = World.RandomNPC();
                    outcomes.Add(new GetRule(item4));
                    outcomes.Add(new GotoRule(npc6.Location, true));
                    outcomes.Add(new Rule("Give " + item4.ItemName + " to " + npc6.NPCName));
                    break;

                case 6:
                    Text = "[Rescue captured NPC]";
                    var npc7 = World.RandomNPC();
                    npc7.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc7.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("Escort " + npc7.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                }
                break;

            case 4:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    Text = "[Attack threatening entities]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage entities"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 1:
                    Text = "[Treat or repair (1)]";
                    var item = World.RandomItem(3);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    break;

                case 2:
                    Text = "[Treat or repair (2)]";
                    var item2 = World.RandomItem(3);
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair using " + item2.ItemName));
                    break;

                case 3:
                    Text = "[Create Diversion (1)]";
                    var item3 = World.RandomItem(1);
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(World.RandomLocation(1), true));
                    outcomes.Add(new Rule("Use " + item3.ItemName));
                    break;

                case 4:
                    Text = "[Create Diversion (2)]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 5:
                    Text = "[Assemble fortification]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair"));
                    break;

                case 6:
                    Text = "[Guard Entity]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;
                }
                break;

            case 5:
                switch (RandomNumberGenerator.NumberBetween(0, 2))
                {
                case 0:
                    Text = "[Attack enemy]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage enemy"));
                    break;

                case 1:
                    var item = World.RandomItem(RandomNumberGenerator.NumberBetween(1,4));
                    var npc = World.RandomNPC();
                    Text = "[Steal " + item.ItemName + "]";

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
                    Text = "[Gather raw materials]";
                    var item = World.RandomItem(3);
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new GetRule(item));
                    break;

                case 1:
                    Text = "[Steal valuables for resale]";
                    var item2 = World.RandomItem(2);
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new StealRule(npc, item2));
                    break;

                case 2:
                    Text = "[Make valuables for resale]";
                    outcomes.Add(new Rule("Craft valuables"));
                    break;
                }
                break;

            case 7:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    Text = "[Assemble tool for new skill]";
                    outcomes.Add(new Rule("Repair"));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 1:
                    Text = "[Obtain training materials]";
                    var item = World.RandomItem(3);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 2:
                    Text = "[Use existing tools]";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 3:
                    Text = "[Practice Combat]";
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 4:
                    Text = "[Practice skill]";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 5:
                    Text = "[Research a skill (1)]";
                    var item2 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 6:
                    Text = "[Research a skill (2)]";
                    var item3 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new Rule("Experiment"));
                    break;
                }
                break;

            case 8:
                switch (RandomNumberGenerator.NumberBetween(0, 4))
                {
                case 0:
                    Text = "[Assemble]";
                    outcomes.Add(new Rule("Use"));
                    break;
                    
                case 1:
                    Text = "[Deliver supplies]";
                    var item = World.RandomItem(3);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give supplies"));
                    break;

                case 2:
                    Text = "[Steal supplies]";
                    var item2 = World.RandomItem(3);
                    var npc = World.RandomNPC();
                    outcomes.Add(new StealRule(npc, item2));
                    break;

                case 3:
                    Text = "[Trade for supplies]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Exchange"));
                    break;
                }
                break;
            }
        }

        public Motivations(NPC.job job)
        {
            switch (job){
            case NPC.job.Farmer:
                switch (RandomNumberGenerator.NumberBetween(0, 7))
                {
                case 0:
                    var npc = World.RandomNPC();
                    Text = "[Interview " + npc.NPCName + "]";
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Listen to " + npc.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 1:
                    var item = World.RandomItem(RandomNumberGenerator.NumberBetween(0, 2));
                    Text = "[Use " + item.ItemName + " in the field]";
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 2:
                    Text = "[Kill Pests]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage Pest"));
                    outcomes.Add(new GotoRule(World.RandomLocation(),true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 3:
                    Text = "[Check on NPC(1)]";
                    var npc2 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Listen to " + npc2.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 4:
                    Text = "[Check on NPC(2)]";
                    var npc3 = World.RandomNPC();
                    var item2 = World.RandomItem(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Take " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;

                case 5:
                    Text = "[Treat or repair (2)]";
                    var item3 = World.RandomItem(3);
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair using " + item3.ItemName));
                    break;

                case 6:
                    Text = "[Assemble]";
                    outcomes.Add(new Rule("Use"));
                    break;
                }
                break;

            case NPC.job.Bard:
                switch (RandomNumberGenerator.NumberBetween(0, 6))
                {
                case 0:
                    var npc = World.RandomNPC();
                    Text = "[Interview " + npc.NPCName + "]";
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Listen to " + npc.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 1:
                    Text = "[Obtain rare item]";
                    int holder = RandomNumberGenerator.NumberBetween(0, 2);
                    var item = World.RandomItem();
                    if (holder == 0)
                    {
                        item = World.RandomItem(0);
                    }
                    else
                    {
                        item = World.RandomItem(2);
                    }
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give rare " + item.ItemName));
                    break;

                case 2:
                    Text = "[Kill enemies]";
                    var npc2 = World.RandomNPC();
                    npc2.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new KillRule(npc2));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 3:
                    Text = "[Visit a dangerous place]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 4:
                    Text = "[Revenge, Justice]";
                    var npc3 = World.RandomNPC();
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Damage " + npc3.NPCName));
                    break;

                case 5:
                    Text = "[Practice skill]";
                    outcomes.Add(new Rule("Use"));
                    break;
                }
                break;

            case NPC.job.Blacksmith:
                switch (RandomNumberGenerator.NumberBetween(0, 8))
                {
                case 0:
                    Text = "[Obtain rare item]";
                    int holder = RandomNumberGenerator.NumberBetween(0, 2);
                    var item = World.RandomItem();
                    if (holder == 0)
                    {
                        item = World.RandomItem(0);
                    }
                    else
                    {
                        item = World.RandomItem(2);
                    }
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give rare " + item.ItemName));
                    break;

                case 1:
                    Text = "[Check on NPC(1)]";
                    var npc = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Listen to " + npc.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 2:
                    Text = "[Check on NPC(2)]";
                    var npc2 = World.RandomNPC();
                    var item2 = World.RandomItem(1);
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Take " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;

                case 3:
                    Text = "[Recover lost/stolen item]";
                    var item3 = World.RandomItem(RandomNumberGenerator.NumberBetween(0, 3));
                    var npc3 = World.RandomNPC();
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(npc3.Location, true));
                    outcomes.Add(new Rule("Give " + item3.ItemName + " to " + npc3.NPCName));
                    break;

                case 4:
                    Text = "[Treat or repair (2)]";
                    var item4 = World.RandomItem(3);
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair using " + item4.ItemName));
                    break;

                case 5:
                    Text = "[Obtain training materials]";
                    var item5 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item5));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 6:
                    Text = "[Practice skill]";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 7:
                    Text = "[Deliver supplies]";
                    var item6 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item6));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give supplies"));
                    break;

                }
                break;

            case NPC.job.Merchant:
                switch (RandomNumberGenerator.NumberBetween(0, 9))
                {
                case 0:
                    Text = "[Obtain luxuries]";
                    var item = World.RandomItem(2);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item.ItemName));
                    break;

                case 1:
                    Text = "[Kill Pests]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage Pest"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 2:
                    Text = "[Obtain rare item]";
                    int holder = RandomNumberGenerator.NumberBetween(0, 2);
                    var item2 = World.RandomItem();
                    if (holder == 0)
                    {
                        item = World.RandomItem(0);
                    }else
                    {
                        item = World.RandomItem(2);
                    }
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give rare " + item2.ItemName));
                    break;

                case 3:
                    Text = "[Recover lost/stolen item]";
                    var item3 = World.RandomItem(RandomNumberGenerator.NumberBetween(0,3));
                    var npc = World.RandomNPC();
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(npc.Location, true));
                    outcomes.Add(new Rule("Give " + item3.ItemName + " to " + npc.NPCName));
                    break;

                case 4:
                    Text = "[Steal valuables for resale]";
                    var item4 = World.RandomItem(2);
                    var npc2 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new StealRule(npc2, item4));
                    break;

                case 5:
                    Text = "[Make valuables for resale]";
                    outcomes.Add(new Rule("Craft valuables"));
                    break;

                case 6:
                    Text = "[Deliver supplies]";
                    var item5 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item5));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give supplies"));
                    break;

                case 7:
                    Text = "[Steal supplies]";
                    var item6 = World.RandomItem(3);
                    var npc3 = World.RandomNPC();
                    outcomes.Add(new StealRule(npc3, item6));
                    break;

                case 8:
                    Text = "[Trade for supplies]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Exchange"));
                    break;
                }
                break;

            case NPC.job.Guard:
                switch (RandomNumberGenerator.NumberBetween(0, 18))
                {
                case 0:
                    Text = "[Spy]";
                    outcomes.Add(new SpyRule(World.RandomNPC()));
                    break;

                case 1:
                    var npc = World.RandomNPC();
                    Text = "[Interview " + npc.NPCName + "]";
                    outcomes.Add(new GotoRule(npc.Location));
                    outcomes.Add(new Rule("Listen to " + npc.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 2:
                    Text = "[Kill enemies]";
                    var npc2 = World.RandomNPC();
                    npc2.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new KillRule(npc2));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 3:
                    Text = "[Visit a dangerous place]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 4:
                    Text = "[Revenge, Justice]";
                    var npc3 = World.RandomNPC();
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Damage " + npc3.NPCName));
                    break;

                case 5:
                    Text = "[Capture Criminal(1)]";
                    var npc4 = World.RandomNPC();
                    var item = World.RandomItem(2);
                    npc4.Location = World.RandomLocation(1);
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc4.Location, true));
                    outcomes.Add(new Rule("Use " + item.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 6:
                    Text = "[Capture Criminal(2)]";
                    var npc5 = World.RandomNPC();
                    var item2 = World.RandomItem(2);
                    npc5.Location = World.RandomLocation(1);
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(npc5.Location, true));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new Rule("Capture " + npc5.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 7:
                    Text = "[Check on NPC(1)]";
                    var npc6 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc6.Location));
                    outcomes.Add(new Rule("Listen to " + npc6.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 8:
                    Text = "[Check on NPC(2)]";
                    var npc7 = World.RandomNPC();
                    var item3 = World.RandomItem(1);
                    outcomes.Add(new GotoRule(npc7.Location));
                    outcomes.Add(new Rule("Take " + item3.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item3.ItemName));
                    break;

                case 9:
                    Text = "[Recover lost/stolen item]";
                    var item4 = World.RandomItem(RandomNumberGenerator.NumberBetween(0, 3));
                    var npc8 = World.RandomNPC();
                    outcomes.Add(new GetRule(item4));
                    outcomes.Add(new GotoRule(npc8.Location, true));
                    outcomes.Add(new Rule("Give " + item4.ItemName + " to " + npc8.NPCName));
                    break;

                case 10:
                    Text = "[Rescue captured NPC]";
                    var npc9 = World.RandomNPC();
                    npc9.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc9.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("Escort " + npc9.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 11:
                    Text = "[Attack threatening entities]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage entities"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 12:
                    Text = "[Create Diversion (1)]";
                    var item5 = World.RandomItem(1);
                    outcomes.Add(new GetRule(item5));
                    outcomes.Add(new GotoRule(World.RandomLocation(1), true));
                    outcomes.Add(new Rule("Use " + item5.ItemName));
                    break;

                case 13:
                    Text = "[Create Diversion (2)]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 14:
                    Text = "[Assemble fortification]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Repair"));
                    break;

                case 15:
                    Text = "[Guard Entity]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;

                case 16:
                    Text = "[Practice Combat]";
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 17:
                    Text = "[Trade for supplies]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Exchange"));
                    break;
                }
                break;

            case NPC.job.Mayor:
                switch (RandomNumberGenerator.NumberBetween(0, 12))
                {
                case 0:
                    Text = "[Deliver item for study]";
                    var item = World.RandomItem(0);
                    var npc = World.RandomNPC();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc.Location, true));
                    outcomes.Add(new Rule("Give " + item.ItemName + " to " + npc.NPCName));
                    break;

                case 1:
                    Text = "[Spy]";
                    outcomes.Add(new SpyRule(World.RandomNPC()));
                    break;

                case 2:
                    var npc2 = World.RandomNPC();
                    Text = "[Interview " + npc2.NPCName + "]";
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Listen to " + npc2.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                case 3:
                    Text = "[Obtain luxuries]";
                    var item2 = World.RandomItem(2);
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;

                case 4:
                    Text = "[Kill Pests]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Damage Pest"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 5:
                    Text = "[Revenge, Justice]";
                    var npc3 = World.RandomNPC();
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Damage " + npc3.NPCName));
                    break;

                case 6:
                    Text = "[Capture Criminal(1)]";
                    var npc4 = World.RandomNPC();
                    var item3 = World.RandomItem(2);
                    npc4.Location = World.RandomLocation(1);
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(npc4.Location, true));
                    outcomes.Add(new Rule("Use " + item3.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Hand-in Captive"));
                    break;

                case 7:
                    Text = "[Check on NPC(1)]";
                    var npc5 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc5.Location));
                    outcomes.Add(new Rule("Listen to " + npc5.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 8:
                    Text = "[Check on NPC(2)]";
                    var npc6 = World.RandomNPC();
                    var item4 = World.RandomItem(1);
                    outcomes.Add(new GotoRule(npc6.Location));
                    outcomes.Add(new Rule("Take " + item4.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item4.ItemName));
                    break;

                case 9:
                    Text = "[Rescue captured NPC]";
                    var npc7 = World.RandomNPC();
                    npc7.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc7.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("Escort " + npc7.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 10:
                    Text = "[Research a skill (1)]";
                    var item5 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item5));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 11:
                    Text = "[Research a skill (2)]";
                    var item6 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item6));
                    outcomes.Add(new Rule("Experiment"));
                    break;
                }
                break;

            case NPC.job.Knight:
                switch(RandomNumberGenerator.NumberBetween(0,13)){
                     
                case 0:
                     var npc = World.RandomNPC();
                     Text = "[Interview " + npc.NPCName + "]";
                     outcomes.Add(new GotoRule(npc.Location));
                     outcomes.Add(new Rule("Listen to " + npc.NPCName));
                     outcomes.Add(new GotoRule(World.RandomLocation(), true));
                     outcomes.Add(new Rule("Report"));
                     break;

                case 1:
                     Text = "[Obtain rare item]";
                     int holder = RandomNumberGenerator.NumberBetween(0, 2);
                     var item = World.RandomItem();
                     if (holder == 0)
                     {
                         item = World.RandomItem(0);
                     }
                     else
                     {
                         item = World.RandomItem(2);
                     }
                     outcomes.Add(new GetRule(item));
                     outcomes.Add(new GotoRule(World.RandomLocation(), true));
                     outcomes.Add(new Rule("Give rare " + item.ItemName));
                     break;

                case 2:
                     Text = "[Kill enemies]";
                     var npc2 = World.RandomNPC();
                     npc2.Location = World.RandomLocation(1);
                     outcomes.Add(new GotoRule(npc2.Location));
                     outcomes.Add(new KillRule(npc2));
                     outcomes.Add(new GotoRule(World.RandomLocation(), true));
                     outcomes.Add(new Rule("Report"));
                     break;

                case 3:
                     Text = "[Visit a dangerous place]";
                     outcomes.Add(new GotoRule(World.RandomLocation(1)));
                     outcomes.Add(new GotoRule(World.RandomLocation(), true));
                     outcomes.Add(new Rule("Report"));
                     break;

                case 4:
                    Text = "[Revenge, Justice]";
                    var npc3 = World.RandomNPC();
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new Rule("Damage " + npc3.NPCName));
                    break;

                case 5:
                    Text = "[Recover lost/stolen item]";
                    var item2 = World.RandomItem(RandomNumberGenerator.NumberBetween(0, 3));
                    var npc4 = World.RandomNPC();
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(npc4.Location, true));
                    outcomes.Add(new Rule("Give " + item2.ItemName + " to " + npc4.NPCName));
                    break;

                case 6:
                    Text = "[Rescue captured NPC]";
                    var npc5 = World.RandomNPC();
                    npc5.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc5.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("Escort " + npc5.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;
                    
                case 7:
                    Text = "[Attack threatening entities]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage entities"));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 8:
                    Text = "[Create Diversion (1)]";
                    var item3 = World.RandomItem(1);
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(World.RandomLocation(1), true));
                    outcomes.Add(new Rule("Use " + item3.ItemName));
                    break;

                case 9:
                    Text = "[Create Diversion (2)]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage"));
                    break;

                case 10:
                    Text = "[Guard Entity]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;

                case 11:
                    Text = "[Attack enemy]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage enemy"));
                    break;

                case 12:
                    Text = "[Practice Combat]";
                    outcomes.Add(new Rule("Damage"));
                    break;
                }
                break;

            case NPC.job.Priest:
                switch (RandomNumberGenerator.NumberBetween(0, 13))
                {
                case 0:
                    Text = "[Deliver item for study]";
                    var item = World.RandomItem(0);
                    var npc = World.RandomNPC();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc.Location, true));
                    outcomes.Add(new Rule("Give " + item.ItemName + " to " + npc.NPCName));
                    break;

                case 1:
                    Text = "[Spy]";
                    outcomes.Add(new SpyRule(World.RandomNPC()));
                    break;

                case 2:
                    var npc2 = World.RandomNPC();
                    Text = "[Interview " + npc2.NPCName + "]";
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Listen to " + npc2.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 3:
                    var item2 = World.RandomItem(RandomNumberGenerator.NumberBetween(0, 2));
                    Text = "[Use " + item2.ItemName + " in the field]";
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;

                case 4:
                    Text = "[Obtain rare item]";
                    int holder = RandomNumberGenerator.NumberBetween(0, 2);
                    var item3 = World.RandomItem();
                    if (holder == 0)
                    {
                        item3 = World.RandomItem(0);
                    }
                    else
                    {
                        item3 = World.RandomItem(2);
                    }
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give rare " + item3.ItemName));
                    break;

                case 5:
                    Text = "[Kill enemies]";
                    var npc3 = World.RandomNPC();
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new KillRule(npc3));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 6:
                    Text = "[Visit a dangerous place]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 7:
                    Text = "[Check on NPC(1)]";
                    var npc4 = World.RandomNPC();
                    outcomes.Add(new GotoRule(npc4.Location));
                    outcomes.Add(new Rule("Listen to " + npc4.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 8:
                    Text = "[Guard Entity]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;

                case 9:
                    Text = "[Use existing tools]";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 10:
                    Text = "[Practice skill]";
                    outcomes.Add(new Rule("Use"));
                    break;

                case 11:
                    Text = "[Research a skill (1)]";
                    var item4 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item4));
                    outcomes.Add(new Rule("Use"));
                    break;

                case 12:
                    Text = "[Research a skill (2)]";
                    var item5 = World.RandomItem(3);
                    outcomes.Add(new GetRule(item5));
                    outcomes.Add(new Rule("Experiment"));
                    break;
                }
                break;

            case NPC.job.King:
                switch (RandomNumberGenerator.NumberBetween(0, 1))
                {
                case 0:
                    Text = "[Deliver item for study]";
                    var item = World.RandomItem(0);
                    var npc = World.RandomNPC();
                    outcomes.Add(new GetRule(item));
                    outcomes.Add(new GotoRule(npc.Location, true));
                    outcomes.Add(new Rule("Give " + item.ItemName + " to " + npc.NPCName));
                    break;

                case 1:
                    Text = "[Spy]";
                    outcomes.Add(new SpyRule(World.RandomNPC()));
                    break;

                case 2:
                    var npc2 = World.RandomNPC();
                    Text = "[Interview " + npc2.NPCName + "]";
                    outcomes.Add(new GotoRule(npc2.Location));
                    outcomes.Add(new Rule("Listen to " + npc2.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 3:
                    var item2 = World.RandomItem(RandomNumberGenerator.NumberBetween(0, 2));
                    Text = "[Use " + item2.ItemName + " in the field]";
                    outcomes.Add(new GetRule(item2));
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Use " + item2.ItemName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item2.ItemName));
                    break;

                case 4:
                    Text = "[Obtain luxuries]";
                    var item3 = World.RandomItem(2);
                    outcomes.Add(new GetRule(item3));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item3.ItemName));
                    break;

                case 5:
                    Text = "[Obtain rare item]";
                    int holder = RandomNumberGenerator.NumberBetween(0, 2);
                    var item4 = World.RandomItem();
                    if (holder == 0)
                    {
                        item4 = World.RandomItem(0);
                    }
                    else
                    {
                        item4 = World.RandomItem(2);
                    }
                    outcomes.Add(new GetRule(item4));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give rare " + item4.ItemName));
                    break;

                case 6:
                    Text = "[Kill enemies]";
                    var npc3 = World.RandomNPC();
                    npc3.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc3.Location));
                    outcomes.Add(new KillRule(npc3));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 7:
                    Text = "[Revenge, Justice]";
                    var npc4 = World.RandomNPC();
                    npc4.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc4.Location));
                    outcomes.Add(new Rule("Damage " + npc4.NPCName));
                    break;

                case 8:
                    Text = "[Rescue captured NPC]";
                    var npc5 = World.RandomNPC();
                    npc5.Location = World.RandomLocation(1);
                    outcomes.Add(new GotoRule(npc5.Location));
                    outcomes.Add(new Rule("Damage captures"));
                    outcomes.Add(new Rule("Escort " + npc5.NPCName));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Report"));
                    break;

                case 9:
                    Text = "[Guard Entity]";
                    outcomes.Add(new GotoRule(World.RandomLocation()));
                    outcomes.Add(new Rule("Defend"));
                    break;

                case 10:
                    Text = "[Attack enemy]";
                    outcomes.Add(new GotoRule(World.RandomLocation(1)));
                    outcomes.Add(new Rule("Damage enemy"));
                    break;

                case 11:
                    var item5 = World.RandomItem(RandomNumberGenerator.NumberBetween(1, 4));
                    var npc6 = World.RandomNPC();
                    Text = "[Steal " + item5.ItemName + "]";

                    outcomes.Add(new GotoRule(npc6.Location));
                    outcomes.Add(new StealRule(npc6, item5));
                    outcomes.Add(new GotoRule(World.RandomLocation(), true));
                    outcomes.Add(new Rule("Give " + item5.ItemName));
                    break;
                }
                break;
            }
        }
    }
}
