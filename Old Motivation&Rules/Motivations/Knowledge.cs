using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class Knowledge
    {
        public int CallOfKnowledge = RandomNumberGenerator.NumberBetween(1, 5);
        ReadTxt read = new ReadTxt();

        public string returnMsg(out string QuestLog)
        {
            switch (CallOfKnowledge)
            {
                case 1:
                    subQuestPCG subquest = new subQuestPCG();

                    QuestLog = read.motivationText[57] + "\n" + read.motivationText[58];
                    return subquest.returnMsg() + "\n";

                case 2:
                    spyPCG Spy = new spyPCG();

                    QuestLog = read.motivationText[60] + "\n" + read.motivationText[61];
                    return Spy.returnMsg() + "\n";

                case 3:
                    gotoPCG GOTO = new gotoPCG();
                    gotoPCG GOTO2 = new gotoPCG();
                    int tempInt = RandomNumberGenerator.NumberBetween(1, World.NPCs.Count + 1);

                    QuestLog = read.motivationText[63] + "\n" + read.motivationText[64];
                    return GOTO.returnMsg() + "\n" + "You Listen to what " + World.NPCbyID(tempInt).NPCName + " had to say \n" + GOTO2.returnMsg() + "\n" + "You reported what " + World.NPCbyID(tempInt).NPCName + " told you \n" + "\n";

                case 4:
                    gotoPCG GOTO3 = new gotoPCG();
                    gotoPCG GOTO4 = new gotoPCG();
                    getPCG get = new getPCG();

                    QuestLog = read.motivationText[66] + "\n" + read.motivationText[67];
                    return get.returnMsg() + "\n" + GOTO3.returnMsg() + "\n" + "Use " + World.ItemByID(RandomNumberGenerator.NumberBetween(1, World.Items.Count + 1)).ItemName + "\n" + GOTO4.returnMsg() + "\n" + "Report the Results \n" + "\n";

                default:
                    QuestLog = "Something went wrong, in Knowledge";
                    return "Something went wrong, in Knowledge";
            }
        }
    }
}
