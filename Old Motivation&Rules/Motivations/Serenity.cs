using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Serenity
    {
        public int CallOfSerenity = RandomNumberGenerator.NumberBetween(1, 8);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string Questlog)
        {
            switch (CallOfSerenity)
            {
                case 1:
                    gotoPCG GOTO = new gotoPCG();
                    Questlog = read.motivationText[99] + "\n" + read.motivationText[100];
                    return GOTO.returnMsg() + "\n" + "Damgage for Justice \n" + "\n";
                  
                case 2:
                    getPCG get = new getPCG();
                    gotoPCG GOTO2 = new gotoPCG();
                    gotoPCG GOTO3 = new gotoPCG();
                    Questlog = read.motivationText[102] + "\n" + read.motivationText[103];
                    return get.returnMsg() + "\n" + GOTO2.returnMsg() + "\n" + "Use item" + "\n" + GOTO3.returnMsg() + "\n" + "Hand over Criminal \n";

                case 3:
                    getPCG get2 = new getPCG();
                    gotoPCG GOTO4 = new gotoPCG();
                    gotoPCG GOTO5 = new gotoPCG();
                    capturePCG Capture = new capturePCG();
                    Questlog = read.motivationText[105] + "\n" + read.motivationText[106];
                    return get2.returnMsg() + "\n" + GOTO4.returnMsg() + "\n" + Capture.returnMsg() + "\n" + GOTO5.returnMsg() + "\n" + "Hand over Criminal \n";

                case 4:
                    gotoPCG GOTO6 = new gotoPCG();
                    gotoPCG GOTO7 = new gotoPCG();
                    Questlog = read.motivationText[108] + "\n" + read.motivationText[109];
                    return GOTO6.returnMsg() + "\n" + "Listen to NPC" + "\n" + GOTO7.returnMsg() + "\n" + "Report to NPC \n";

                case 5:
                    gotoPCG GOTO8 = new gotoPCG();
                    gotoPCG GOTO9 = new gotoPCG();
                    Questlog = read.motivationText[111] + "\n" + read.motivationText[112];
                    return GOTO8.returnMsg() + "\n" + "Take ITEM" + "\n" + GOTO9.returnMsg() + "\n" + "Give ITEM to NPC \n";

                case 6:
                    getPCG get3 = new getPCG();
                    gotoPCG GOTO10 = new gotoPCG();
                    Questlog = read.motivationText[114] + "\n" + read.motivationText[115];
                    return get3.returnMsg() + "\n" + GOTO10.returnMsg() + "\n" + "Give item to NPC \n";

                case 7:
                    gotoPCG GOTO11 = new gotoPCG();
                    gotoPCG GOTO12 = new gotoPCG();
                    Questlog = read.motivationText[117] + "\n" + read.motivationText[118];
                    return GOTO11.returnMsg() + "Damage enemies and escort NPC" + "\n" + GOTO12.returnMsg() + "\n" + "Report your Succes to NPC \n" + "\n";

                default:
                    Questlog = "Something went wrong, in Serenity";
                    return "Something went wrong, in Serenity";
            }
        }
    }
}
