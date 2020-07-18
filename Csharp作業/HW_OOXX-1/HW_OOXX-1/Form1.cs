using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_OOXX_1
{
    public partial class Form1 : Form
    {
        private bool btnInt = true;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            if (btnInt)
            {
                button1.Enabled = false;
                button1.Image = Properties.Resources.kangaroo;
                button1.Text = "0";
                btnInt = false;
            }
            else
            {
                button1.Enabled = false;
                button1.Image = Properties.Resources.koala;
                button1.Text = "X";
                btnInt = true;
            }
            winlose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button2.Enabled = false;
                button2.Text = "O";
                button2.Image = Properties.Resources.kangaroo;
                btnInt = false;
            }
            else
            {
                button2.Enabled = false;
                button2.Text = "X";
                button2.Image = Properties.Resources.koala;
                btnInt = true;
            }
            winlose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button3.Enabled = false;
                button3.Text = "O";
                button3.Image = Properties.Resources.kangaroo;
                btnInt = false;
            }
            else
            {
                button3.Enabled = false;
                button3.Text = "X";
                button3.Image = Properties.Resources.koala;
                btnInt = true;
            }
            winlose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button4.Enabled = false;
                button4.Image = Properties.Resources.kangaroo;
                button4.Text = "O";
                btnInt = false;
            }
            else
            {
                button4.Enabled = false;
                button4.Text = "X";
                button4.Image = Properties.Resources.koala;
                btnInt = true;
            }
            winlose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button5.Enabled = false;
                button5.Image = Properties.Resources.kangaroo;
                btnInt = false;
                button5.Text = "0";

            }
            else
            {
                button5.Enabled = false;
                button5.Image = Properties.Resources.koala;
                btnInt = true;
                button5.Text = "X";

            }
            winlose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button6.Enabled = false;
                button6.Image = Properties.Resources.kangaroo;
                btnInt = false;
                button6.Text = "0";

            }
            else
            {
                button6.Enabled = false;
                button6.Image = Properties.Resources.koala;
                btnInt = true;
                button6.Text = "X";

            }
            winlose();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button7.Enabled = false;
                button7.Image = Properties.Resources.kangaroo;
                button7.Text = "0";
                btnInt = false;
            }
            else
            {
                button7.Enabled = false;
                button7.Image = Properties.Resources.koala;
                button7.Text = "X";
                btnInt = true;
            }
            winlose();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button8.Enabled = false;
                button8.Image = Properties.Resources.kangaroo;
                btnInt = false;
                button8.Text = "0";
            }
            else
            {
                button8.Enabled = false;
                button8.Image = Properties.Resources.koala;
                btnInt = true;
                button8.Text = "X";
            }
            winlose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btnInt)
            {
                button9.Enabled = false;
                button9.Image = Properties.Resources.kangaroo;
                btnInt = false;
                button9.Text = "0";
            }
            else
            {
                button9.Enabled = false;
                button9.Image = Properties.Resources.koala;
                btnInt = true;
                button9.Text = "X";
            }
            winlose();
        }

        public void winlose()
        {

            if (
                (button1.Text == "0" && button2.Text == "0" && button3.Text == "0") ||
                (button4.Text == "0" && button5.Text == "0" && button6.Text == "0") ||
                (button7.Text == "0" && button8.Text == "0" && button9.Text == "0") ||
                (button1.Text == "0" && button4.Text == "0" && button7.Text == "0") ||
                (button2.Text == "0" && button5.Text == "0" && button8.Text == "0") ||
                (button3.Text == "0" && button6.Text == "0" && button9.Text == "0") ||
                (button1.Text == "0" && button5.Text == "0" && button9.Text == "0") ||
                (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
                )

            {
                MessageBox.Show("袋鼠贏了!");

                btnInt = true;
            }




            //if (
            //    (button1.Image == Properties.Resources.kangaroo &&
            //     button2.Image == Properties.Resources.kangaroo &&
            //     button3.Image == Properties.Resources.kangaroo) ||

            //  (button4.Image == Properties.Resources.kangaroo &&
            //  button5.Image == Properties.Resources.kangaroo &&
            //  button6.Image == Properties.Resources.kangaroo ) ||

            //  (button7.Image == Properties.Resources.kangaroo &&
            //  button8.Image == Properties.Resources.kangaroo &&
            //  button9.Image == Properties.Resources.kangaroo)||

            //  (button1.Image == Properties.Resources.kangaroo &&
            //  button4.Image == Properties.Resources.kangaroo &&
            //  button7.Image == Properties.Resources.kangaroo)||

            //  (button2.Image == Properties.Resources.kangaroo &&
            //  button5.Image == Properties.Resources.kangaroo &&
            //  button8.Image == Properties.Resources.kangaroo)||

            //  (button3.Image == Properties.Resources.kangaroo &&
            //  button6.Image == Properties.Resources.kangaroo &&
            //  button9.Image == Properties.Resources.kangaroo)||

            //  (button1.Image == Properties.Resources.kangaroo &&
            //  button5.Image == Properties.Resources.kangaroo &&
            //  button9.Image == Properties.Resources.kangaroo)||

            //  (button3.Image == Properties.Resources.kangaroo &&
            //  button5.Image == Properties.Resources.kangaroo &&
            //  button7.Image == Properties.Resources.kangaroo))

            //{
            //    MessageBox.Show("袋鼠贏了!");

            //     btnInt= true;


            else if (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                )

            {
                MessageBox.Show("尾熊贏了!");

                btnInt = true;
            }



        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < length; i++)
            //{

            //}

            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            button1.Enabled = true; 
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;



        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
