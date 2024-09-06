//AUTHOR:     Kesli Pratka
//COURSE:     ISTM 601.601
//FORM:       frmCalculateLetterGrade.cs
//PURPOSE:    The user will be able to enter a numeric grade
//            and be able to see the letter grade that corresponds.
//INPUT:      The user should enter a number between 0 and
//            100 in the number grade text box.
//PROCESS:    Program uses an if-else statement to set the 
//            letter grade based on the number grade.
//OUTPUT:     The output will be the letter grade posted in the 
//            letter grade box that corresponds to the number
//            grade.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
//            nor received unauthorized aid on this academic
//            work.”

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PratkaKesliCalculateLetterGrade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declaring and initializing numberGrade variable with user input 
            //and convert to decimal number
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            // declare and initialize the variable that will hold the letter grade
            string letterGrade = "";

            //setting letterGrade to the appropriate corresponding letter
            if(numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <=87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade= "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            //display the letter grade in the Letter Grade text box
            txtLetterGrade.Text = letterGrade;

            //move the focus back to the Number Grade text box
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //makes the Exit button functional
            this.Close();
        }
    }
}
