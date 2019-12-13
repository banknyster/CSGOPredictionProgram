using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CSGO
{
   
    public partial class CSGOPrediction : Form
    {
        double[] bettingOdds = new double[10];
        string teamName;
        
        public CSGOPrediction()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox1.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[0] = checker.castToDouble();   
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox1.Text = "";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox2.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[1] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox2.Text = "";
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox3.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[2] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox3.Text = "";
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox4.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[3] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox4.Text = "";
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox5.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[4] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox5.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox6.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[5] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox6.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox7.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[6] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox7.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox8.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[7] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox8.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox9.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[8] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox9.Text = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ErrorChecker checker = new ErrorChecker(textBox10.Text);
            if (checker.getCountDot() < 2)
            {
                bettingOdds[9] = checker.castToDouble();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error");
                textBox10.Text = "";
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            teamName = textBox11.Text;
        }


        private void PictureBox13_Click(object sender, EventArgs e)
        {
            TreeModel dt = new TreeModel(bettingOdds);
            dt.startSearch();

            textBox12.Text = dt.getResult();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
 
}
