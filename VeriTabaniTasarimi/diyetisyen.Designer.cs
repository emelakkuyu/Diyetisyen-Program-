namespace VeriTabaniTasarimi
{
    partial class diyetisyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diyetisyen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeOlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorÜyeOlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıÜyeOlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beslenmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMIHesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.künyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenüToolStripMenuItem,
            this.beslenmeToolStripMenuItem,
            this.bMIHesaplaToolStripMenuItem,
            this.künyeToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeOlToolStripMenuItem,
            this.girişToolStripMenuItem});
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.anaMenüToolStripMenuItem.Text = "Ana Menü";
            // 
            // üyeOlToolStripMenuItem
            // 
            this.üyeOlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorÜyeOlToolStripMenuItem,
            this.kullanıcıÜyeOlToolStripMenuItem});
            this.üyeOlToolStripMenuItem.Name = "üyeOlToolStripMenuItem";
            this.üyeOlToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.üyeOlToolStripMenuItem.Text = "Üye Ol";
            // 
            // doktorÜyeOlToolStripMenuItem
            // 
            this.doktorÜyeOlToolStripMenuItem.Name = "doktorÜyeOlToolStripMenuItem";
            this.doktorÜyeOlToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.doktorÜyeOlToolStripMenuItem.Text = "Doktor ";
            this.doktorÜyeOlToolStripMenuItem.Click += new System.EventHandler(this.doktorÜyeOlToolStripMenuItem_Click);
            // 
            // kullanıcıÜyeOlToolStripMenuItem
            // 
            this.kullanıcıÜyeOlToolStripMenuItem.Name = "kullanıcıÜyeOlToolStripMenuItem";
            this.kullanıcıÜyeOlToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.kullanıcıÜyeOlToolStripMenuItem.Text = "Kullanıcı";
            this.kullanıcıÜyeOlToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıÜyeOlToolStripMenuItem_Click);
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // beslenmeToolStripMenuItem
            // 
            this.beslenmeToolStripMenuItem.Name = "beslenmeToolStripMenuItem";
            this.beslenmeToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.beslenmeToolStripMenuItem.Text = "Yemek Ölçüleri";
            this.beslenmeToolStripMenuItem.Click += new System.EventHandler(this.beslenmeToolStripMenuItem_Click);
            // 
            // bMIHesaplaToolStripMenuItem
            // 
            this.bMIHesaplaToolStripMenuItem.Name = "bMIHesaplaToolStripMenuItem";
            this.bMIHesaplaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bMIHesaplaToolStripMenuItem.Text = "BMI Hesapla";
            this.bMIHesaplaToolStripMenuItem.Click += new System.EventHandler(this.bMIHesaplaToolStripMenuItem_Click);
            // 
            // künyeToolStripMenuItem
            // 
            this.künyeToolStripMenuItem.Name = "künyeToolStripMenuItem";
            this.künyeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.künyeToolStripMenuItem.Text = "Ekibimiz";
            this.künyeToolStripMenuItem.Click += new System.EventHandler(this.künyeToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // diyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "diyetisyen";
            this.Text = "Diyetisyen Programı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeOlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorÜyeOlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıÜyeOlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beslenmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMIHesaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem künyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
    }
}

