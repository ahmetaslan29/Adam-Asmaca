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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void dosyadanOku()
        {
            FileStream fs = new FileStream(@"puan.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string sbilgi = sr.ReadLine();
            while (sbilgi != null)
            {
                lst_bilinmeyen.Items.Add(sbilgi);
                sbilgi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(445, 500);
        }
        private void btn_basla_Click(object sender, EventArgs e)
        {
            Adam_Asmaca yeni = new Adam_Asmaca();
            yeni.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lst_bilinmeyen.Items.Clear();
            this.Size = new System.Drawing.Size(680, 500);
            dosyadanOku();
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_veritabanı_Click(object sender, EventArgs e)
        {
            Veritabanı_güncelle yeni = new Veritabanı_güncelle();
            yeni.Show();
            this.Hide();
        }

        
    }
}
