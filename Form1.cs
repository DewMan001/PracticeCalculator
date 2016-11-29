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

        

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {

        }

        private void btn_Input1_Click(object sender, EventArgs e)
        {
            string display = lbl_Display.Text;
            int displayInt = Int32.Parse(display);

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
    }
}
