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
            labelShowResult.Text = "";
            int[,] arrs = new int[10, 10]
            {
                {0,0,0,0,0,0,0,0,0,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,0},
                {0,0,0,0,0,0,0,0,0,0},
            };
            for (int i = 0; i < arrs.GetLength(0); i++)
            {
                for (int j = 0; j < arrs.GetLength(1); j++)
                {
                    labelShowResult.Text += arrs[i, j] + " ";
                }
                labelShowResult.Text += Environment.NewLine;
            }



        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            labelShowResult.Text = $"換位前 n1={n1} , n2={n2}\n";
            int t;
            t = n1;
            n1 = n2;
            n2 = t;
            labelShowResult.Text += $"換位後 n1={n1} , n2={n2}";
        }

        private void btnO0i1_Click(object sender, EventArgs e)
        {
            labelShowResult.Text = "";
            int[,] arrs = new int[10, 10]
            {
                {1,1,1,1,1,1,1,1,1,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,1,1,1,1,1,1,1,1,1},
            };
            for (int i = 0; i < arrs.GetLength(0); i++)
            {
                for (int j = 0; j < arrs.GetLength(1); j++)
                {
                    labelShowResult.Text += arrs[i, j] + " ";
                }
                labelShowResult.Text += Environment.NewLine;
            }
        }

        private void btn1010_Click(object sender, EventArgs e)
        {
            labelShowResult.Text = "";
            int[,] arrs = new int[10, 10]
            {
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1},
            };
            for (int i = 0; i < arrs.GetLength(0); i++)
            {
                for (int j = 0; j < arrs.GetLength(1); j++)
                {
                    labelShowResult.Text += arrs[i, j] + " ";
                }
                labelShowResult.Text += Environment.NewLine;
            }
        }

        private void btnLongLong_Click(object sender, EventArgs e)
        {
            string[] longLongName = {"(瓊恩·雪諾)", "(泰溫·蘭尼斯特)", "(喬佛里·拜拉席恩)", "(雷姆西‧波頓)", "(風暴降生的" +
                    "不焚者,彌林女王,安達爾人,羅伊那人和先民的女王龍媽丹尼莉絲)" };
            int n = 0;
            int len = longLongName[0].Length;
            for (int i = 1; i < longLongName.Length; i++)
            {
                if (longLongName[i].Length > len)
                {
                    n = i;
                    len = longLongName[i].Length;

                }
                labelShowResult.Text = "名單有: " + "瓊恩·雪諾" +" " + "泰溫·蘭尼斯特" + " " + "喬佛里·拜拉席恩" + " " + "雷姆西‧波頓" + " " + "風暴降生的" +
                          "不焚者,彌林女王,安達爾人,羅伊那人和先民的女王龍媽丹尼莉絲" + "\n" +
                      "最長的名字為: " + longLongName[n]; ;

            }
        }

        private void btnCc_Click(object sender, EventArgs e)
        {

        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            int[] a = { 5, 10, 15, 20, 25};
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x += a[i];
            }
            labelShowResult.Text = "5, 10, 15, 20, 25" +"   Total Sum:" + x;
        }

        private void btnArrayMax_Click(object sender, EventArgs e)
        {
            int[] a = { 5, 10, 15, 20, 25 };

            int x = a.Max();

            labelShowResult.Text = "5, 10, 15, 20, 25" + " 最大值:" + x;
        }

        private void btnArrayMin_Click(object sender, EventArgs e)
        {
            int[] a = { 5, 10, 15, 20, 25 };

            int x = a.Min();

            labelShowResult.Text = "5, 10, 15, 20, 25" + " 最小值:" + x;
        }
    }
}
