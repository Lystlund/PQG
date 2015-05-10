using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class killPCG
    {
        private int CallOfKill = 1;

        public string returnMsg()
        {
            switch (CallOfKill)
            {
            case 1:
                //goto
                //"kill"
                gotoPCG GOTO = new gotoPCG();
                return "Kill 1: Go someplace and kill somebody \n" + GOTO.returnMsg();

            default:
                return "Something went wrong, in Kill";
            }
        }
    }
}
