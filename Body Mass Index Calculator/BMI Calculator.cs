using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            /* Calculates a person's Body Mass Index */

            int heightText;  // The person's height in inches
            int weightText;   // The person's weight in pounds
            int bmiText;    // The person's Body Mass Index

            // Get the person's height in inches
            heightText = int.Parse(heightTextBox.Text);

            // Get the person's weight in pounds
            weightText = int.Parse(weightTextBox.Text);

            // Calculate the (height * height) / the weight * 703)
            bmiText = (weightText * 703) / (heightText * heightText);
          
            // Display Body Mass Index
            bmiTextBox.Text = bmiText.ToString();

        }

       

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            /* Clears text boxes and output label */

            heightTextBox.Text = "";
            weightTextBox.Text = "";
            bmiTextBox.Text = "";
        }
    }
}
