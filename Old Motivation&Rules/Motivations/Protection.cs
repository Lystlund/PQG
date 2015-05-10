using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Protection
    {
        public int CallOfProtection = RandomNumberGenerator.NumberBetween(1, 8);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string Questlog)
        {
            switch (CallOfProtection)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG();
                    gotoPCG GOTO2 = new gotoPCG();

                    Questlog = read.motivationText[69] + "\n" + read.motivationText[70];
                    return GOTO.returnMsg() + "\n" + "Damage Entities \n" + GOTO2.returnMsg() + "\n" + "Report success \n";

                case 2:
                    getPCG get = new getPCG();
                    gotoPCG GOTO3 = new gotoPCG();
                    Questlog = read.motivationText[72] + "\n" + read.motivationText[73];
                    return get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use item\n";

                case 3:
                    gotoPCG GOTO4 = new gotoPCG();
                    Questlog = read.motivationText[75] + "\n" + read.motivationText[76];
                    return GOTO4.returnMsg() + "\n" + "Repair item\n";

                case 4:
                    gotoPCG GOTO5 = new gotoPCG();
                    getPCG get2 = new getPCG();
                    Questlog = read.motivationText[78] + "\n" + read.motivationText[79];
                    return get2.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Use ITEM\n";

                case 5:
                    gotoPCG GOTO6 = new gotoPCG();

                    Questlog = read.motivationText[81] + "\n" + read.motivationText[82];
                    return GOTO6.returnMsg() + "\n" + "Damage NPC \n";

                case 6:
                    gotoPCG GOTO7 = new gotoPCG();
                    Questlog = read.motivationText[84] + "\n" + read.motivationText[85];
                    return GOTO7.returnMsg() + "\n" + "repair item\n";

                case 7:
                    gotoPCG GOTO8 = new gotoPCG();
                    Questlog = read.motivationText[87] + "\n" + read.motivationText[88];
                    return GOTO8.returnMsg() + "\n" + "Defend the Entity\n";

                default:
                    Questlog = "Something went wrong, in Protection";
                    return "Something went wrong, in Protection";
            }
        }
    }
}
