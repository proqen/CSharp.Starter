using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonRemainderOfDivision_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            Operation operation  = new Operation();

            if (radioButton3.Checked == true)
            {
                textBox3.Text = operation.Concat(textBox1.Text, textBox2.Text);
            }
            else if(radioButton2.Checked == true)
            {
                textBox3.Text = operation.Exponentiation(textBox1.Text, textBox2.Text);
            }
            else if (radioButton4.Checked == true)
            {
                textBox3.Text = operation.Division(textBox1.Text, textBox2.Text);
            }
            else if (radioButton1.Checked == true)
            {
                textBox3.Text = operation.RemindOfDivision(textBox1.Text, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Не выбрана операция");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonExponentiation_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void radioButtonConcat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDivision_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {   

        }
    }
}
