using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int N;
            string[] Q = new string[90];
            string[] F = new string[90];
            for (int i = 0; i < Q.Length; i++)
            {
                Q[i] = textBox1.Text;


                if (Q[i] == ",")
                {
                    F[i] = Q[i - 1];

                }
            }
                for (int i = 0; i < F.Length; i++)
                {
                    textBox2.Text = F[i];
                }
                */
            int a = 0;
            int sum = 0;
            double sma;
            var Digits = textBox1.Text.Split(' ');
            int[] Data = new int[Digits.Length];
            for(int i=0; i<Digits.Length; i++)
            {

                sum = int.Parse(Digits[i]) + sum;
                a++;
            }
            sma = sum / a;

            /*char[] Q = new char[10];
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                Q[i] = textBox1.Text[i];

            }

            string z;
            double sum=0;
            double y;
            string sma;
            for (int i = 0; i <= 9; i++)
            {
                
                sum=Q[i]+sum;
            }
            /*double x1 = Convert.ToDouble(Q[i]);
            double x2 = Convert.ToDouble(textBox2.Text);
            double x3 = Convert.ToDouble(textBox3.Text);
            double x4 = Convert.ToDouble(textBox4.Text);
            sum = x1 + x2 + x3 + x4;*/
            string y;
            y = Convert.ToString(sma);
            textBox2.Text = y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Фільтр з середнім ковзаючим";
            button1.Text = "Пуск";
            linkLabel1.Text = "Автори";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Simple moving avarage filter";
            button1.Text = "Start";
            linkLabel1.Text = "Autors";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Студенти:" + "\r\n" +
                "Мільке Денис, Поляков Євген, Мелешко Сергій" + "\r\n" +
                "Група СЕ-307а" + "\r\n" +
                "Кафедра електроніки" + "\r\n" +
                "ННІАЕТ" + "\r\n" +
                "НАУ" + "\r\n" +
                "Україна, Київ",
                "Реквізити авторів:",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}

