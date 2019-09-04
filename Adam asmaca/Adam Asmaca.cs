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
    public partial class Adam_Asmaca : Form
    {
        public Adam_Asmaca()
        {
            InitializeComponent();
        }
        String[] butonlar = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Ğ", "Ü", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ş", "İ", "Z", "X", "C", "V", "B", "N", "M", "Ö", "Ç" };
        private void Adam_Asmaca_Load(object sender, EventArgs e)
        {
            this.Size=new Size(300, 140);
            txt_kelime1.Enabled = false; txt_kelime2.Enabled = false;
            txt_kelime3.Enabled = false; txt_kelime4.Enabled = false;
            txt_kelime5.Enabled = false; txt_kelime6.Enabled = false;
            txt_kelime7.Enabled = false;
            Form1 yeni = new Form1();
            yeni.Close();
            for (int i = 0; i <butonlar.Length; i++)
            {
                Button btn = (Button)panel_klavye.Controls["btn_" +butonlar[i]];
                btn.Enabled = false;
            }
            for(int i=0;i<=8;i++)
            {
                PictureBox pcb = (PictureBox)this.Controls["pcb_"+(i+1)];
                pcb.Visible = false;
            }
        }
        public void harfsayısı()
        {
            txt_kelime1.Visible = true; txt_kelime2.Visible = true;
            txt_kelime3.Visible = true; txt_kelime4.Visible = true;
            txt_kelime5.Visible = true; txt_kelime6.Visible = true;
            txt_kelime7.Visible = true;
            
             if ((rdn_4harf.Checked==true) |(rastgele==4))
            {
                txt_kelime1.Enabled = false;txt_kelime2.Enabled = false;
                txt_kelime3.Enabled = false;txt_kelime4.Enabled = false;
                txt_kelime5.Visible = false;txt_kelime6.Visible = false;
                txt_kelime7.Visible = false; kelimeuzunluk = 4; rastgele = 0; hak = 6;
            }
            else if ((rdn_5harf.Checked == true) | (rastgele == 5))
            {
                txt_kelime1.Enabled = false; txt_kelime2.Enabled = false;
                txt_kelime3.Enabled = false; txt_kelime4.Enabled = false;
                txt_kelime5.Enabled = false; txt_kelime6.Visible = false;
                txt_kelime7.Visible = false; kelimeuzunluk = 5; rastgele = 0; hak = 7;
            }
            else if ((rdn_6harf.Checked == true) | (rastgele == 6))
            {
                txt_kelime1.Enabled = false; txt_kelime2.Enabled = false;
                txt_kelime3.Enabled = false; txt_kelime4.Enabled = false;
                txt_kelime5.Enabled = false; txt_kelime6.Enabled = false;
                txt_kelime7.Visible = false; kelimeuzunluk = 6; rastgele = 0; hak = 8;
            }
            else if ((rdn_7harf.Checked == true) | (rastgele == 7))
            {
                txt_kelime1.Enabled = false; txt_kelime2.Enabled = false;
                txt_kelime3.Enabled = false; txt_kelime4.Enabled = false;
                txt_kelime5.Enabled = false; txt_kelime6.Enabled = false;
                txt_kelime7.Enabled = false; kelimeuzunluk = 7;rastgele = 0; hak = 9;
            }
        }
        public void puan(int oyunsonu,int hak)
        {
            FileStream fs = new FileStream(@"puan.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(isim+"  Puanınız:"+((oyunsonu*500)+(hak*100)));
            MessageBox.Show(":OYUN BİTTİ:"+ "\nKelime :" + kelime +"\nPuanınız:" + ((oyunsonu*500)+(hak*100)));
            sw.Close();
            fs.Close();
        }
        
        int kelimeuzunluk = 0;
        int rastgele = 0;
        string kelime;
        int hak = 0;
        int resimsayısı = 0;
        private void btn_başlat_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
            {
                TextBox txt = (TextBox)panel_klavye.Controls["txt_kelime" + (i).ToString()];
                txt.Clear();
            }
            for (int i = 1; i <= 9; i++)
            {
                PictureBox pcb = (PictureBox)this.Controls["pcb_" + i.ToString()];
                pcb.Visible = false;
            }
            resimsay = 0;
            oyunsonu = 0;
           
            for (int i = 0; i < butonlar.Length; i++)
            {
                Button btn = (Button)panel_klavye.Controls["btn_" + butonlar[i]];
                btn.Enabled = true;
            }
            
            int diziicinsay = 0;
            int ekle = 0;
            lst_bilinmeyen.Items.Clear();
            Random yeni = new Random();
            if (rdn_rastgele.Checked == true)
            {
                rastgele = yeni.Next(4, 8);
                resimsayısı = rastgele;
               // MessageBox.Show(rastgele.ToString());
            }

            harfsayısı();
            lbl_hak.Text = "Kalan Hak:" + hak.ToString();
            FileStream fs = new FileStream(@"kelimeler.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string sbilgi = sr.ReadLine();

            while (sbilgi != null)
            {
                
                if (sbilgi.Length == kelimeuzunluk)
                {
                    diziicinsay++;
                }
                sbilgi = sr.ReadLine();
            }
            fs.Close();
            sr.Close();
            FileStream fss = new FileStream(@"kelimeler.txt", FileMode.Open, FileAccess.Read);
            StreamReader srr = new StreamReader(fss, Encoding.Default);
            string ssbilgi = srr.ReadLine();
            string[] dizi = new string[diziicinsay];

            while (ssbilgi != null)
            {
                if (ssbilgi.Length == kelimeuzunluk)
                    {       
                        dizi[ekle] = ssbilgi;
                        ekle++;//ne kadar  eleman varsa onun sayısını tutuyor
                    }
                ssbilgi = srr.ReadLine();
            }
            int kelimeseç = yeni.Next(0,ekle);
            kelime = dizi[kelimeseç].ToString();
            srr.Close();
            fss.Close();
            //MessageBox.Show(dizi[kelimeseç].ToString());
            //burası kelimeyi veriyor...
            }
        int oyunsonu = 0;
        int say = 1;
        int resimsay = 0;
        private void btn_A_MouseClick(object sender, MouseEventArgs e)
        {
            say = 0;
            Button b1 = (Button)sender;
            b1.Enabled = false;
           
            for (int i = 1; i <=kelime.Length; i++)
            {
               
                if (kelime[i-1].ToString() == b1.Text.ToString())
                {
                    TextBox txt = (TextBox)panel_klavye.Controls["txt_kelime" + (i).ToString()];
                    txt.Text = kelime[i-1].ToString();
                    say++;
                    oyunsonu++;
                }

            }
            if (say == 0)
            {
                hak--;
                lbl_hak.Text = "Kalan Hak:" + hak.ToString();
            }
            if ((kelime.IndexOf(b1.Text.ToString()) == -1) & (lst_bilinmeyen.Items.IndexOf(b1.Text.ToString()) == -1))
            {
                lst_bilinmeyen.Items.Add(b1.Text.ToString());
            }

            if (((rdn_4harf.Checked == true) & (say == 0)) | ((resimsayısı == 4)& (say==0)))
            {
                resimsay++;
               switch(resimsay)
                {
                    case 1:
                        pcb_1.Visible = true;pcb_2.Visible = true;break;
                    case 2:
                        pcb_3.Visible = true;pcb_4.Visible = true;break;
                    case 3:
                        pcb_5.Visible = true;pcb_6.Visible = true;break;
                    case 4:
                        pcb_7.Visible = true;break;
                    case 5:
                        pcb_8.Visible = true;break;
                    case 6:
                        pcb_9.Visible = true;
                        resimsay=0;break;
                }
            }
            if (((rdn_5harf.Checked == true) & (say == 0)) | ((resimsayısı == 5) & (say == 0)))
            {
                resimsay++;
                switch (resimsay)
                {
                    case 1:
                        pcb_1.Visible = true;pcb_2.Visible = true;break;
                    case 2:
                        pcb_3.Visible = true;pcb_4.Visible = true;break;
                    case 3:
                        pcb_5.Visible = true; break;
                    case 4:
                        pcb_6.Visible = true; break;
                    case 5:
                        pcb_7.Visible = true; break;
                    case 6:
                        pcb_8.Visible = true; break;
                    case 7:
                        pcb_9.Visible = true; resimsay = 0; break;
                }
            }
            if (((rdn_6harf.Checked == true) & (say == 0)) | ((resimsayısı == 6) & (say == 0)))
            {
                resimsay++;
                switch (resimsay)
                {
                    case 1:
                        pcb_1.Visible = true; pcb_2.Visible = true; break;
                    case 2:
                        pcb_3.Visible = true; break;
                    case 3:
                        pcb_4.Visible = true; break;
                    case 4:
                        pcb_5.Visible = true; break;
                    case 5:
                        pcb_6.Visible = true;  break;
                    case 6:
                        pcb_7.Visible = true; break;
                    case 7:
                        pcb_8.Visible = true; break;
                    case 8:
                        pcb_9.Visible = true;resimsay = 0; break;
                }
            }
            if (((rdn_7harf.Checked == true) & (say == 0))| ((resimsayısı == 7) & (say == 0)))
            {
                resimsay++;
                switch (resimsay)
                {
                    case 1:
                        pcb_1.Visible = true; break;
                    case 2:
                        pcb_2.Visible = true; break;
                    case 3:
                        pcb_3.Visible = true;  break;
                    case 4:
                        pcb_4.Visible = true; break;
                    case 5:
                        pcb_5.Visible = true; break;
                    case 6:
                        pcb_6.Visible = true;  break;
                    case 7:
                        pcb_7.Visible = true;  break;
                    case 8:
                        pcb_8.Visible = true; break;
                    case 9:
                        pcb_9.Visible = true; resimsay = 0;  break;
                }
            }


            if ((oyunsonu>=kelime.Length) | (hak==0))
            {
                puan(oyunsonu,hak);
                DialogResult sonuc;
                sonuc = MessageBox.Show("Yenioyun ister misiniz?", "Oyun bitti",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.No)
                {
                    this.Close();
                    Form1 yeni = new Form1();
                    yeni.Show();
                }
                if (sonuc == DialogResult.Yes)
                {
                    this.Close();
                    Adam_Asmaca yeni = new Adam_Asmaca();
                    yeni.Show();
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Close();
        }
        string isim;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                lbl_isim.ForeColor = Color.Red;
            }
            else
            {

                this.Size = new Size(490, 425);
                pnl_isim.Visible = false;
                pnl_isim.Enabled = false;
                isim = Convert.ToString(textBox1.Text);
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void pcb_3_Click(object sender, EventArgs e)
        {}
        private void pcb_6_Click(object sender, EventArgs e)
        {}
    }
}
