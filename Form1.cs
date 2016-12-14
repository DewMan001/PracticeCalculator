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

        private void btn_Input5_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 5;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }
            else
            {
                //creating new value for displayInt
                display += "5";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input6_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 6;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }

            else
            {
                //creating new value for displayInt
                display += "5";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input7_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if (display == "0")
            {
                //creating new value for displayInt
                displayInt = 7;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }
            else
            {
                //creating new value for displayInt
                display += "7";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input8_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if (display == "0")
            {
                //creating new value for displayInt
                displayInt = 8;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }

            else
            {
                //creating new value for displayInt
                display += "8";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input9_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if (display == "0")
            {
                //creating new value for displayInt
                displayInt = 9;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }

            else
            {
                //creating new value for displayInt
                display += "9";
                lbl_Display.Text = display;
            }
        }

        private void btn_Input0_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            double displayInt = double.Parse(display);

            if(display == "0")
            {
                //creating new value for displayInt
                displayInt = 0;
                //turning that new value into a readable string
                display = displayInt.ToString();
                //putting that string back into the display label
                lbl_Display.Text = display;
            }
            else
            {
                //creating new value for displayInt
                display += "0";
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

            //an if statement from stackOverflow to delete characters
            if (display.Length > 1)
            {
                display = display.Substring(0, display.Length - 1);
            }
            else
            {
                display = "0";
            }

            lbl_Display.Text = display;
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
        }
    }
}
