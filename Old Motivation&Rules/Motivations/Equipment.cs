using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Equipment
    {
        public int CallOfEquipment = RandomNumberGenerator.NumberBetween(1, 5);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string Questlog)
        {
            switch (CallOfEquipment)
            {
                case 1:
                    Questlog = read.motivationText[42] + "\n" + read.motivationText[43];
                    return read.motivationText[44];

                case 2:
                    getPCG get = new getPCG();
                    gotoPCG GOTO = new gotoPCG();

                    Questlog = read.motivationText[46] + "\n" + read.motivationText[47];
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + read.motivationText[48] + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                case 3:
                    stealPCG Steal = new stealPCG();
                    Questlog = read.motivationText[50] + "\n" + read.motivationText[51];
                    return Steal.returnMsg() + "\n";

                case 4:
                    gotoPCG GOTO2 = new gotoPCG();
                    Questlog = read.motivationText[53] + "\n" + read.motivationText[54];
                    return GOTO2.returnMsg() + "\n" + read.motivationText[55];

                default:
                    Questlog = "Something went wrong, in Equipment";
                    return "Something went wrong, in Equipment";
            }
        }
    }
}
