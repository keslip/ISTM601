//AUTHOR:     Kesli Pratka
//COURSE:     ISTM 601.601
//FORM:       frmStopLight.cs
//PURPOSE:    This program is designed to simulate a stoplight
//            as the user tabs or clicks on the textboxes.
//INPUT:      No input is required from user.
//PROCESS:    Highlights the next textbox the appropriate color
//            and makes the others gray as the user tabs.
//OUTPUT:     Returns an appropriate state change to the stoplight.
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

namespace PratkaKesliStopLight
{
    public partial class frmStopLight : Form
    {
        //global variable that will keep track of the next color the stoplight needs to be
        String strNextLight = "Green";

        public frmStopLight()
        {
            InitializeComponent();

            //start by making the green text box green when the form loads
            txtGreen.BackColor = Color.Green;
        }

        /// <summary>
        /// this EVENT is what happens when you trigger the EVENT of a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this makes the Exit Button functional
            this.Close();
        }

        private void txtGreen_Enter(object sender, EventArgs e)
        {
            //starting the if that will use the global variable to display the next color
            //of the stoplight in order (Green, Yellow, Red, Green, etc)
            if(strNextLight == "Green")
            {
                //since green is next, make that box green
                txtGreen.BackColor = Color.Green;

                //make the other two boxes gray
                txtRed.BackColor = Color.DarkGray;
                txtYellow.BackColor = Color.DarkGray;

                //yellow always comes after green so set that
                strNextLight = "Yellow";
            }
            //start the else if for the case that yellow is the next light 
            else if (strNextLight == "Yellow")
            {
                //since yellow is next, make that box yellow
                txtYellow.BackColor = Color.Yellow;

                //make the other two boxes gray
                txtRed.BackColor= Color.DarkGray;
                txtGreen.BackColor = Color.DarkGray;

                //red always comes after yellow, so set that
                strNextLight = "Red";
            }
            //start the else if for the case that red is the next light
            else if (strNextLight == "Red")
            {
                //since red is next, make that box red
                txtRed.BackColor = Color.Red;

                //make the other two boxes gray
                txtGreen.BackColor=Color.DarkGray;
                txtYellow.BackColor= Color.DarkGray;

                //green always comes after red, so set that
                strNextLight = "Green";
            }
        }

        private void txtYellow_Enter(object sender, EventArgs e)
        {
            //starting the if that will use the global variable to display the next color
            //of the stoplight in order (Green, Yellow, Red, Green, etc)
            if (strNextLight == "Green")
            {
                //since green is next, make that box green
                txtGreen.BackColor = Color.Green;

                //make the other two boxes gray
                txtRed.BackColor = Color.DarkGray;
                txtYellow.BackColor = Color.DarkGray;

                //yellow always comes after green so set that
                strNextLight = "Yellow";
            }
            //start the else if for the case that yellow is the next light 
            else if (strNextLight == "Yellow")
            {
                //since yellow is next, make that box yellow
                txtYellow.BackColor = Color.Yellow;

                //make the other two boxes gray
                txtRed.BackColor = Color.DarkGray;
                txtGreen.BackColor = Color.DarkGray;

                //red always comes after yellow, so set that
                strNextLight = "Red";
            }
            //start the else if for the case that red is the next light
            else if (strNextLight == "Red")
            {
                //since red is next, make that box red
                txtRed.BackColor = Color.Red;

                //make the other two boxes gray
                txtGreen.BackColor = Color.DarkGray;
                txtYellow.BackColor = Color.DarkGray;

                //green always comes after red, so set that
                strNextLight = "Green";
            }
        }

        private void txtRed_Enter(object sender, EventArgs e)
        {
            //starting the if that will use the global variable to display the next color
            //of the stoplight in order (Green, Yellow, Red, Green, etc)
            if (strNextLight == "Green")
            {
                //since green is next, make that box green
                txtGreen.BackColor = Color.Green;

                //make the other two boxes gray
                txtRed.BackColor = Color.DarkGray;
                txtYellow.BackColor = Color.DarkGray;

                //yellow always comes after green so set that
                strNextLight = "Yellow";
            }
            //start the else if for the case that yellow is the next light 
            else if (strNextLight == "Yellow")
            {
                //since yellow is next, make that box yellow
                txtYellow.BackColor = Color.Yellow;

                //make the other two boxes gray
                txtRed.BackColor = Color.DarkGray;
                txtGreen.BackColor = Color.DarkGray;

                //red always comes after yellow, so set that
                strNextLight = "Red";
            }
            //start the else if for the case that red is the next light
            else if (strNextLight == "Red")
            {
                //since red is next, make that box red
                txtRed.BackColor = Color.Red;

                //make the other two boxes gray
                txtGreen.BackColor = Color.DarkGray;
                txtYellow.BackColor = Color.DarkGray;

                //green always comes after red, so set that
                strNextLight = "Green";
            }
        }
    }
}
