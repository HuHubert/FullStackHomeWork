using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Student_StructFrom
{
    public partial class StuStrFrom : Form
    {
        public StuStrFrom()
        {
            InitializeComponent();
        }
        string result;
        private void btnSave_Click(object sender, EventArgs e)
        {
            clssForm newStudent;

            newStudent.Name = txtName.Text;
            newStudent.Cha_point = int.Parse(txtCh.Text);
            newStudent.En_point = int.Parse(txtEn.Text);
            newStudent.Ma_point = int.Parse(txtMa.Text);
      
            result = "姓名:" + newStudent.Name + "國文:" + newStudent.Cha_point + "英文:" + newStudent.En_point + "數學:" + newStudent.Ma_point;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labelist.Text = result;
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            int c_num = int.Parse(txtCh.Text);
            int m_num = int.Parse(txtMa.Text);
            int e_num = int.Parse(txtEn.Text);

            if (c_num > m_num && c_num > e_num && m_num > e_num)
            {
                labEst.Text = "最高分是國文:" + c_num + "最低分是英文:" + e_num;

            }

            if (c_num > m_num && c_num > e_num && e_num > m_num)
            {
                labEst.Text = "最高分是國文:" + c_num + "最低分是數學:" + m_num;

            }


            if (m_num > c_num && m_num > e_num && c_num > e_num)
            {
                labEst.Text = "最高分是數學:" + m_num + "最低分是英文:" + e_num;

            }

            if (m_num > c_num && m_num > e_num && e_num > c_num)
            {
                labEst.Text = "最高分是數學:" + m_num + "最低分是國文:" + c_num;

            }

            if (e_num > c_num && e_num > m_num && c_num > m_num)
            {
                labEst.Text = "最高分是英文:" + e_num + "最低分是數學:" + m_num;

            }

            if (e_num > c_num && e_num > m_num && m_num > c_num)
            {
                labEst.Text = "最高分是英文:" + e_num + "最低分是國文:" + c_num;

            }

        }

        private void labEst_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
