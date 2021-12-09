using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public enum Caluculatiomn
        {
            nomal,
            plus,
            minus,
            times,
            divi
        }
        public bool setNum = false;
        public bool setNum2 = false;
        public bool subSet_Num = false;
        public string str = null;
        public string str2 = null;
        public string str3 = null;
        Caluculatiomn cal = Caluculatiomn.nomal;
        public Form1()
        {
            InitializeComponent();
        }

        private void subset_num2()
        {
            if(subSet_Num)
            {
                str = str3;
                str2 = null;
            }
        }
        private void Set_num1(string str1,string str2)
        {
            double num = double.Parse(str);
            double num2 = double.Parse(str2);
            double ans;
            switch (cal)
            {
                case Caluculatiomn.plus:
                    ans = num + num2;
                    textBox1.Text = ans.ToString();
                    str = ans.ToString();
                    str3 = ans.ToString();
                    break;
                case Caluculatiomn.minus:
                    ans = num - num2;
                    textBox1.Text = ans.ToString();
                    str = ans.ToString();
                    str3 = ans.ToString();
                    break;
                case Caluculatiomn.times:
                    ans = num * num2;
                    textBox1.Text = ans.ToString();
                    str = ans.ToString();
                    str3 = ans.ToString();
                    break;
                case Caluculatiomn.divi:
                    ans = num / num2;
                    textBox1.Text = ans.ToString();
                    str = ans.ToString();
                    str3 = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        private void Set_Num2(string str)
        {
            textBox2.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "1";
                Set_Num2(str);
                setNum2 = true;
            }
            else
            {
                subset_num2();
                str2+="1";
                Set_Num2(str2);
                setNum2 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "2";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "2";
                Set_Num2(str2);
                setNum2 = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "3";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "3";
                Set_Num2(str2);
                setNum2 = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "4";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "4";
                Set_Num2(str2);
                setNum2 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "5";
                Set_Num2(str);
                setNum2 = true;
            }
            else
            {
                subset_num2();
                str2 += "5";
                Set_Num2(str2);
                setNum2 = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "6";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "6";
                Set_Num2(str2);
                setNum2 = true;

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "7";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "7";
                Set_Num2(str2);
                setNum2 = true;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "8";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "8";
                Set_Num2(str2);
                setNum2 = true;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (!setNum)
            {
                str += "9";
                Set_Num2(str);
                setNum2 = true;

            }
            else
            {
                subset_num2();
                str2 += "9";
                Set_Num2(str2);
                setNum2 = true;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cal = Caluculatiomn.plus;
            setNum = true;
            setNum2 = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cal = Caluculatiomn.minus;
            setNum = true;
            setNum2 = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cal = Caluculatiomn.times;
            setNum = true;
            setNum2 = false;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            cal = Caluculatiomn.divi;
            setNum = true;
            setNum2 = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Set_num1(str,str2);
            subSet_Num = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            str = null;
            str2 = null;
            cal = Caluculatiomn.nomal;
            setNum = false;
            setNum2 = false;
            subSet_Num = false;
            textBox1.Text = "0";
            textBox2.Text = "0";

        }
        private void button_Click16(object sender, EventArgs e)
        {

            if (!setNum)
            {
                if (setNum2) 
                { 
                    str += "0";
                    Set_Num2(str);
                }
            }
            else
            {
                if (setNum2)
                {
                    str2 += "0";
                    Set_Num2(str2);
                }
            }
        }
    }
}
