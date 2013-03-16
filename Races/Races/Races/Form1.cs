using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Races
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];
        Greyhound[] dogs = new Greyhound[4];
        Boolean win = false;
        public Form1()
        {
            InitializeComponent();
            guys[0] = new Guy("Joe", 50, JoeLabel, JoeRadio);
            guys[1] = new Guy("Al", 75, AlLabel, AlRadio);
            guys[2] = new Guy("Bob", 45, BobLabel, BobRadio);

            dogs[0] = new Greyhound(Dog1);
            dogs[1] = new Greyhound(Dog2);
            dogs[2] = new Greyhound(Dog3);
            dogs[3] = new Greyhound(Dog4);

            
        }
        private void Form1_OnLoad(object sender, EventArgs e)
        {
            
        }
        private void radioClicked(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    betNumeric.Value = 5;
                    betNumeric.Maximum = guys[i].Cash;
                    dogNumberNumeric.Value = 1;
                    NameOfBettorLabel.Text = guys[i].Name;
                }
                guys[i].UpdateLabels();
            }

            MinimumBetLabel.Text = "Minimum Bet: " + betNumeric.Value + " bucks.";
            
        }
        private void betsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    guys[i].MyLabel.Text = guys[i].Name + " has bet " + betNumeric.Value;
                    int val1, val2;
                    val1 = Convert.ToInt16(betNumeric.Value);
                    val2 = Convert.ToInt16(dogNumberNumeric.Value);
                    guys[i].PlaceBet(val1, val2);
                }
            }

        }

        private void Race_Click(object sender, EventArgs e)
        {
            while (win == false)
            {
                for (int i = 0; i < 4 && win == false; i++)
                {
                    if (win = dogs[i].Run())
                    {
                        break;
                    }
                }
                if (win)
                {
                    break;
                }

            }
        }
    }
}
