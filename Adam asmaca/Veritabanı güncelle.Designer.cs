namespace Adam_asmaca
{
    partial class Veritabanı_güncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veritabanı_güncelle));
            this.lst_secilensil = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ekle = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_uyarı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_secilensil
            // 
            this.lst_secilensil.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_secilensil.FormattingEnabled = true;
            this.lst_secilensil.ItemHeight = 17;
            this.lst_secilensil.Location = new System.Drawing.Point(214, 12);
            this.lst_secilensil.Name = "lst_secilensil";
            this.lst_secilensil.Size = new System.Drawing.Size(217, 225);
            this.lst_secilensil.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Green;
            this.btn_ekle.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.Location = new System.Drawing.Point(75, 46);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(133, 40);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(75, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Seçileni sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_ekle
            // 
            this.txt_ekle.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ekle.Location = new System.Drawing.Point(75, 12);
            this.txt_ekle.MaxLength = 7;
            this.txt_ekle.Name = "txt_ekle";
            this.txt_ekle.Size = new System.Drawing.Size(133, 28);
            this.txt_ekle.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_uyarı
            // 
            this.lbl_uyarı.AutoSize = true;
            this.lbl_uyarı.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uyarı.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uyarı.ForeColor = System.Drawing.Color.Red;
            this.lbl_uyarı.Location = new System.Drawing.Point(20, 99);
            this.lbl_uyarı.Name = "lbl_uyarı";
            this.lbl_uyarı.Size = new System.Drawing.Size(178, 18);
            this.lbl_uyarı.TabIndex = 4;
            this.lbl_uyarı.Text = "4-7 arası harf giriniz!";
            this.lbl_uyarı.Click += new System.EventHandler(this.lbl_uyarı_Click);
            // 
            // Veritabanı_güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 252);
            this.Controls.Add(this.lbl_uyarı);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_ekle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lst_secilensil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Veritabanı_güncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı_güncelle";
            this.Load += new System.EventHandler(this.Veritabanı_güncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_secilensil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_ekle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_uyarı;
    }
}