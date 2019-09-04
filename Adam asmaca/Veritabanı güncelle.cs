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

namespace Adam_asmaca
{
    public partial class Veritabanı_güncelle : Form
    {
        public Veritabanı_güncelle()
        {
            InitializeComponent();
        }
        public void dosyadanOku()
        {
            lst_secilensil.Items.Clear();
            FileStream fs = new FileStream(@"kelimeler.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs,Encoding.Default);
            string sbilgi = sr.ReadLine();
            while (sbilgi != null)
            {
                lst_secilensil.Items.Add(sbilgi);
                sbilgi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void dosyadansil()
        {
            FileStream fs = new FileStream(@"kelimeler.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            string sbilgi = sr.ReadLine();
            while (sbilgi != lst_secilensil.Text.ToString())
            {
                lst_secilensil.Items.Add(sbilgi);
                sbilgi = sr.ReadLine();
                sw.WriteLine(sbilgi);
            }
            //while()
            sr.Close();
            fs.Close();
        }
        private void Veritabanı_güncelle_Load(object sender, EventArgs e)
        {
            this.Size = new Size(355, 250);
            lbl_uyarı.Visible = false;
            dosyadanOku();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fi = new FileStream(@"kelimeler.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fi, Encoding.Default);
            string satir = "", icerik = "";
            int i = 0;
            while ((satir = sr.ReadLine()) != null)
            {//    lst_secilensil dediğim listbox.
                if (i == lst_secilensil.SelectedIndex)
                {
                    icerik +=  "\n";
                }
                else
                {
                    icerik += satir + "\n";
                }
                i++;
            }
            fi.Flush();
            sr.Close();
            fi.Close();
            fi = new FileStream(@"kelimeler.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fi, Encoding.Default);
            for (int j = 0; j < icerik.Split('\n').Count(); j++)
            {
                string str = icerik.Split('\n')[j];
                if (str != null && str != "" && str != " ")
                {
                    sw.WriteLine(str);
                }
            }
            fi.Flush();
            sw.Flush();
            sw.Close();
            fi.Close();
            lst_secilensil.Items.Remove(lst_secilensil.SelectedItem);
            //dosyadanOku();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            lbl_uyarı.Visible = true;
            string kelime = txt_ekle.Text.ToUpper();
            FileStream fi = new FileStream(@"kelimeler.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fi, Encoding.Default);
            if ((kelime.Length>=4)&(kelime.Length<=7))
            {
                //StreamWriter sw = File.AppendText(@"kelimeler.txt");
                sw.WriteLine(kelime);
                sw.Close();
                fi.Close();
                dosyadanOku();
                lbl_uyarı.Size = new Size(50, 99);
                lbl_uyarı.Text = "Kayıt girildi...";
            }
            else
            {
                sw.Close();
                fi.Close();
                lbl_uyarı.Size = new Size(20, 99);
                lbl_uyarı.Text = "4-7 arası harf giriniz!";
                lbl_uyarı.Visible = true;
            }

           
        }

        private void lbl_uyarı_Click(object sender, EventArgs e)
        {

        }
    }
}
