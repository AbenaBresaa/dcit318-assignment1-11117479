System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double grade;
            bool isNumeric = double.TryParse(txtGrade.Text, out grade);


            if (!isNumeric  grade < 0  grade > 100)
            {
                lblResult.Text = "Please enter a valid grade between 0 and 100.";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }


            string letterGrade;

            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }


            lblResult.Text = $"Your grade is: {letterGrade}";
            lblResult.ForeColor = System.Drawing.Color.Black;
        }
    }
}