using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Comfort
    {
        public int CallOfComfort = RandomNumberGenerator.NumberBetween(1, 3);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfComfort)
            {
                case 1:
                    getPCG get = new getPCG();
                    gotoPCG GOTO = new gotoPCG();

                    QuestLog = read.motivationText[28] + "\n" + read.motivationText[29];
                    return get.returnMsg() + "\n" + GOTO.returnMsg() + "\n" + "Give " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + " the luxuries \n";

                case 2:
                    gotoPCG GOTO2 = new gotoPCG();
                    gotoPCG GOTO3 = new gotoPCG();

                    QuestLog = read.motivationText[31] + "\n" + read.motivationText[32];
                    return GOTO2.returnMsg() + "\n" + "kill pests" + "\n" + GOTO3.returnMsg() + "\n" + "Report success to " + World.NPCbyID(RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1)).NPCName + "\n";

                default:
                    QuestLog = "Something went wrong, in Comfort";
                    return "Something went wrong, in Comfort";
            }
        }
    }
}
