using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    public class spyPCG
    {
        private int CallOfSpy = 1;

        public string returnMsg()
        {
            switch (CallOfSpy)
            {
            case 1:
                //goto
                //"spy"
                //goto
                //"report"
                gotoPCG GOTO = new gotoPCG();
                gotoPCG GOTO2 = new gotoPCG();
                return "Spy 1: Go someplace, spy on somebody, return and report \n" + GOTO.returnMsg() + "\n" + GOTO2.returnMsg();

            default:
                return "Something went wrong, in Spy";
            }
        }
    }
}
