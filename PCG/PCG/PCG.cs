using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCG
{
    public partial class PCG : Form
    {
        public List<int> listOfRolls = new List<int>();

        public PCG()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
			rtb1.Text = "";

            World.SubQuestDone = false;
            Rule start = new Motivations();
            
			foreach (var line in Rule.getText(start)) {
				rtb1.Text += line + "\n";
			}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtb1.Text = "";
            QualityOne(1,6,0, World.RandomNPC(1));
        }

        private void QualityOne(int a, int b, int c, NPC npc)
        {
            int roll1 = RandomNumberGenerator.NumberBetween(a, b);
            listOfRolls.Add(c);

            if (listOfRolls.Contains(roll1))
            {
                listOfRolls.Clear();
                var npc2 = World.RandomNPC(2);
                rtb1.Text += connectionText(RandomNumberGenerator.NumberBetween(0,4), npc, npc2);
                QualityTwo(1, 4, 0, npc2);
            }else
            {
                Rule start = new Motivations(npc.jobs);

                foreach (var line in Rule.getText(start))
                {
                    rtb1.Text += line + "\n";
                }
                QualityOne(a, b, c + 1, npc);
            }
        }

        private void QualityTwo(int a, int b, int c, NPC npc)
        {
            int roll1 = RandomNumberGenerator.NumberBetween(a, b);
            listOfRolls.Add(c);

            if (listOfRolls.Contains(roll1))
            {
                listOfRolls.Clear();

                var npc2 = World.RandomNPC(3);
                rtb1.Text += connectionText(RandomNumberGenerator.NumberBetween(4, 7), npc, npc2);

                Rule start = new Motivations(npc2.jobs);

                foreach (var line in Rule.getText(start))
                {
                    rtb1.Text += line + "\n";
                }
            }
            else
            {
                Rule start = new Motivations(npc.jobs);
                foreach (var line in Rule.getText(start))
                {
                    rtb1.Text += line + "\n";
                }
                QualityTwo(a, b, c + 1, npc);
            }
        }

        /// <summary>
        /// Used to keep the Rich Text Box (Text log) scrolling down automatically
        /// </summary>
        private void ScrollToBottomOfMessages()
        {
            rtb1.SelectionStart = rtb1.Text.Length;
            rtb1.ScrollToCaret();
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            ScrollToBottomOfMessages();
        }

        private string connectionText(int input, NPC npc, NPC npc2)
        {
            switch (input)
            {
            case 0:
                return "\nThe " + npc.jobs + " Says: I met with the " + npc2.jobs + " in the pub and told him about your assistance over an ale. He too would like your assistance. Please go to him. \n \n";

            case 1:
                return "\nThe " + npc.jobs + " Says: Now that you have been so kind to assist me in need, you should seek to help other people as well. Try to visit the " + npc2.jobs + " and see if he needs your assistance.\n \n";

            case 2:
                return "\nThe " + npc.jobs + " Says: Thank you for your kind assistance, I don't have anymore for you to do but I heard the " + npc2.jobs + " is looking for someone of your talents.\n \n";

            case 3:
                return "\nThe " + npc.jobs + " Says: I know I’m just a simple " + npc.jobs + ", but I thank you for your help. I have told the " + npc2.jobs + " about what you have done and he was impressed. He would like you to go to him and help him.\n \n";
            
            case 4:
                return "\nThe " + npc.jobs + " Says: The " + npc2.jobs + " have heard of your honorable deeds and would like your help with some troubling matters. Please go see him.\n \n";

            case 5:
                return "\nThe " + npc.jobs + " Says: Your mighty heroics have impressed the " + npc2.jobs + " and he would like your assistance with pressing matters. Don’t make him wait.\n \n";

            case 6:
                return "\nThe " + npc.jobs + " Says: Such heroics! I have never seen the like before! Neither have the " + npc2.jobs + ". He seeks your aid with some pressing matters. Go to him. Now!\n \n";

            default:
                return "Connection Text out of range";
            }
        }
    }
}
