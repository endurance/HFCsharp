using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        decimal reimburseRate = .39M;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (startNumber.Value > endNumber.Value)
            {
                MessageBox.Show("Cannot Calculate: Starting Value must be less than Ending Value", "Error calculating mileage");
            }
            else
            {

                Owed.Text = "$"+ ((endNumber.Value - startNumber.Value) * reimburseRate);
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(endNumber.Value - startNumber.Value + " miles", "Miles Traveled");
        }
    }
}
