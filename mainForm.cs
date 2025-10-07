using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class main1 : Form
    {
        

        public main1()
        {
            InitializeComponent();
        }

        public brain brainVar  = new brain();

        private void oneButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 1.ToString();
            brainVar.oneClick();
        }

        private void twoButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 2.ToString();
            brainVar.twoClick();
        }

        private void threeButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 3.ToString();
            brainVar.threeClick();
        }

        private void fourButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 4.ToString();
            brainVar.fourClick();
        }

        private void fiveButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 5.ToString();
            brainVar.fiveClick();
        }

        private void sixButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 6.ToString();
            brainVar.sixClick();
        }

        private void sevenButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 7.ToString();
            brainVar.sevenClick();
        }

        private void eightButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 8.ToString();
            brainVar.eightClick();
        }

        private void nineButt_Click(object sender, EventArgs e)
        {
            clearEqual();

            displayTxt.Text += 9.ToString();
            brainVar.nineClick();
        }

        private void zeroButt_Click(object sender, EventArgs e)
        {
            
            clearEqual();

            displayTxt.Text += 0.ToString();
            brainVar.zeroClick();
        }


        //-----------> equals button <-------------
        private void EqualButt(object sender, EventArgs e)
        {
            
            displayTxt.Text = brainVar.eqlClick();
        }
               

        private void plusButt_Click(object sender, EventArgs e)
        {
            displayTxt.Text += "+";
            brainVar.plusClick();

        }
        public void clearEqual()
        {
            if (brainVar.afterEqual == true)
            {
                displayTxt.Clear();
                brainVar.afterEqual = false;
            }
        }








        private void main1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Calculator!");
        }
    }
}
