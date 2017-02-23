using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bodyMassButton_Click(object sender, EventArgs e)
        {
            int Weight = 0;
            double Height = 0;
            double BMI = 0;
            string weightRange = "";

            if (weightTextBox.Text == "")
            {
                MessageBox.Show("Please enter the weight", "weight");
                weightTextBox.Focus();
                return;
            }
            try
            {
                Weight = int.Parse(weightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter the numbers only", "weight");
                weightTextBox.SelectAll();
                weightTextBox.Focus();
                return;
            }

            if (heightTextBox.Text == "")
            {
                MessageBox.Show("Please enter the vehicle price", "Vehicle Price");
                heightTextBox.Focus();
                return;
            }
            try
            {
                Height = double.Parse(heightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter the numbers only", "Vehicle Price");
                heightTextBox.SelectAll();
                heightTextBox.Focus();
                return;
            }

            BMI = calcBMI(Weight, Height);

            weightRange = calcWeightRange(BMI);

            bodyMassLabel.Text = BMI.ToString("N2");
            weightRangeLabel.Text = weightRange;

        }

        private double calcBMI(int Weight, double Height)
        {
            // method passed weight (kgs) and height (mtrs), calculates & returnes BMI
            //double score = 0;

            double BMI = 0;                      //declare a local variable to hold BMI
            BMI = Weight / Math.Pow(Height, 2);  //calculate BMI using formula
            return BMI;                          //return BMI
        }

        private string calcWeightRange(double bmi)
        {
            string range = "";
            if (bmi < 18.5)
            {
                range = "Underweight";
            }
            if (bmi >= 18.5 && bmi < 24)
            {
                range = "Normal weight";
            }
            if (bmi >= 24 && bmi < 30)
            {
                range = "Overweight";
            }
            else
            {
                if (bmi >= 30)
                {
                    range = "Obese";
                }
            }

           scoreLabel.Text = range.ToString();
            return range;
        }
    }
}
