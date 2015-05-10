using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class gotoPCG
    {
        private int CallofGoto = RandomNumberGenerator.NumberBetween(1, 4);

        public string returnMsg()
        {
            switch (CallofGoto)
            {
            case 1:
                //Already there
                return "Goto 1: You are already there";

            case 2:
                //Explore area
                return "Goto 2: Just wander around and look";
                
            case 3:
                //learn
                //"goto"
                learnPCG learn = new learnPCG();
                return "Goto 3: Find out where to go and go there. \n" + learn.returnMsg();

            default:
                return "Something went wrong, in goto" + "\n";
            }
        }
    }
}
