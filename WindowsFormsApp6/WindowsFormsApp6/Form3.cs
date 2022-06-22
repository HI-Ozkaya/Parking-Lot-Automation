using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i=0;i<Form1.sayac;i++)                           //Araç listesindeki verilere göre sayfa yüklendiğinde
            {                                                        //butonları renklendir
                if (Form1.istenen[i][9] == "A1")
                {
                    button5.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "A2")
                {
                    button4.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "A3")
                {
                    button3.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "A4")
                {
                    button2.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "A5")
                {
                    button1.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "B1")
                {
                    button10.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "B2")
                {
                    button9.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "B3")
                {
                    button8.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "B4")
                {
                    button7.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "B5")
                {
                    button6.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "C1")
                {
                    button19.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "C2")
                {
                    button17.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "C3")
                {
                    button15.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "C4")
                {
                    button13.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "C5")
                {
                    button11.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "D1")
                {
                    button20.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "D2")
                {
                    button18.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "D3")
                {
                    button16.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "D4")
                {
                    button14.BackColor = Color.Red;
                }
                if (Form1.istenen[i][9] == "D5")
                {
                    button12.BackColor = Color.Red;
                }
            }
        }
    }
}
