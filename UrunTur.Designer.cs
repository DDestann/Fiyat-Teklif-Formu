namespace TeklifFormu
{
    partial class UrunTur
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtlTurListele = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTurAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FirmaAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtlTurListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "*";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(748, 112);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(87, 23);
            this.btnAnasayfa.TabIndex = 49;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(748, 83);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 23);
            this.btnGuncelle.TabIndex = 48;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(748, 54);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 23);
            this.btnSil.TabIndex = 47;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(748, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 23);
            this.btnEkle.TabIndex = 46;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtlTurListele
            // 
            this.dtlTurListele.AllowUserToAddRows = false;
            this.dtlTurListele.AllowUserToDeleteRows = false;
            this.dtlTurListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlTurListele.Location = new System.Drawing.Point(135, 74);
            this.dtlTurListele.Name = "dtlTurListele";
            this.dtlTurListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtlTurListele.Size = new System.Drawing.Size(605, 195);
            this.dtlTurListele.TabIndex = 45;
            this.dtlTurListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlTurListele_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(135, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(605, 20);
            this.txtId.TabIndex = 44;
            // 
            // txtTurAdi
            // 
            this.txtTurAdi.Location = new System.Drawing.Point(135, 48);
            this.txtTurAdi.Name = "txtTurAdi";
            this.txtTurAdi.Size = new System.Drawing.Size(605, 20);
            this.txtTurAdi.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ID";
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.AutoSize = true;
            this.FirmaAdi.Location = new System.Drawing.Point(19, 51);
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.Size = new System.Drawing.Size(56, 13);
            this.FirmaAdi.TabIndex = 41;
            this.FirmaAdi.Text = "Tür Adı: ";
            // 
            // UrunTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(878, 328);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtlTurListele);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTurAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FirmaAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "UrunTur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunTur";
            this.Load += new System.EventHandler(this.UrunTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtlTurListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dtlTurListele;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTurAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FirmaAdi;
    }
}