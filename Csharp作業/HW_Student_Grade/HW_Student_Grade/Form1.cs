using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Student_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string result;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clssForm newStudent;

            newStudent.Name = txtName.Text;
            newStudent.Cha_point = int.Parse(txtChinese.Text);
            newStudent.En_point = int.Parse(txtEnglish.Text);
            newStudent.Ma_point = int.Parse(txtMath.Text);

            result = "姓名:" + newStudent.Name + "國文:" + newStudent.Cha_point
                + "英文:" + newStudent.En_point + "數學:" + newStudent.Ma_point +"\n";

            lablist.Text += result;
        }

        private void label1_Layout(object sender, LayoutEventArgs e)
        {
            label1.Text ="姓名:"+ " " + "國文:"+ "  " +  "英文:"+ "  " + "數學:" ;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }


        public string random_result;


        private void btnRandonSave_Click(object sender, EventArgs e)
        {

            Randomdata();


            //int name = 100, chinese = 100, math = 100, eng = 100;

            //Random random = new Random();

            //int random_name = random.Next(name);
            //int random_chinese = random.Next(chinese);
            //int random_math = random.Next(math);
            //int random_eng = random.Next(eng);

            // random_result = "姓名:" + random_name + "國文:" + random_chinese + "英文:" 
            //                 + random_eng + "數學:" + random_math + "\n";

            //lablist.Text += random_result;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lablist.Text = "";
        }

        private void btnClassSum_Click(object sender, EventArgs e)
        {

        }

        private void btnRandonAdd20_Click(object sender, EventArgs e)
        {
           


        }

 
        public void Randomdata()
        {

            int name = 100, chinese = 100, math = 100, eng = 100;

            Random random = new Random();

            int random_name = random.Next(name);
            int random_chinese = random.Next(chinese);
            int random_math = random.Next(math);
            int random_eng = random.Next(eng);

            random_result = "姓名:" + random_name + "國文:" + random_chinese + "英文:"
                            + random_eng + "數學:" + random_math + "\n";

            lablist.Text += random_result;

        }
    }
}
