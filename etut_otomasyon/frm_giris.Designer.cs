namespace etut_otomasyon
{
    partial class frm_giris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.msk_ogrencino = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ogrencigiris = new System.Windows.Forms.Button();
            this.txt_ogrenciparola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msk_ogretmenno = new System.Windows.Forms.MaskedTextBox();
            this.btn_ogretmengiris = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ogretmenparola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.msk_yoneticinumarasi = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_yoneticigirs = new System.Windows.Forms.Button();
            this.txt_yoneticiparola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.msk_ogrencino);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_ogrencigiris);
            this.panel1.Controls.Add(this.txt_ogrenciparola);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 277);
            this.panel1.TabIndex = 0;
            // 
            // msk_ogrencino
            // 
            this.msk_ogrencino.Location = new System.Drawing.Point(133, 102);
            this.msk_ogrencino.Mask = "000000";
            this.msk_ogrencino.Name = "msk_ogrencino";
            this.msk_ogrencino.Size = new System.Drawing.Size(100, 20);
            this.msk_ogrencino.TabIndex = 0;
            this.msk_ogrencino.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "ÖĞRENCİ GİRİŞİ";
            // 
            // btn_ogrencigiris
            // 
            this.btn_ogrencigiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ogrencigiris.Location = new System.Drawing.Point(133, 163);
            this.btn_ogrencigiris.Name = "btn_ogrencigiris";
            this.btn_ogrencigiris.Size = new System.Drawing.Size(100, 23);
            this.btn_ogrencigiris.TabIndex = 2;
            this.btn_ogrencigiris.Text = "GİRİŞ";
            this.btn_ogrencigiris.UseVisualStyleBackColor = true;
            this.btn_ogrencigiris.Click += new System.EventHandler(this.btn_ogrencigiris_Click);
            // 
            // txt_ogrenciparola
            // 
            this.txt_ogrenciparola.Location = new System.Drawing.Point(133, 128);
            this.txt_ogrenciparola.Name = "txt_ogrenciparola";
            this.txt_ogrenciparola.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrenciparola.TabIndex = 1;
            this.txt_ogrenciparola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Numarası :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.msk_ogretmenno);
            this.panel2.Controls.Add(this.btn_ogretmengiris);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_ogretmenparola);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(282, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 277);
            this.panel2.TabIndex = 1;
            // 
            // msk_ogretmenno
            // 
            this.msk_ogretmenno.Location = new System.Drawing.Point(142, 102);
            this.msk_ogretmenno.Mask = "000";
            this.msk_ogretmenno.Name = "msk_ogretmenno";
            this.msk_ogretmenno.Size = new System.Drawing.Size(100, 20);
            this.msk_ogretmenno.TabIndex = 3;
            this.msk_ogretmenno.ValidatingType = typeof(int);
            // 
            // btn_ogretmengiris
            // 
            this.btn_ogretmengiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ogretmengiris.Location = new System.Drawing.Point(142, 163);
            this.btn_ogretmengiris.Name = "btn_ogretmengiris";
            this.btn_ogretmengiris.Size = new System.Drawing.Size(100, 23);
            this.btn_ogretmengiris.TabIndex = 5;
            this.btn_ogretmengiris.Text = "GİRİŞ";
            this.btn_ogretmengiris.UseVisualStyleBackColor = true;
            this.btn_ogretmengiris.Click += new System.EventHandler(this.btn_ogretmengiris_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "ÖĞRETMEN GİRİŞİ";
            // 
            // txt_ogretmenparola
            // 
            this.txt_ogretmenparola.Location = new System.Drawing.Point(142, 128);
            this.txt_ogretmenparola.Name = "txt_ogretmenparola";
            this.txt_ogretmenparola.Size = new System.Drawing.Size(100, 20);
            this.txt_ogretmenparola.TabIndex = 4;
            this.txt_ogretmenparola.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parola :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğretmen Numarası :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.msk_yoneticinumarasi);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btn_yoneticigirs);
            this.panel3.Controls.Add(this.txt_yoneticiparola);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(543, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 277);
            this.panel3.TabIndex = 2;
            // 
            // msk_yoneticinumarasi
            // 
            this.msk_yoneticinumarasi.Location = new System.Drawing.Point(133, 98);
            this.msk_yoneticinumarasi.Mask = "000000";
            this.msk_yoneticinumarasi.Name = "msk_yoneticinumarasi";
            this.msk_yoneticinumarasi.Size = new System.Drawing.Size(100, 20);
            this.msk_yoneticinumarasi.TabIndex = 6;
            this.msk_yoneticinumarasi.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "YÖNETİCİ GİRİŞİ";
            // 
            // btn_yoneticigirs
            // 
            this.btn_yoneticigirs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yoneticigirs.Location = new System.Drawing.Point(133, 163);
            this.btn_yoneticigirs.Name = "btn_yoneticigirs";
            this.btn_yoneticigirs.Size = new System.Drawing.Size(100, 23);
            this.btn_yoneticigirs.TabIndex = 8;
            this.btn_yoneticigirs.Text = "GİRİŞ";
            this.btn_yoneticigirs.UseVisualStyleBackColor = true;
            this.btn_yoneticigirs.Click += new System.EventHandler(this.btn_yoneticigirs_Click);
            // 
            // txt_yoneticiparola
            // 
            this.txt_yoneticiparola.Location = new System.Drawing.Point(133, 128);
            this.txt_yoneticiparola.Name = "txt_yoneticiparola";
            this.txt_yoneticiparola.Size = new System.Drawing.Size(100, 20);
            this.txt_yoneticiparola.TabIndex = 7;
            this.txt_yoneticiparola.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Parola :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yönetici Numarası :";
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(822, 329);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ogrencigiris;
        private System.Windows.Forms.TextBox txt_ogrenciparola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ogretmengiris;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ogretmenparola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_yoneticigirs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_yoneticinumarasi;
        private System.Windows.Forms.TextBox txt_yoneticiparola;
        private System.Windows.Forms.MaskedTextBox msk_ogrencino;
        private System.Windows.Forms.MaskedTextBox msk_ogretmenno;
    }
}

