namespace etut_otomasyon
{
    partial class frm_yoneticibilgiguncelle
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
            this.msk_yoneticino = new System.Windows.Forms.MaskedTextBox();
            this.txt_yoneticiad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yoneticisoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yoneticiparola = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Numarası :";
            // 
            // msk_yoneticino
            // 
            this.msk_yoneticino.Enabled = false;
            this.msk_yoneticino.Location = new System.Drawing.Point(146, 46);
            this.msk_yoneticino.Mask = "000000";
            this.msk_yoneticino.Name = "msk_yoneticino";
            this.msk_yoneticino.Size = new System.Drawing.Size(100, 20);
            this.msk_yoneticino.TabIndex = 1;
            this.msk_yoneticino.ValidatingType = typeof(int);
            // 
            // txt_yoneticiad
            // 
            this.txt_yoneticiad.Location = new System.Drawing.Point(146, 72);
            this.txt_yoneticiad.Name = "txt_yoneticiad";
            this.txt_yoneticiad.Size = new System.Drawing.Size(100, 20);
            this.txt_yoneticiad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yönetici Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yönetici Soyadı :";
            // 
            // txt_yoneticisoyad
            // 
            this.txt_yoneticisoyad.Location = new System.Drawing.Point(146, 98);
            this.txt_yoneticisoyad.Name = "txt_yoneticisoyad";
            this.txt_yoneticisoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_yoneticisoyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yönetici Parola :";
            // 
            // txt_yoneticiparola
            // 
            this.txt_yoneticiparola.Location = new System.Drawing.Point(146, 124);
            this.txt_yoneticiparola.Name = "txt_yoneticiparola";
            this.txt_yoneticiparola.Size = new System.Drawing.Size(100, 20);
            this.txt_yoneticiparola.TabIndex = 6;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelle.Location = new System.Drawing.Point(146, 150);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 23);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // frm_yoneticibilgiguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_yoneticiparola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_yoneticisoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yoneticiad);
            this.Controls.Add(this.msk_yoneticino);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_yoneticibilgiguncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİLGİLERİ GÜNCELLE";
            this.Load += new System.EventHandler(this.frm_yoneticibilgiguncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_yoneticino;
        private System.Windows.Forms.TextBox txt_yoneticiad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yoneticisoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yoneticiparola;
        private System.Windows.Forms.Button btn_guncelle;
    }
}