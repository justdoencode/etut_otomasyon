namespace etut_otomasyon
{
    partial class frm_ogrenci
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kursid = new System.Windows.Forms.TextBox();
            this.btn_talepet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.cmb_ogretmen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_ders = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİN";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(116, 9);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(14, 17);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "MEVCUT KURSLARIM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.btn_iptal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_kursid);
            this.panel2.Controls.Add(this.btn_talepet);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.msk_saat);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.msk_tarih);
            this.panel2.Controls.Add(this.cmb_ogretmen);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmb_ders);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(403, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 229);
            this.panel2.TabIndex = 4;
            // 
            // btn_iptal
            // 
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iptal.Location = new System.Drawing.Point(91, 192);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İPTAL ET";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kurs ID :";
            // 
            // txt_kursid
            // 
            this.txt_kursid.Enabled = false;
            this.txt_kursid.Location = new System.Drawing.Point(91, 166);
            this.txt_kursid.Name = "txt_kursid";
            this.txt_kursid.Size = new System.Drawing.Size(121, 20);
            this.txt_kursid.TabIndex = 9;
            // 
            // btn_talepet
            // 
            this.btn_talepet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_talepet.Location = new System.Drawing.Point(91, 125);
            this.btn_talepet.Name = "btn_talepet";
            this.btn_talepet.Size = new System.Drawing.Size(75, 23);
            this.btn_talepet.TabIndex = 8;
            this.btn_talepet.Text = "TALEP ET";
            this.btn_talepet.UseVisualStyleBackColor = true;
            this.btn_talepet.Click += new System.EventHandler(this.btn_talepet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(44, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Saat :";
            // 
            // msk_saat
            // 
            this.msk_saat.Location = new System.Drawing.Point(91, 99);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(42, 20);
            this.msk_saat.TabIndex = 6;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tarih :";
            // 
            // msk_tarih
            // 
            this.msk_tarih.Location = new System.Drawing.Point(91, 73);
            this.msk_tarih.Mask = "00/00/0000";
            this.msk_tarih.Name = "msk_tarih";
            this.msk_tarih.Size = new System.Drawing.Size(68, 20);
            this.msk_tarih.TabIndex = 4;
            this.msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_ogretmen
            // 
            this.cmb_ogretmen.FormattingEnabled = true;
            this.cmb_ogretmen.Location = new System.Drawing.Point(91, 46);
            this.cmb_ogretmen.Name = "cmb_ogretmen";
            this.cmb_ogretmen.Size = new System.Drawing.Size(121, 21);
            this.cmb_ogretmen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğretmen :";
            // 
            // cmb_ders
            // 
            this.cmb_ders.FormattingEnabled = true;
            this.cmb_ders.Location = new System.Drawing.Point(91, 19);
            this.cmb_ders.Name = "cmb_ders";
            this.cmb_ders.Size = new System.Drawing.Size(121, 21);
            this.cmb_ders.TabIndex = 1;
            this.cmb_ders.SelectedIndexChanged += new System.EventHandler(this.cmb_ders_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ders :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(419, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "KURS TALEBİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 229);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frm_ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(655, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ogrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRENCİ SAYFASI";
            this.Load += new System.EventHandler(this.frm_ogrenci_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_talepet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_tarih;
        private System.Windows.Forms.ComboBox cmb_ogretmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_ders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kursid;
        private System.Windows.Forms.Button btn_iptal;
    }
}