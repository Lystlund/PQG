﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class getPCG
    {
        private int CallOfGet { get; set; }

        public getPCG(int callOfGet)
        {
            CallOfGet = callOfGet;
        }

        public string returnMsg()
        {
            switch (CallOfGet + 1)
            {
            case 1:
                //Already have it
                return "Get 1: You already have this " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + "\n";

            case 2:
                //steal
                stealPCG Steal = new stealPCG(RandomNumberGenerator.NumberBetween(0, 1));
                return "Get 2: Steal the item from someone \n" + Steal.returnMsg();

            case 3:
                //goto
                //"gather"
                gotoPCG GOTO = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                return "Get 3: Go someplace and pick something up \n" + GOTO.returnMsg() + "You gathered " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + "\n";

            case 4:
                //goto
                //get
                //goto
                //subquest
                //"exchange"
                gotoPCG GOTO2 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                getPCG get = new getPCG(RandomNumberGenerator.NumberBetween(0, 3));
                gotoPCG GOTO3 = new gotoPCG(RandomNumberGenerator.NumberBetween(0, 2));
                subQuestPCG subquest = new subQuestPCG(RandomNumberGenerator.NumberBetween(0, 1));
                return "Get 4: Go someplace, get something, do a subquest\n" + GOTO2.returnMsg() + get.returnMsg()  + GOTO3.returnMsg() + subquest.returnMsg() + "You exchange ITEMS?" + " \n";

            default:
                return "Something went wrong, in Get";
            }
        }
    }
}