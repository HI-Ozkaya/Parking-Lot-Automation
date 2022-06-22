using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form3 frm3;
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
            frm3 = new Form3();
            frm1 = new Form1();
        }
        public static int doku = 0;                                            //Ekleme veya çıkarma işlemi yapılıp yapılmadığını kontrol et
        int arac=0;                                                            //Araç bilgilerini gezmek için gerekli

        private void button5_Click(object sender, EventArgs e)
        {
            if (Form1.sayac-1 <= 20)                                           //Otopark aşımını engellemek için
            {
                int dolu = 0;
                for(int i=0;i<Form1.sayac;i++)                             //Park yeri yeri seçimini engellemek için
                {
                     if(Form1.istenen[i][9] == comboBox1.Text)
                    {
                        dolu = 1;
                    }
                }
                if (dolu == 1)
                {
                    MessageBox.Show("Araç yeri dolu, araç yerleri menüsünden boş yer seçiniz.");
                }
                else                                                      //Girilen bilgileri araç dizisine at
                {
                    Form1.istenen.Add(new List<string>());
                    Form1.istenen[Form1.sayac].Add(Convert.ToString(Form1.sayac+1));
                    Form1.istenen[Form1.sayac].Add(textBox2.Text);
                    Form1.istenen[Form1.sayac].Add(textBox3.Text);
                    Form1.istenen[Form1.sayac].Add(textBox4.Text);
                    Form1.istenen[Form1.sayac].Add(textBox5.Text);
                    Form1.istenen[Form1.sayac].Add(textBox6.Text);
                    Form1.istenen[Form1.sayac].Add(textBox7.Text);
                    Form1.istenen[Form1.sayac].Add(textBox8.Text);
                    Form1.istenen[Form1.sayac].Add(textBox9.Text);
                    Form1.istenen[Form1.sayac].Add(comboBox1.Text);
                    Form1.sayac++;
                    MessageBox.Show("Araba girişi başarıyla tamamlanmıştır.");
                    doku = 1;
                    dolu = 0;
                    button1_Click(sender, e);
                    button2_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Otopark Doldu");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int hesap = 0;                                               //Verilen bilgilere göre hesaplamaları yap
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                hesap += 10;
            }
            else if (checkedListBox1.CheckedItems.Count == 2)
            {
                hesap += 20;
            }
            string sure = comboBox2.SelectedItem.ToString();
            switch (sure)
            {
                case "10 dk":
                    break;
                case "30 dk":
                    hesap += 2;
                    break;
                case "1 saat":
                    hesap += 3;
                    break;
                case "3 saat":
                    hesap += 5;
                    break;
                case "5 saat":
                    hesap += 10;
                    break;
                case "10 saat":
                    hesap += 15;
                    break;
                case "1 gün":
                    hesap += 25;
                    break;
            }
            if (hesap == 0)
            {
                MessageBox.Show("Ücretsiz");
            }
            else
            {
                MessageBox.Show(textBox6.Text + " " + hesap + " TL ödeme için teşekkür ederiz." + "\n" + "Yine bekleriz. Güle güle.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {                                                          //Araç seçme yerini ayarla(görünenden zor)
            arac = 0;
            textBox1.Text = "0 / " + Form1.sayac;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkedListBox1.SetItemChecked(1,false);
            checkedListBox1.SetItemChecked(0, false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.sayac == 0)
            {
                
            }
            else
            {
                arac -= 1;
                if (arac<=0)
                {
                    arac = 0;
                    textBox1.Text = arac + " / " + Form1.sayac;
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    checkedListBox1.SetItemChecked(1, false);
                    checkedListBox1.SetItemChecked(0, false);
                }
                else
                {
                    textBox1.Text = arac + " / " + Form1.sayac;
                    textBox2.Text = Form1.istenen[arac-1][1];
                    textBox3.Text = Form1.istenen[arac-1][2];
                    textBox4.Text = Form1.istenen[arac-1][3];
                    textBox5.Text = Form1.istenen[arac-1][4];
                    textBox6.Text = Form1.istenen[arac-1][5];
                    textBox7.Text = Form1.istenen[arac-1][6];
                    textBox8.Text = Form1.istenen[arac-1][7];
                    textBox9.Text = Form1.istenen[arac-1][8];
                    comboBox1.Text = Form1.istenen[arac-1][9];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.sayac == 0)
            {

            }
            else
            {
                if(arac==Form1.sayac)
                {

                }
                else
                {
                    arac += 1;
                    textBox1.Text = arac + " / " + Form1.sayac;
                    textBox2.Text = Form1.istenen[arac-1][1];
                    textBox3.Text = Form1.istenen[arac-1][2];
                    textBox4.Text = Form1.istenen[arac-1][3];
                    textBox5.Text = Form1.istenen[arac-1][4];
                    textBox6.Text = Form1.istenen[arac-1][5];
                    textBox7.Text = Form1.istenen[arac-1][6];
                    textBox8.Text = Form1.istenen[arac-1][7];
                    textBox9.Text = Form1.istenen[arac-1][8];
                    comboBox1.Text = Form1.istenen[arac-1][9];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arac = Form1.sayac;
            if (Form1.sayac == 0)
            {

            }
            else
            {
                textBox1.Text = arac + " / " + Form1.sayac;
                textBox2.Text = Form1.istenen[arac-1][1];
                textBox3.Text = Form1.istenen[arac-1][2];
                textBox4.Text = Form1.istenen[arac-1][3];
                textBox5.Text = Form1.istenen[arac-1][4];
                textBox6.Text = Form1.istenen[arac-1][5];
                textBox7.Text = Form1.istenen[arac-1][6];
                textBox8.Text = Form1.istenen[arac-1][7];
                textBox9.Text = Form1.istenen[arac-1][8];
                comboBox1.Text = Form1.istenen[arac-1][9];
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0 / " + Form1.sayac;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text==null)                        
            {
                MessageBox.Show("Lütfen araba yeri seçiniz.");
            }
            else                                                   //Seçilen arabayı listeden kaldırma ve gerekli kontroller
            {
                int bilgi = 0;
                for(int i=0;i<Form1.sayac;i++)
                {
                    if(comboBox1.Text == Form1.istenen[i][9])
                    {
                        Form1.istenen.RemoveAt(i);
                        Form1.sayac--;
                        bilgi = 1;
                        doku = 1;
                        MessageBox.Show("Araba çıkışı başarıyla tamamlanmıştır.");
                        button1_Click(sender, e);
                        button2_Click(sender, e);
                    }
                }
                if(bilgi==0)
                {
                    MessageBox.Show("Bu araba park yerinde yok.");
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Text = "0 / " + Form1.sayac;
        }
    }
}