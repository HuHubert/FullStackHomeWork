using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_0603
{
    public partial class BarForm : Form
    {

        int budda = 0,hammer = 0, ear=0, gun=0;


        public int budda_price = 300, hammer_price = 330, ear_price = 280, gun_price = 777;

        public int total_price = 0;

        public BarForm()
        {
            InitializeComponent();
        }

     

        private void btnBudda_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            budda = budda +1;
            budda_price ++;
            total_price = total_price +budda_price;
            labelList.Text += "遇見佛陀" + budda +"杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void btnBuddaReduce_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            budda = budda -1;
            budda_price--;
            total_price = total_price - budda_price;
            labelList.Text += "遇見佛陀" + budda + "杯杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void btnHammer_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            hammer = hammer +1;
            hammer_price++;
            total_price = total_price + hammer_price;
            labelList.Text += "人民的法槌" + hammer + "杯杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void btnHammerReduce_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            hammer = hammer -1;
            hammer_price--;
            total_price = total_price - hammer_price;
            labelList.Text += "人民的法槌" + hammer + "杯杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

       

        private void btnEar_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            ear = ear +1;
            ear_price++;
            total_price = total_price + ear_price;
            labelList.Text += "梵谷的耳朵" + ear + "杯杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void btnEarReduce_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            ear = ear-1;
            ear_price--;
            total_price = total_price + ear_price;
            labelList.Text += "梵谷的耳朵" + ear + "杯杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            gun = gun +1;
            gun_price++;
            total_price = total_price + gun_price;
            labelList.Text += "約翰藍儂的槍" + gun + "杯杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void btnGunReduce_Click(object sender, EventArgs e)
        {
            labelList.Text = " ";
            gun = gun-1;
            gun_price++;
            total_price = total_price + gun_price;
            labelList.Text += "約翰藍儂的槍" + gun + "杯\r\n";
            labTotalPrice.Text = total_price.ToString();
        }

        private void labelList_Click(object sender, EventArgs e)
        {
            
        }

        private void labTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額"+total_price);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            decimal credit_price = Math.Round(total_price*(decimal)9/10,0);
            MessageBox.Show("刷卡優惠"+ credit_price);
        }
    }
}
