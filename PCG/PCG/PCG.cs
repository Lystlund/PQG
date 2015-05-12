﻿using System;
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

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox2.Items.Add("Knowledge");
            comboBox2.Items.Add("Comfort");
            comboBox2.Items.Add("Reputation");
            comboBox2.Items.Add("Serenity");
            comboBox2.Items.Add("Protection");
            comboBox2.Items.Add("Conquest");
            comboBox2.Items.Add("Wealth");
            comboBox2.Items.Add("Ability");
            comboBox2.Items.Add("Equipment");
            //-------------------------------------
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

            QualityOne(1,6,0, World.RandomNPC());
        }

        private void QualityOne(int a, int b, int c, NPC npc)
        {
            int roll1 = RandomNumberGenerator.NumberBetween(a, b);
            listOfRolls.Add(c);

            

            if (listOfRolls.Contains(roll1))
            {
                listOfRolls.Clear();
                QualityTwo(1, 4, 0, World.RandomNPC());
            }else
            {
                //Console.WriteLine("Rolls NPC1: " + roll1 + "  " + listOfRolls.Last());
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
                //Console.WriteLine("NPC3:");
                Rule start = new Motivations(World.RandomNPC().jobs);

                foreach (var line in Rule.getText(start))
                {
                    rtb1.Text += line + "\n";
                }
            }
            else
            {
                //Console.WriteLine("Rolls NPC2: " + roll1 + "  " + listOfRolls.Last());

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
            }

            if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
            }

            if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
            }

            if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
            }

            if (comboBox2.SelectedIndex == 4)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
            }

            if (comboBox2.SelectedIndex == 5)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
            }

            if (comboBox2.SelectedIndex == 6)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
            }

            if (comboBox2.SelectedIndex == 7)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
            }

            if (comboBox2.SelectedIndex == 8)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
            }
        }
    }
}
