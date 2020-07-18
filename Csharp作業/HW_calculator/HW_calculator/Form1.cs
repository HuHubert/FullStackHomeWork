using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            String num1, num2;
            float flnum;
            num1 = txtNum1.Text;
            float flnum1 = float.Parse(num1);
            num2 = txtNum2.Text;
            float flnum2 = float.Parse(num2);
            flnum = flnum1 - flnum2;
            labResult.Text = flnum.ToString();

        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            String num1, num2;
            float flnum;
            num1 = txtNum1.Text;
            float flnum1 = float.Parse(num1);
            num2 = txtNum2.Text;
            float flnum2 = float.Parse(num2);
            flnum = flnum1 * flnum2;
            labResult.Text = flnum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String num1, num2;
            float flnum;
            num1 = txtNum1.Text;
            float flnum1 = float.Parse(num1);
            num2 = txtNum2.Text;
            float flnum2 = float.Parse(num2);
            flnum = flnum1 / flnum2;
            labResult.Text = flnum.ToString();
        }
    }
}
