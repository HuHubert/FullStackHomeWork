using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_0602
{
    public partial class LoanMoney : Form
    {
        double loanMoney, year, interestRate, downPay;


        public LoanMoney()
        {
            InitializeComponent();
        }

        private void textLoanMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDownPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMonthPay_Click(object sender, EventArgs e)
        {

          double loanMoney = double.Parse(textLoanMoney.Text);
          double year = double.Parse(textYear.Text);
          double interestRate = double.Parse(textInterestRate.Text);
          double downPay = double.Parse(textDownPay.Text);

            //計算式 

          double payPerMonth = Financial.Pmt((interestRate/100)/12,(year*12),(loanMoney - downPay));


          double k = Math.Round((double)payPerMonth, 0);



          MessageBox.Show("每月應繳金額:" + k*-1);
          

        }

        private void btnTotalPay_Click(object sender, EventArgs e)
        {
            double loanMoney = double.Parse(textLoanMoney.Text);
            double year = double.Parse(textYear.Text);
            double interestRate = double.Parse(textInterestRate.Text);
            double downPay = double.Parse(textDownPay.Text);

            double perPayMonth;

            perPayMonth = Financial.Pmt((interestRate / 100) / 12, (year * 12), (loanMoney - downPay));

            double totalMount = Math.Round((double)perPayMonth * (double)year * 12,0);



            MessageBox.Show("總金額:" + totalMount*-1);



        }
    }
}
