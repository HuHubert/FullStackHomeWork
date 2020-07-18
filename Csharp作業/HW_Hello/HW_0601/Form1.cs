using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_0601
{
    public partial class HiCsharp : Form
    {
        public HiCsharp()
        {
            InitializeComponent();
        }

        private void HiCsharp_Load(object sender, EventArgs e)
        {

        }

        private void EngName_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Constellation_Click(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {

            string name = NameTxt.Text;
            string ena = EngNameTxt.Text;
            string gen = GenderTxt.Text;
            string constella = ConstellationTxt.Text;

            MessageBox.Show(
                "Hello , " + Environment.NewLine +
                "你好 我的名字是" + name + Environment.NewLine +
                "英文名字是" + ena + Environment.NewLine +
                "性別" + gen + Environment.NewLine +
                "星座" + constella + Environment.NewLine
                );
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSayHey_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string ena = EngNameTxt.Text;
            string gen = GenderTxt.Text;
            string constella = ConstellationTxt.Text;

            MessageBox.Show(
                "Hey , " + Environment.NewLine +
                "你好 我的名字是" + name + Environment.NewLine +
                "英文名字是" + ena + Environment.NewLine +
                "性別" + gen + Environment.NewLine +
                "星座" + constella + Environment.NewLine
                );
        }

        private void btnSayHey_Click_1(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string ena = EngNameTxt.Text;
            string gen = GenderTxt.Text;
            string constella = ConstellationTxt.Text;

            MessageBox.Show(
                "Hey , " + Environment.NewLine +
                "你好 我的名字是" + name + Environment.NewLine +
                "英文名字是" + ena + Environment.NewLine +
                "性別" + gen + Environment.NewLine +
                "星座" + constella + Environment.NewLine
                );
        }
    }
}
