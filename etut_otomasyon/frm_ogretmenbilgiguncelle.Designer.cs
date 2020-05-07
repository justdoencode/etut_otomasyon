namespace etut_otomasyon
{
    partial class frm_ogretmenbilgiguncelle
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
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ogretmenparola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ogretmensoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogretmenad = new System.Windows.Forms.TextBox();
            this.msk_ogretmenno = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelle.Location = new System.Drawing.Point(145, 142);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 23);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Öğretmen Parola :";
            // 
            // txt_ogretmenparola
            // 
            this.txt_ogretmenparola.Location = new System.Drawing.Point(145, 116);
            this.txt_ogretmenparola.Name = "txt_ogretmenparola";
            this.txt_ogretmenparola.Size = new System.Drawing.Size(100, 20);
            this.txt_ogretmenparola.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Öğretmen Soyadı :";
            // 
            // txt_ogretmensoyad
            // 
            this.txt_ogretmensoyad.Location = new System.Drawing.Point(145, 90);
            this.txt_ogretmensoyad.Name = "txt_ogretmensoyad";
            this.txt_ogretmensoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_ogretmensoyad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Öğretmen Adı :";
            // 
            // txt_ogretmenad
            // 
            this.txt_ogretmenad.Location = new System.Drawing.Point(145, 64);
            this.txt_ogretmenad.Name = "txt_ogretmenad";
            this.txt_ogretmenad.Size = new System.Drawing.Size(100, 20);
            this.txt_ogretmenad.TabIndex = 11;
            // 
            // msk_ogretmenno
            // 
            this.msk_ogretmenno.Enabled = false;
            this.msk_ogretmenno.Location = new System.Drawing.Point(145, 38);
            this.msk_ogretmenno.Mask = "000";
            this.msk_ogretmenno.Name = "msk_ogretmenno";
            this.msk_ogretmenno.Size = new System.Drawing.Size(100, 20);
            this.msk_ogretmenno.TabIndex = 10;
            this.msk_ogretmenno.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğretmen Numarası :";
            // 
            // frm_ogretmenbilgiguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 195);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ogretmenparola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ogretmensoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ogretmenad);
            this.Controls.Add(this.msk_ogretmenno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ogretmenbilgiguncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ogretmenbilgiguncelle";
            this.Load += new System.EventHandler(this.frm_ogretmenbilgiguncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ogretmenparola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ogretmensoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogretmenad;
        private System.Windows.Forms.MaskedTextBox msk_ogretmenno;
        private System.Windows.Forms.Label label1;
    }
}