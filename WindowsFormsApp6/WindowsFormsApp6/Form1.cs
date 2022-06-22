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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<List<string>> istenen = new List<List<string>>();             //Araç bilgilerinin tutulduğu dizi (diğer formlarda kullanılabilir)
        public static int sayac;                                                         //Araç sayısı bilgisi
        public static int oku = 0;                                                       //Dosya okuma bilgisi                               
        private void button5_Click(object sender, EventArgs e)                           //Programdan çıkış
        {
            MessageBox.Show("Güle güle.");
            Application.Exit();
        }
        
        private void button4_Click(object sender, EventArgs e)                           //Ana formu saklayıp ilgili forma geçme
        {
            if (oku == 0)
            {
                MessageBox.Show("Önce dosya okuması yapınız.");
            }
            else
            {
                Form frm3 = new Form3();
                frm3.Show();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)                           // Ana formu saklayıp ilgili forma geçiş
        {
            if (oku == 0)
            {
                MessageBox.Show("Önce dosya okuması yapınız.");
            }
            else
            {
                Form frm2 = new Form2();
                frm2.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)                           // Dosyadan okuma işlemi 
        {
            oku = 1;
            sayac = 0;
            StreamReader SW = new StreamReader(Application.StartupPath + "\\araclar.txt");
            string butunSatir;
            string[] parcaSatir= new string[10];                                         // Araç bilgi sayısı kadarlık dizi
            while ((butunSatir = SW.ReadLine()) != null)                                 // Dosya satırlarını okuyup satırları # yardımıyla ayırma
            {                                                                            // Bilgilerinin tutulduğu diziye atma
                parcaSatir=butunSatir.Split('#');
                istenen.Add(new List<string>());
                for (int j=0;j<10;j++)
                {
                     istenen[sayac].Add(parcaSatir[j]);
                }
                sayac++;
            }
            MessageBox.Show("Dosya başarıyla okundu.");
            /*for (int i = 0; i < sayac ; i++)                                           // Kayıtları görmek için kısa bir kod
            {
                MessageBox.Show(istenen[i][0] + "-" + istenen[i][1] + "-" + istenen[i][2] + "-" + istenen[i][3] + "-" + istenen[i][4] + "-" + istenen[i][5] + "-" + istenen[i][6] + "-" + istenen[i][7] + "-" + istenen[i][8] + "-" + istenen[i][9]);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form2.doku==1)                                                           // Eğer bir ekleme veya çıkarma yapıldıysa txt dosyasını boşalt
            {                                                                            // Ve araç bilgilerinin tutulduğu diziyi tekrar txt dosyasına yaz
                TextWriter tw = new StreamWriter(Application.StartupPath + "\\araclar.txt");
                tw.Write("");
                tw.Close();
                StreamWriter write = File.AppendText(Application.StartupPath + "\\araclar.txt");
                for (int i = 0; i < sayac; i++)
                {
                    write.Write(istenen[i][0] + "#" + istenen[i][1] + "#" + istenen[i][2] + "#" + istenen[i][3] + "#" + istenen[i][4] + "#" + istenen[i][5] + "#" + istenen[i][6] + "#" + istenen[i][7] + "#" + istenen[i][8] + "#" + istenen[i][9]);
                    write.WriteLine("");
                }
                write.Close();
                MessageBox.Show("Dosya başarıyla güncellendi");
                Form2.doku = 0;
            }
            else
            {
                MessageBox.Show("Herhangi bir işlem yapmadınız.");
            }
        }
    }
}
