using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Reputation
    {
        public int CallofReputation = RandomNumberGenerator.NumberBetween(1, 4);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string Questlog)
        {
            switch (CallofReputation)
            {
                case 1:
                    getPCG get = new getPCG();
                    gotoPCG GOTO = new gotoPCG();
                    Questlog = read.motivationText[90] + "\n" + read.motivationText[91];
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give NPC rare ITEM \n" + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    killPCG Kill = new killPCG();
                    gotoPCG GOTO3 = new gotoPCG();
                    Questlog = read.motivationText[93] + "\n" + read.motivationText[94];
                    return GOTO2.returnMsg() + "\n" + Kill.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Report success to NPC \n" + "\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG();
                    gotoPCG GOTO5 = new gotoPCG();
                    Questlog = read.motivationText[96] + "\n" + read.motivationText[97];
                    return GOTO4.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Report your visit to NPC \n" + "\n";

                default:
                    Questlog = "Something went wrong, in Reputation";
                    return "Something went wrong, in Reputation";
            }
        }
    }
}
