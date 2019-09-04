namespace Adam_asmaca
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_adamasmaca = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.lst_bilinmeyen = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_veritabanı = new System.Windows.Forms.Button();
            this.btn_çıkış = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_adamasmaca
            // 
            this.lbl_adamasmaca.AutoSize = true;
            this.lbl_adamasmaca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adamasmaca.Font = new System.Drawing.Font("MV Boli", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adamasmaca.ForeColor = System.Drawing.Color.Red;
            this.lbl_adamasmaca.Location = new System.Drawing.Point(117, 3);
            this.lbl_adamasmaca.Name = "lbl_adamasmaca";
            this.lbl_adamasmaca.Size = new System.Drawing.Size(277, 50);
            this.lbl_adamasmaca.TabIndex = 0;
            this.lbl_adamasmaca.Text = "Adam Asmaca";
            this.lbl_adamasmaca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.Green;
            this.btn_basla.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_basla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_basla.Location = new System.Drawing.Point(100, 31);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(220, 72);
            this.btn_basla.TabIndex = 1;
            this.btn_basla.TabStop = false;
            this.btn_basla.Text = "Oyuna Başla";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // lst_bilinmeyen
            // 
            this.lst_bilinmeyen.BackColor = System.Drawing.Color.Wheat;
            this.lst_bilinmeyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_bilinmeyen.FormattingEnabled = true;
            this.lst_bilinmeyen.ItemHeight = 20;
            this.lst_bilinmeyen.Location = new System.Drawing.Point(438, 66);
            this.lst_bilinmeyen.Name = "lst_bilinmeyen";
            this.lst_bilinmeyen.Size = new System.Drawing.Size(212, 260);
            this.lst_bilinmeyen.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(100, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 72);
            this.button4.TabIndex = 2;
            this.button4.TabStop = false;
            this.button4.Text = "Yüksek skorlar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_veritabanı);
            this.groupBox1.Controls.Add(this.btn_çıkış);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn_basla);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 392);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btn_veritabanı
            // 
            this.btn_veritabanı.BackColor = System.Drawing.Color.Green;
            this.btn_veritabanı.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veritabanı.Location = new System.Drawing.Point(100, 195);
            this.btn_veritabanı.Name = "btn_veritabanı";
            this.btn_veritabanı.Size = new System.Drawing.Size(220, 72);
            this.btn_veritabanı.TabIndex = 3;
            this.btn_veritabanı.Text = "Veritabanı güncelle";
            this.btn_veritabanı.UseVisualStyleBackColor = false;
            this.btn_veritabanı.Click += new System.EventHandler(this.btn_veritabanı_Click);
            // 
            // btn_çıkış
            // 
            this.btn_çıkış.BackColor = System.Drawing.Color.Green;
            this.btn_çıkış.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_çıkış.Location = new System.Drawing.Point(100, 277);
            this.btn_çıkış.Name = "btn_çıkış";
            this.btn_çıkış.Size = new System.Drawing.Size(220, 72);
            this.btn_çıkış.TabIndex = 2;
            this.btn_çıkış.TabStop = false;
            this.btn_çıkış.Text = "Çıkış";
            this.btn_çıkış.UseVisualStyleBackColor = false;
            this.btn_çıkış.Click += new System.EventHandler(this.btn_çıkış_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_basla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst_bilinmeyen);
            this.Controls.Add(this.lbl_adamasmaca);
            this.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_adamasmaca;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.ListBox lst_bilinmeyen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_çıkış;
        private System.Windows.Forms.Button btn_veritabanı;
    }
}

