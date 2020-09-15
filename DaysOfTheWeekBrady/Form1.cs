using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Days of the Week
* Author      : Kabrina Brady
* Created     : 9/15/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User enters a number between 1-7 and corresponding day of the week is displayed (i.e. 1=Monday)
*               Input:  Clicks, and what user enters into TextBox
*               Output: Day of the week
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/


namespace DaysOfTheWeekBrady
{
    public partial class DaysOfTheWeekForm : Form
    {
        public DaysOfTheWeekForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
                int number; //variable that will hold TextBox input
                if (int.TryParse(txtInput.Text, out number)) //converts string to int if int entered
                {
                    if (number >= 1 && number <= 7) //ensures number is between 1 and 7
                    {
                        switch (number)
                        {
                        //if number is 1, text = Monday. If 2, Tuesday, etc.
                            case 1: 
                                lblOutput.Text = "Monday";
                                break;

                            case 2:
                                lblOutput.Text = "Tuesday";
                                break;

                            case 3:
                                lblOutput.Text = "Wednesday";
                                break;

                            case 4:
                                lblOutput.Text = "Thursday";
                                break;

                            case 5:
                                lblOutput.Text = "Friday";
                                break;

                            case 6:
                                lblOutput.Text = "Saturday";
                                break;

                            case 7:
                                lblOutput.Text = "Sunday";
                                break;
                        }
                    }
                }
            if (!(number >= 1 && number <= 7))
            {
                MessageBox.Show("Enter a number between 1 and 7."); //tells user to enter a number if TextBox contains something it's not supposed to, like a string
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }
    }
}
