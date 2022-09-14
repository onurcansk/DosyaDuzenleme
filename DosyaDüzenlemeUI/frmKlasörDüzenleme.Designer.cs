namespace DosyaDüzenlemeUI
{
    partial class frmKlasörDüzenleme
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtDosyaAçıklaması = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKullanımTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKlasördekiDosyalarıBul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDüzenlenecekKlasörYolu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.asd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKlasörle = new System.Windows.Forms.Button();
            this.btnTarihiGeçenleriTaşı = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(49, 359);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(270, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Özellik Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(430, 66);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1012, 574);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtDosyaAçıklaması
            // 
            this.txtDosyaAçıklaması.Location = new System.Drawing.Point(49, 437);
            this.txtDosyaAçıklaması.Margin = new System.Windows.Forms.Padding(5);
            this.txtDosyaAçıklaması.Name = "txtDosyaAçıklaması";
            this.txtDosyaAçıklaması.Size = new System.Drawing.Size(267, 26);
            this.txtDosyaAçıklaması.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dosya Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Son Erişim Tarihi";
            // 
            // dtpKullanımTarihi
            // 
            this.dtpKullanımTarihi.Location = new System.Drawing.Point(54, 505);
            this.dtpKullanımTarihi.Margin = new System.Windows.Forms.Padding(5);
            this.dtpKullanımTarihi.Name = "dtpKullanımTarihi";
            this.dtpKullanımTarihi.Size = new System.Drawing.Size(262, 26);
            this.dtpKullanımTarihi.TabIndex = 6;
            // 
            // btnKlasördekiDosyalarıBul
            // 
            this.btnKlasördekiDosyalarıBul.Location = new System.Drawing.Point(47, 98);
            this.btnKlasördekiDosyalarıBul.Margin = new System.Windows.Forms.Padding(5);
            this.btnKlasördekiDosyalarıBul.Name = "btnKlasördekiDosyalarıBul";
            this.btnKlasördekiDosyalarıBul.Size = new System.Drawing.Size(262, 50);
            this.btnKlasördekiDosyalarıBul.TabIndex = 7;
            this.btnKlasördekiDosyalarıBul.Text = "Klasördeki Dosyaları Bul";
            this.btnKlasördekiDosyalarıBul.UseVisualStyleBackColor = true;
            this.btnKlasördekiDosyalarıBul.Click += new System.EventHandler(this.btnKlasördekiDosyalarıBul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Düzenlemek Istenilen Klasör";
            // 
            // txtDüzenlenecekKlasörYolu
            // 
            this.txtDüzenlenecekKlasörYolu.Location = new System.Drawing.Point(47, 62);
            this.txtDüzenlenecekKlasörYolu.Margin = new System.Windows.Forms.Padding(5);
            this.txtDüzenlenecekKlasörYolu.Name = "txtDüzenlenecekKlasörYolu";
            this.txtDüzenlenecekKlasörYolu.Size = new System.Drawing.Size(259, 26);
            this.txtDüzenlenecekKlasörYolu.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(12, 310);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(375, 20);
            this.asd.TabIndex = 11;
            this.asd.Text = "-------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "KLASÖRDEKİ DOSYALARIN LİSTESİ";
            // 
            // btnKlasörle
            // 
            this.btnKlasörle.Location = new System.Drawing.Point(46, 158);
            this.btnKlasörle.Margin = new System.Windows.Forms.Padding(5);
            this.btnKlasörle.Name = "btnKlasörle";
            this.btnKlasörle.Size = new System.Drawing.Size(262, 45);
            this.btnKlasörle.TabIndex = 7;
            this.btnKlasörle.Text = "Klasörle";
            this.btnKlasörle.UseVisualStyleBackColor = true;
            this.btnKlasörle.Click += new System.EventHandler(this.btnKlasörle_Click);
            // 
            // btnTarihiGeçenleriTaşı
            // 
            this.btnTarihiGeçenleriTaşı.Location = new System.Drawing.Point(46, 213);
            this.btnTarihiGeçenleriTaşı.Margin = new System.Windows.Forms.Padding(5);
            this.btnTarihiGeçenleriTaşı.Name = "btnTarihiGeçenleriTaşı";
            this.btnTarihiGeçenleriTaşı.Size = new System.Drawing.Size(262, 45);
            this.btnTarihiGeçenleriTaşı.TabIndex = 7;
            this.btnTarihiGeçenleriTaşı.Text = "Çöpe Taşı";
            this.btnTarihiGeçenleriTaşı.UseVisualStyleBackColor = true;
            this.btnTarihiGeçenleriTaşı.Click += new System.EventHandler(this.btnTarihiGeçenleriTaşı_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dosya Adı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 208;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dosya Açıklaması";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 258;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Son Erişim Tarihi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dosya Boyutu";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Oluşturma Tarihi";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 170;
            // 
            // frmKlasörDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDüzenlenecekKlasörYolu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTarihiGeçenleriTaşı);
            this.Controls.Add(this.btnKlasörle);
            this.Controls.Add(this.btnKlasördekiDosyalarıBul);
            this.Controls.Add(this.dtpKullanımTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDosyaAçıklaması);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKlasörDüzenleme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmKlasörDüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtDosyaAçıklaması;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKullanımTarihi;
        private System.Windows.Forms.Button btnKlasördekiDosyalarıBul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDüzenlenecekKlasörYolu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKlasörle;
        private System.Windows.Forms.Button btnTarihiGeçenleriTaşı;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

