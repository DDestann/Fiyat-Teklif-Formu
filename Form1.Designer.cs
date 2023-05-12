namespace TeklifFormu
{
    partial class Form1
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
            this.drpFirma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drpMarka = new System.Windows.Forms.ComboBox();
            this.drpBirim = new System.Windows.Forms.ComboBox();
            this.drpAltUrun = new System.Windows.Forms.ComboBox();
            this.drpUrun = new System.Windows.Forms.ComboBox();
            this.drpUrunTur = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altÜrünKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLtUrunFiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtindirimFiyat = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtindirim1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAdetBirim = new System.Windows.Forms.Label();
            this.dtlListele = new System.Windows.Forms.DataGridView();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.drpFiyat = new System.Windows.Forms.ComboBox();
            this.txtindirim2 = new System.Windows.Forms.TextBox();
            this.txtindirim3 = new System.Windows.Forms.TextBox();
            this.dtlListeleFull = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtexcelId = new System.Windows.Forms.TextBox();
            this.btnExcelSil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtlListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlListeleFull)).BeginInit();
            this.SuspendLayout();
            // 
            // drpFirma
            // 
            this.drpFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpFirma.FormattingEnabled = true;
            this.drpFirma.Location = new System.Drawing.Point(140, 57);
            this.drpFirma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpFirma.Name = "drpFirma";
            this.drpFirma.Size = new System.Drawing.Size(326, 21);
            this.drpFirma.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marka: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birim Cinsi: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ÜrünÖzellikler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "AltÜrün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firma: ";
            // 
            // drpMarka
            // 
            this.drpMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpMarka.FormattingEnabled = true;
            this.drpMarka.Location = new System.Drawing.Point(140, 167);
            this.drpMarka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpMarka.Name = "drpMarka";
            this.drpMarka.Size = new System.Drawing.Size(326, 21);
            this.drpMarka.TabIndex = 5;
            // 
            // drpBirim
            // 
            this.drpBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpBirim.FormattingEnabled = true;
            this.drpBirim.Location = new System.Drawing.Point(140, 194);
            this.drpBirim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpBirim.Name = "drpBirim";
            this.drpBirim.Size = new System.Drawing.Size(326, 21);
            this.drpBirim.TabIndex = 6;
            // 
            // drpAltUrun
            // 
            this.drpAltUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpAltUrun.FormattingEnabled = true;
            this.drpAltUrun.Location = new System.Drawing.Point(140, 138);
            this.drpAltUrun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpAltUrun.Name = "drpAltUrun";
            this.drpAltUrun.Size = new System.Drawing.Size(326, 21);
            this.drpAltUrun.TabIndex = 7;
            this.drpAltUrun.SelectedIndexChanged += new System.EventHandler(this.drpAltUrun_SelectedIndexChanged);
            // 
            // drpUrun
            // 
            this.drpUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpUrun.FormattingEnabled = true;
            this.drpUrun.Location = new System.Drawing.Point(140, 111);
            this.drpUrun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpUrun.Name = "drpUrun";
            this.drpUrun.Size = new System.Drawing.Size(326, 21);
            this.drpUrun.TabIndex = 8;
            this.drpUrun.SelectedIndexChanged += new System.EventHandler(this.drpUrun_SelectedIndexChanged);
            // 
            // drpUrunTur
            // 
            this.drpUrunTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpUrunTur.FormattingEnabled = true;
            this.drpUrunTur.Location = new System.Drawing.Point(140, 84);
            this.drpUrunTur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpUrunTur.Name = "drpUrunTur";
            this.drpUrunTur.Size = new System.Drawing.Size(326, 21);
            this.drpUrunTur.TabIndex = 9;
            this.drpUrunTur.SelectedIndexChanged += new System.EventHandler(this.drpUrunTur_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.türToolStripMenuItem,
            this.ürünKategoriToolStripMenuItem,
            this.altÜrünKategoriToolStripMenuItem,
            this.aLtUrunFiyatToolStripMenuItem,
            this.birimToolStripMenuItem,
            this.markaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // türToolStripMenuItem
            // 
            this.türToolStripMenuItem.Name = "türToolStripMenuItem";
            this.türToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.türToolStripMenuItem.Text = "ÜrünTür";
            this.türToolStripMenuItem.Click += new System.EventHandler(this.türToolStripMenuItem_Click);
            // 
            // ürünKategoriToolStripMenuItem
            // 
            this.ürünKategoriToolStripMenuItem.Name = "ürünKategoriToolStripMenuItem";
            this.ürünKategoriToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünKategoriToolStripMenuItem.Text = "Urunler";
            this.ürünKategoriToolStripMenuItem.Click += new System.EventHandler(this.ürünKategoriToolStripMenuItem_Click);
            // 
            // altÜrünKategoriToolStripMenuItem
            // 
            this.altÜrünKategoriToolStripMenuItem.Name = "altÜrünKategoriToolStripMenuItem";
            this.altÜrünKategoriToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.altÜrünKategoriToolStripMenuItem.Text = "AltÜrün";
            this.altÜrünKategoriToolStripMenuItem.Click += new System.EventHandler(this.altÜrünKategoriToolStripMenuItem_Click);
            // 
            // aLtUrunFiyatToolStripMenuItem
            // 
            this.aLtUrunFiyatToolStripMenuItem.Name = "aLtUrunFiyatToolStripMenuItem";
            this.aLtUrunFiyatToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.aLtUrunFiyatToolStripMenuItem.Text = "AltUrunFiyat";
            this.aLtUrunFiyatToolStripMenuItem.Click += new System.EventHandler(this.aLtUrunFiyatToolStripMenuItem_Click);
            // 
            // birimToolStripMenuItem
            // 
            this.birimToolStripMenuItem.Name = "birimToolStripMenuItem";
            this.birimToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.birimToolStripMenuItem.Text = "Birim";
            this.birimToolStripMenuItem.Click += new System.EventHandler(this.birimToolStripMenuItem_Click);
            // 
            // markaToolStripMenuItem
            // 
            this.markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            this.markaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.markaToolStripMenuItem.Text = "Marka";
            this.markaToolStripMenuItem.Click += new System.EventHandler(this.markaToolStripMenuItem_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(482, 77);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(104, 20);
            this.txtAdet.TabIndex = 17;
            // 
            // txtindirimFiyat
            // 
            this.txtindirimFiyat.Location = new System.Drawing.Point(628, 164);
            this.txtindirimFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtindirimFiyat.Name = "txtindirimFiyat";
            this.txtindirimFiyat.Size = new System.Drawing.Size(123, 20);
            this.txtindirimFiyat.TabIndex = 17;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(774, 155);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(88, 37);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtindirim1
            // 
            this.txtindirim1.Location = new System.Drawing.Point(482, 122);
            this.txtindirim1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtindirim1.Name = "txtindirim1";
            this.txtindirim1.Size = new System.Drawing.Size(46, 20);
            this.txtindirim1.TabIndex = 19;
            this.txtindirim1.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(479, 57);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 13);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Cins(Kg,M,Adet...)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(644, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Birim Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(480, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "İndrim1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(502, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Toplam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(546, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "İndrim2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(619, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "İndrim3";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(482, 164);
            this.txtToplamFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(123, 20);
            this.txtToplamFiyat.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(619, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "indirim Yapılan Fiyat";
            // 
            // lblAdetBirim
            // 
            this.lblAdetBirim.AutoSize = true;
            this.lblAdetBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdetBirim.Location = new System.Drawing.Point(689, 119);
            this.lblAdetBirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdetBirim.Name = "lblAdetBirim";
            this.lblAdetBirim.Size = new System.Drawing.Size(11, 13);
            this.lblAdetBirim.TabIndex = 28;
            this.lblAdetBirim.Text = ":";
            // 
            // dtlListele
            // 
            this.dtlListele.AllowUserToAddRows = false;
            this.dtlListele.AllowUserToDeleteRows = false;
            this.dtlListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlListele.Location = new System.Drawing.Point(12, 452);
            this.dtlListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtlListele.Name = "dtlListele";
            this.dtlListele.ReadOnly = true;
            this.dtlListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtlListele.Size = new System.Drawing.Size(850, 186);
            this.dtlListele.TabIndex = 29;
            this.dtlListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlListele_CellContentClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(15, 423);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(339, 23);
            this.btnYazdir.TabIndex = 30;
            this.btnYazdir.Text = "Excelle Aktar";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // drpFiyat
            // 
            this.drpFiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpFiyat.FormattingEnabled = true;
            this.drpFiyat.Location = new System.Drawing.Point(624, 76);
            this.drpFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drpFiyat.Name = "drpFiyat";
            this.drpFiyat.Size = new System.Drawing.Size(116, 21);
            this.drpFiyat.TabIndex = 31;
            // 
            // txtindirim2
            // 
            this.txtindirim2.Location = new System.Drawing.Point(550, 122);
            this.txtindirim2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtindirim2.Name = "txtindirim2";
            this.txtindirim2.Size = new System.Drawing.Size(46, 20);
            this.txtindirim2.TabIndex = 32;
            this.txtindirim2.Text = "0";
            // 
            // txtindirim3
            // 
            this.txtindirim3.Location = new System.Drawing.Point(620, 122);
            this.txtindirim3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtindirim3.Name = "txtindirim3";
            this.txtindirim3.Size = new System.Drawing.Size(46, 20);
            this.txtindirim3.TabIndex = 33;
            this.txtindirim3.Text = "0";
            // 
            // dtlListeleFull
            // 
            this.dtlListeleFull.AllowUserToAddRows = false;
            this.dtlListeleFull.AllowUserToDeleteRows = false;
            this.dtlListeleFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlListeleFull.Location = new System.Drawing.Point(11, 231);
            this.dtlListeleFull.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtlListeleFull.Name = "dtlListeleFull";
            this.dtlListeleFull.ReadOnly = true;
            this.dtlListeleFull.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtlListeleFull.Size = new System.Drawing.Size(851, 186);
            this.dtlListeleFull.TabIndex = 34;
            this.dtlListeleFull.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlListeleFull_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(140, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(326, 20);
            this.txtId.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 59;
            this.label7.Text = "ID";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(774, 95);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 23);
            this.btnGuncelle.TabIndex = 65;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(774, 66);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 23);
            this.btnSil.TabIndex = 64;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(774, 37);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 23);
            this.btnEkle.TabIndex = 63;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtexcelId
            // 
            this.txtexcelId.Enabled = false;
            this.txtexcelId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtexcelId.Location = new System.Drawing.Point(369, 423);
            this.txtexcelId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtexcelId.Name = "txtexcelId";
            this.txtexcelId.Size = new System.Drawing.Size(72, 20);
            this.txtexcelId.TabIndex = 66;
            // 
            // btnExcelSil
            // 
            this.btnExcelSil.Location = new System.Drawing.Point(459, 423);
            this.btnExcelSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcelSil.Name = "btnExcelSil";
            this.btnExcelSil.Size = new System.Drawing.Size(403, 23);
            this.btnExcelSil.TabIndex = 67;
            this.btnExcelSil.Text = "Excelle Aktarılanları Sil";
            this.btnExcelSil.UseVisualStyleBackColor = true;
            this.btnExcelSil.Click += new System.EventHandler(this.btnExcelSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(878, 645);
            this.Controls.Add(this.btnExcelSil);
            this.Controls.Add(this.txtexcelId);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtlListeleFull);
            this.Controls.Add(this.txtindirim3);
            this.Controls.Add(this.txtindirim2);
            this.Controls.Add(this.drpFiyat);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dtlListele);
            this.Controls.Add(this.lblAdetBirim);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtindirim1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtindirimFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.drpFirma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpMarka);
            this.Controls.Add(this.drpBirim);
            this.Controls.Add(this.drpAltUrun);
            this.Controls.Add(this.drpUrun);
            this.Controls.Add(this.drpUrunTur);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtlListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlListeleFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drpFirma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpMarka;
        private System.Windows.Forms.ComboBox drpBirim;
        private System.Windows.Forms.ComboBox drpAltUrun;
        private System.Windows.Forms.ComboBox drpUrun;
        private System.Windows.Forms.ComboBox drpUrunTur;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altÜrünKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtindirimFiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtindirim1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAdetBirim;
        private System.Windows.Forms.DataGridView dtlListele;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ComboBox drpFiyat;
        private System.Windows.Forms.ToolStripMenuItem aLtUrunFiyatToolStripMenuItem;
        private System.Windows.Forms.TextBox txtindirim2;
        private System.Windows.Forms.TextBox txtindirim3;
        private System.Windows.Forms.DataGridView dtlListeleFull;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtexcelId;
        private System.Windows.Forms.Button btnExcelSil;
    }
}

