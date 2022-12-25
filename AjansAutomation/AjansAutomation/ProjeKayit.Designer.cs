namespace AjansAutomation
{
    partial class ProjeKayit
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textProjeadi = new System.Windows.Forms.TextBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textOyuncular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textButce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textKonu = new System.Windows.Forms.TextBox();
            this.pictureAfis = new System.Windows.Forms.PictureBox();
            this.btnAfisEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(12, 744);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 38);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::AjansAutomation.Properties.Resources.exit;
            this.pictureExit.Location = new System.Drawing.Point(12, 677);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(70, 70);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 43;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(587, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 38);
            this.label11.TabIndex = 45;
            this.label11.Text = "Yeni Proje Ekle";
            // 
            // textProjeadi
            // 
            this.textProjeadi.Location = new System.Drawing.Point(228, 118);
            this.textProjeadi.Name = "textProjeadi";
            this.textProjeadi.Size = new System.Drawing.Size(247, 22);
            this.textProjeadi.TabIndex = 46;
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "Belgesel",
            "Dizi",
            "Film"});
            this.comboTur.Location = new System.Drawing.Point(228, 171);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(247, 24);
            this.comboTur.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Proje Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Proje Türü";
            // 
            // textOyuncular
            // 
            this.textOyuncular.Location = new System.Drawing.Point(228, 260);
            this.textOyuncular.Multiline = true;
            this.textOyuncular.Name = "textOyuncular";
            this.textOyuncular.Size = new System.Drawing.Size(387, 153);
            this.textOyuncular.TabIndex = 50;
            this.textOyuncular.TextChanged += new System.EventHandler(this.textOyuncular_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Oyuncu Kadrosu";
            // 
            // textButce
            // 
            this.textButce.Location = new System.Drawing.Point(228, 218);
            this.textButce.Name = "textButce";
            this.textButce.Size = new System.Drawing.Size(247, 22);
            this.textButce.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Bütçe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Proje Konusu";
            // 
            // textKonu
            // 
            this.textKonu.Location = new System.Drawing.Point(228, 445);
            this.textKonu.Multiline = true;
            this.textKonu.Name = "textKonu";
            this.textKonu.Size = new System.Drawing.Size(387, 153);
            this.textKonu.TabIndex = 54;
            // 
            // pictureAfis
            // 
            this.pictureAfis.Location = new System.Drawing.Point(943, 111);
            this.pictureAfis.Name = "pictureAfis";
            this.pictureAfis.Size = new System.Drawing.Size(359, 374);
            this.pictureAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAfis.TabIndex = 56;
            this.pictureAfis.TabStop = false;
            // 
            // btnAfisEkle
            // 
            this.btnAfisEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAfisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAfisEkle.Location = new System.Drawing.Point(1030, 501);
            this.btnAfisEkle.Name = "btnAfisEkle";
            this.btnAfisEkle.Size = new System.Drawing.Size(199, 53);
            this.btnAfisEkle.TabIndex = 57;
            this.btnAfisEkle.Text = "AFİŞ EKLE";
            this.btnAfisEkle.UseVisualStyleBackColor = false;
            this.btnAfisEkle.Click += new System.EventHandler(this.btnAfisEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(400, 631);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(199, 53);
            this.btnEkle.TabIndex = 58;
            this.btnEkle.Text = "KAYDI EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ProjeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1409, 793);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnAfisEkle);
            this.Controls.Add(this.pictureAfis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textKonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textButce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOyuncular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.textProjeadi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureExit);
            this.Name = "ProjeKayit";
            this.Text = "ProjeKayit";
            this.Load += new System.EventHandler(this.ProjeKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textProjeadi;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOyuncular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textButce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textKonu;
        private System.Windows.Forms.PictureBox pictureAfis;
        private System.Windows.Forms.Button btnAfisEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEkle;
    }
}