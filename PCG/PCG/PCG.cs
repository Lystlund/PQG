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
                QualityTwo(1, 4, 0, World.RandomNPC(2));
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
                Rule start = new Motivations(World.RandomNPC(3).jobs);


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
    }
}
