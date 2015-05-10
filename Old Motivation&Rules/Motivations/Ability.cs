using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Ability
    {
        public int CallOfAbility = RandomNumberGenerator.NumberBetween(1, 8);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string QuestLog)
        {  
            switch (CallOfAbility)
            {
                case 1:
                    QuestLog = read.motivationText[0] + "\n" + read.motivationText[1];
                    return read.motivationText[2];

                case 2:
                    getPCG get = new getPCG();

                    QuestLog = read.motivationText[4] + "\n" + read.motivationText[5];
                    return get.returnMsg() + "\n" + read.motivationText[6];

                case 3:
                    QuestLog = read.motivationText[8] + "\n" + read.motivationText[9];
                    return read.motivationText[10];

                case 4:
                    QuestLog = read.motivationText[12] + "\n" + read.motivationText[13];
                    return read.motivationText[14];

                case 5:
                    QuestLog = read.motivationText[16] + "\n" + read.motivationText[17];
                    return read.motivationText[18];

                case 6:
                    getPCG get2 = new getPCG();
                    QuestLog = read.motivationText[20] + "\n" + read.motivationText[21];
                    return get2.returnMsg() + "\n" + read.motivationText[22];

                case 7:
                    getPCG get3 = new getPCG();
                    QuestLog = read.motivationText[24] + "\n" + read.motivationText[25];
                    return get3.returnMsg() + "\n" + read.motivationText[26];

                default:
                    QuestLog = "Something went wrong, in Ability";
                    return "Something went wrong, in Ability";
            }
        }
    }
}
