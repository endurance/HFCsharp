using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Races
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Guy(string name, int Cash, Label MyLabel, RadioButton guyButton)
        {
            Name = name;
            this.Cash = Cash;
            this.MyLabel = MyLabel;
            MyRadioButton = guyButton;

        }
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks!";
        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int Amount, int Dog)
        {
            MyBet = new Bet(Amount, Dog, this);
            UpdateLabels();
            return false;
        }

        public void Collect(int Winner)
        {

        }


    }
}
