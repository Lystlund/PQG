using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Wealth
    {
        public int CallofWealth = RandomNumberGenerator.NumberBetween(1, 4);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string Questlog)
        {
            switch (CallofWealth)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG();
                    getPCG get = new getPCG();
                    Questlog = read.motivationText[120] + "\n" + read.motivationText[121];
                    return GOTO.returnMsg() + "\n" + get.returnMsg() + "\n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    stealPCG Steal = new stealPCG();
                    Questlog = read.motivationText[123] + "\n" + read.motivationText[124];
                    return GOTO2.returnMsg() + "\n" + Steal.returnMsg() + "\n";

                case 3:
                    Questlog = read.motivationText[126] + "\n" + read.motivationText[127]; 
                    return "You craft some valuables \n";

                default:
                    Questlog = "Something went wrong, in Wealth";
                    return "Something went wrong, in Wealth";
            }
        }
    }
}
