using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void btn_Input1_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 1;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }
            else
            {
                display += "1";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input2_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 2;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }
            else
            {
                display += "2";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input3_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 3;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }

            else
            {
                //creating new value for displayInt
                display += "3";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input4_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 4;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }
            else
            {
                //creating new value for displayInt
                display += "4";
                lbl_Display.Text = display;
            }
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;

            display = "0";

            lbl_Display.Text = display;
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {

        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;

            display += "\b";

            lbl_Display.Text = display;
        }

       
    }
}
