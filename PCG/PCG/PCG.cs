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
        string holder;

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
			rtbQuest.Text = "";
			rtb1.Text = "";

			//Rule start = new StealRule (World.NPCbyID (1), World.RandomItem());
            //Rule start = new SpyRule(World.NPCbyID(1));
            //Rule start = new CaptureRule(World.NPCbyID(1), World.ItemByID(1));
            Rule start = new GetRule(World.RandomItem());

			foreach (var line in Rule.getText(start)) {
				rtb1.Text += line + "\n";
			}
        }

        public void Quests(int QuestInputNumber){
            switch (QuestInputNumber)
            {
                case 1:
                    Knowledge KnowledgeQuest = new Knowledge();
                    rtb1.Text += KnowledgeQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 2:
                    Comfort ComfortQuest = new Comfort();
                    rtb1.Text += ComfortQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 3:
                    Reputation ReputationQuest = new Reputation();
                    rtb1.Text += ReputationQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 4:
                    Serenity SerenityQuest = new Serenity();
                    rtb1.Text += SerenityQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 5:
                    Protection ProtectionQuest = new Protection();
                    rtb1.Text += ProtectionQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 6:
                    Conquest ConquestQuest = new Conquest();
                    rtb1.Text += ConquestQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 7:
                    Wealth WealthQuest = new Wealth();
                    rtb1.Text += WealthQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 8:
                    Ability AbilityQuest = new Ability();
                    rtb1.Text += AbilityQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                case 9:
                    Equipment EquipmentQuest = new Equipment();
                    rtb1.Text += EquipmentQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                    break;

                default:
                    rtbQuest.Text += "No motivation have been selected! \n \n";
                    rtb1.Text += "No motivation have been selected! \n \n";
                    break;
            }
        }

        public void QuestsSelective(int QuestInputNumber)
        {
            switch (QuestInputNumber)
            {
            case 1:
                if (comboBox1.SelectedIndex == 0)
                {
                    Knowledge KnowledgeQuest = new Knowledge();
                    rtb1.Text += KnowledgeQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Knowledge KnowledgeQuest = new Knowledge();
                    KnowledgeQuest.CallOfKnowledge = comboBox1.SelectedIndex;
                    rtb1.Text += KnowledgeQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 2:
                if (comboBox1.SelectedIndex == 0)
                {
                    Comfort ComfortQuest = new Comfort();
                    rtb1.Text += ComfortQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Comfort ComfortQuest = new Comfort();
                    ComfortQuest.CallOfComfort = comboBox1.SelectedIndex;
                    rtb1.Text += ComfortQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 3:
                if (comboBox1.SelectedIndex == 0)
                {
                    Reputation ReputationQuest = new Reputation();
                    rtb1.Text += ReputationQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Reputation ReputationQuest = new Reputation();
                    ReputationQuest.CallofReputation = comboBox1.SelectedIndex;
                    rtb1.Text += ReputationQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 4:
                if (comboBox1.SelectedIndex == 0)
                {
                    Serenity SerenityQuest = new Serenity();
                    rtb1.Text += SerenityQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Serenity SerenityQuest = new Serenity();
                    SerenityQuest.CallOfSerenity = comboBox1.SelectedIndex;
                    rtb1.Text += SerenityQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 5:
                if (comboBox1.SelectedIndex == 0)
                {
                    Protection ProtectionQuest = new Protection();
                    rtb1.Text += ProtectionQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Protection ProtectionQuest = new Protection();
                    ProtectionQuest.CallOfProtection = comboBox1.SelectedIndex;
                    rtb1.Text += ProtectionQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 6:
                if (comboBox1.SelectedIndex == 0)
                {
                    Conquest ConquestQuest = new Conquest();
                    rtb1.Text += ConquestQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Conquest ConquestQuest = new Conquest();
                    ConquestQuest.CallofConquest = comboBox1.SelectedIndex;
                    rtb1.Text += ConquestQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 7:
                if (comboBox1.SelectedIndex == 0)
                {
                    Wealth WealthQuest = new Wealth();
                    rtb1.Text += WealthQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Wealth WealthQuest = new Wealth();
                    WealthQuest.CallofWealth = comboBox1.SelectedIndex;
                    rtb1.Text += WealthQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 8:
                if (comboBox1.SelectedIndex == 0)
                {
                    Ability AbilityQuest = new Ability();
                    rtb1.Text += AbilityQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Ability AbilityQuest = new Ability();
                    AbilityQuest.CallOfAbility = comboBox1.SelectedIndex;
                    rtb1.Text += AbilityQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            case 9:
                if (comboBox1.SelectedIndex == 0)
                {
                    Equipment EquipmentQuest = new Equipment();
                    rtb1.Text += EquipmentQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                else
                {
                    Equipment EquipmentQuest = new Equipment();
                    EquipmentQuest.CallOfEquipment = comboBox1.SelectedIndex;
                    rtb1.Text += EquipmentQuest.returnMsg(out holder);
                    rtbQuest.Text += holder;
                }
                break;

            default:
                rtbQuest.Text += "No motivation have been selected! \n \n";
                rtb1.Text += "No motivation have been selected! \n \n";
                break;
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

        private void button2_Click(object sender, EventArgs e)
        {
            rtb1.Text = "";
            rtbQuest.Text = "";
            QuestsSelective(comboBox2.SelectedIndex + 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
            }

            if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
            }

            if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
            }

            if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
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
                comboBox1.Items.Add("Random");
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
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
            }

            if (comboBox2.SelectedIndex == 6)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
            }

            if (comboBox2.SelectedIndex == 7)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
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
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
            }
        }
    }
}
