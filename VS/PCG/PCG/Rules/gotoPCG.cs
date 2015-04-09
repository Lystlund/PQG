﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class gotoPCG
    {
        private int CallofGoto { get; set; }

        public gotoPCG(int callOfGoto)
        {
            CallofGoto = callOfGoto;
        }

        public string returnMsg()
        {
            switch (CallofGoto + 2)
            {
            case 1:
                //Already there
                return "Goto 1: You are already at this LOCATION" + "\n";

            case 2:
                //Explore area
                return "Goto 2: You wander around the world, exploring until you stumble upon your LOCATION" + "\n";

            case 3:
                //learn
                //"goto"
                learnPCG learn = new learnPCG(RandomNumberGenerator.NumberBetween(0, 3));
                return "Goto 3: \n" + learn.returnMsg() + "You walk to the location" + "\n";

            default:
                return "Something went wrong, in goto" + "\n";
            }
        }
    }
}
