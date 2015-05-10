using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class getPCG
    {
        private int CallOfGet = RandomNumberGenerator.NumberBetween(1, 5);

        public string returnMsg()
        {
            switch (CallOfGet)
            {
            case 1:
                //Already have it
                return "Get 1: You already have it";

            case 2:
                //steal
                stealPCG Steal = new stealPCG();
                return "Get 2: Steal it from somebody \n" + Steal.returnMsg();
            case 3:
                //goto
                //"gather"
                gotoPCG GOTO = new gotoPCG();
                return "Get 3: Go someplace and pick something up that’s lying around there. \n" + GOTO.returnMsg();

            case 4:
                //goto
                //get
                //goto
                //subquest
                //"exchange"
                gotoPCG GOTO2 = new gotoPCG();
                getPCG get = new getPCG();
                gotoPCG GOTO3 = new gotoPCG();
                subQuestPCG subquest = new subQuestPCG();
                return "Get 4: Go someplace, get something, do a subquest for somebody return and exchange. \n" + GOTO2.returnMsg() + "\n" + get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + subquest.returnMsg();

            default:
                return "Something went wrong, in Get";
            }
        }
    }
}
