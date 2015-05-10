using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class stealPCG
    {
        private int CallOfSteal = RandomNumberGenerator.NumberBetween(1, 3);

        public string returnMsg()
        {
            switch (CallOfSteal)
            {
            case 1:
                //goto
                //"stealth"
                //"take"

                gotoPCG GOTO = new gotoPCG();
                return "Steal 1: Go someplace, sneak up on somebody, and take something \n" + GOTO.returnMsg();

            case 2:
                //goto
                //kill
                //"take"

                gotoPCG GOTO2 = new gotoPCG();
                killPCG Kill = new killPCG();
                return "Steal 2: Go someplace, kill somebody and take something \n" + GOTO2.returnMsg() + "\n" + Kill.returnMsg();

            default:
                return "Something went wrong, in Steal";
            }
        }
    }
}
