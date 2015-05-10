using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Conquest
    {
        public int CallofConquest = RandomNumberGenerator.NumberBetween(1, 3);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string Questlog)
        {
            switch (CallofConquest)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG();
                    Questlog = read.motivationText[34] + "\n" + read.motivationText[35];
                    return GOTO.returnMsg() + "\n" + read.motivationText[36];

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    stealPCG Steal = new stealPCG();
                    gotoPCG GOTO3 = new gotoPCG();
                    Questlog = read.motivationText[38] + "\n" + read.motivationText[39];
                    return GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + read.motivationText[40];

                default:
                    Questlog = "Something went wrong, in Conquest";
                    return "Something went wrong, in Conquest";
            }
        }
    }
}
