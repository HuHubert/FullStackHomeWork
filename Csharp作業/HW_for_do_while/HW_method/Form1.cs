using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[] { 69, 64, 07, 11, 17, 24 };

        private void btnMaxMin_Click(object sender, EventArgs e)
        {

            //int[] array = new int[] { 69, 64, 07, 11, 17, 24 };

            Array.Sort(array);

            labelShowResult.Text = "陣列" + "{ 69, 64, 07, 11, 17, 24 }" + "\n"
            + "陣列最小值:" + array[0] + "\n"
            + "陣列最大值" + array[array.Length - 1];
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {


            int odd = 0;

            int even = 0;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

            }

            labelShowResult.Text = "陣列" + "{ 69, 64, 07, 11, 17, 24 }" + "\n"
            + "陣列中奇數共:" + odd.ToString() + "\n"
            + "陣列中偶數共:" + even.ToString();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumberInput.Text);

            if (number % 2 == 0)
            {
                MessageBox.Show("輸入數字是偶數");

            }

            else
            {
                MessageBox.Show("輸入數字是奇數");
            };

        }

        private void btnO1i0_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];
            int[,] A = new int[,] { };

            string result = "";


            for (int x = 0; x < matrix.Length; x++)
            {
                for (int y = 0; y < matrix.Length; y++)
                {
                    x += 1;
                    y += 1;
                }


            }

        }

        private void btnXmas_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtXmas.Text);
            string output = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 1; j--) output += "*";
                for (int k = 1; k <= n - i; k++)
                    output += " ";
                output += "\n";
            }

            labelShowResult.Text = output;
        }

        private void btnBinery100_Click(object sender, EventArgs e)
        {
            labelShowResult.Text = Convert.ToString(100, 2);
        }

        private void btnLoterry_Click(object sender, EventArgs e)
        {
            int[] lottery = new int[6];

            Random rlo = new Random();
            for (int i = 0; i < 6; i++)
            {
                //隨機產生1~49
                lottery[i] = rlo.Next(1, 100);

                for (int j = 0; j < i; j++)
                {
                    //檢查號碼是否重複
                    while (lottery[j] == lottery[i])
                    {
                        j = 0;
                        //重新產生，存回陣列，亂數產生的範圍是1~49
                        lottery[i] = rlo.Next(1, 100);
                    }
                }
                labelShowResult.Text = lottery[0].ToString() + " " + lottery[1].ToString() + " "
                    + lottery[2].ToString() + " " + lottery[3].ToString() + " "
                    + lottery[4].ToString() + " " + lottery[5].ToString();


            }



        }

        private void btn99_Click(object sender, EventArgs e)
        {
            labelShowResult.Text = "";
            for (int i = 1; i <= 9; i++)
            {

                for (int j = 1; j <= 9; j++)
                {

                    labelShowResult.Text += i.ToString() + "*" +""+ j.ToString() + "=" + Convert.ToString(i * j) + "  ";

                }
                labelShowResult.Text += Environment.NewLine;

            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int k = 9, j = 10;
            labelShowResult.Text = $"換位前 k={k} , j={j}\n";
            int temp;
            temp = k;
            k = j;
            j = temp;
            labelShowResult.Text += $"換位後 k={k} , j={j}";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] arr = { 7, 17, 11, 24,  99, 66 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            labelShowResult.Text = $"陣列arr[ 7, 17, 11, 24,  99, 66 ]\n加總為{sum}";
        }

        private void btnArrMax_Click(object sender, EventArgs e)
        {
            int[] arr = { 7, 17, 11, 24, 99, 66 };
            int max = arr.Max();
            labelShowResult.Text = $"陣列arr[ 7,17, 11, 24,  99, 66 ]\n最大值為{max}";
        }

        private void btnArrMIn_Click(object sender, EventArgs e)
        {
            int[] arr = { 7, 17, 11, 24, 99, 66 };
            int max = arr.Min();
            labelShowResult.Text = $"陣列arr[ 7,17, 11, 24,  99, 66 ]\n最小值為{min}"
        }
    }
}
