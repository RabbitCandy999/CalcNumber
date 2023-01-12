using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcNumber
{
    public partial class MainForm : Form
    {
        private int Index_Problem;
        private int NumberA, NumberB, NumberResult, OperatorOfNumber;
        private int Score, RangeNumber, AnswerCount, ExitSign;
        Random random;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitSign == 0)
            {
                MessageBox.Show("不要放弃，放弃就点击交卷即可！");
                e.Cancel = true;
            }
        }

        private void CreateProblem()
        {
            AnswerCount = 0;
            Index_Problem++;
            btn_Next.Enabled = false;
            btn_Result.Enabled = true;
            txb_Result.Enabled = true;
            lab_TextIndex.Text = "第" + Index_Problem.ToString() + "题";
            RangeNumber = (int)(Math.Pow(2, (double)Index_Problem * 31 / 15) / 2);
            OperatorOfNumber = random.Next(1, 5);

            switch (OperatorOfNumber)
            {
                case 1:
                    NumberA = random.Next(1, RangeNumber);
                    NumberB = random.Next(1, RangeNumber);
                    NumberResult = NumberA + NumberB;
                    lab_TextProblem.Text = "计算：" + NumberA.ToString() + "＋" + NumberB.ToString();
                    break;
                case 2:
                    NumberA = random.Next(1, RangeNumber);
                    NumberB = random.Next(1, RangeNumber);
                    if(NumberA < NumberB)
                        (NumberB, NumberA) = (NumberA, NumberB);     
                    NumberResult = NumberA - NumberB;
                    lab_TextProblem.Text = "计算：" + NumberA.ToString() + "－" + NumberB.ToString();
                    break;
                case 3:
                    RangeNumber = (int)Math.Sqrt(RangeNumber);
                    NumberA = random.Next(1, RangeNumber);
                    NumberB = random.Next(1, RangeNumber);
                    NumberResult = NumberA * NumberB;
                    lab_TextProblem.Text = "计算：" + NumberA.ToString() + "×" + NumberB.ToString();
                    break;
                case 4:
                    RangeNumber = (int)Math.Sqrt(RangeNumber);
                    NumberA = random.Next(1, RangeNumber);
                    NumberB = random.Next(1, RangeNumber);
                    NumberResult = NumberA * NumberB;
                    (NumberA, NumberResult) = (NumberResult, NumberA);
                    lab_TextProblem.Text = "计算：" + NumberA.ToString() + "÷" + NumberB.ToString();
                    break;

            }
            btn_Next.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            random = new Random();
            Index_Problem = 0;
            ExitSign = 0;
            CreateProblem();

            MessageBox.Show("小学二年级计算题！\n让他来测试你的IQ有多少吧！\n一共15道题！");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Index_Problem < 15)
            {
                txb_Result.Text = "";
                lab_Result.Text = "";
                CreateProblem();
            }
            else
            {
                MessageBox.Show("考试结束，你得了" + Score.ToString() + "分\n把这个对话框截图给你的好朋友，让你的朋友看看你有多厉害吧！");
                ExitSign = 1;
                Application.Exit();
            }
        }


        private void btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerCount++;
                if (int.Parse(txb_Result.Text) == NumberResult)
                {
                    lab_Result.Text = "回答正确！";
                    txb_Result.Enabled = false;
                    btn_Result.Enabled = false;
                    btn_Next.Enabled = true;

                    switch (AnswerCount)
                    {
                        case 1:
                            Score += 10;
                            break;
                        case 2:
                            Score += 5;
                            break;
                        case 3:
                            Score += 3;
                            break;
                    }

                    lab_Score.Text = "得分：" + Score.ToString();
                }
                else
                {
                    if (AnswerCount >= 3)
                    {
                        lab_Result.Text = "错误！你没有作答机会了！";
                        txb_Result.Enabled = false;
                        btn_Result.Enabled = false;
                        btn_Next.Enabled = true;
                    }
                    else
                    {
                        lab_Result.Text = "错误！还有" + (3 - AnswerCount).ToString() + "次作答机会！";
                        txb_Result.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入合法的数据！");
            }
        }

        private void btn_GiveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("考试结束，你得了" + Score.ToString() + "分\n把这个对话框截图给你的好朋友，让你的朋友看看你有多厉害吧！");
            ExitSign = 1;
            Application.Exit();
        }
    }
}
