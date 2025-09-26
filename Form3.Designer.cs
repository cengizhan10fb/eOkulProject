namespace e_okul_veri_sistemi_uygulaması
{
    partial class Form_ogretmen_giris
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
            this.button_ogretmen_giris_kontrol = new System.Windows.Forms.Button();
            this.textBox_ogretmen_isim = new System.Windows.Forms.TextBox();
            this.textBox_ogretmen_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "öğretmen giriş sayfası";
            // 
            // button_ogretmen_giris_kontrol
            // 
            this.button_ogretmen_giris_kontrol.Location = new System.Drawing.Point(179, 260);
            this.button_ogretmen_giris_kontrol.Name = "button_ogretmen_giris_kontrol";
            this.button_ogretmen_giris_kontrol.Size = new System.Drawing.Size(104, 44);
            this.button_ogretmen_giris_kontrol.TabIndex = 1;
            this.button_ogretmen_giris_kontrol.Text = "giriş yap";
            this.button_ogretmen_giris_kontrol.UseVisualStyleBackColor = true;
            this.button_ogretmen_giris_kontrol.Click += new System.EventHandler(this.button_ogretmen_giris_kontrol_Click);
            // 
            // textBox_ogretmen_isim
            // 
            this.textBox_ogretmen_isim.Location = new System.Drawing.Point(179, 98);
            this.textBox_ogretmen_isim.Name = "textBox_ogretmen_isim";
            this.textBox_ogretmen_isim.Size = new System.Drawing.Size(122, 22);
            this.textBox_ogretmen_isim.TabIndex = 2;
            // 
            // textBox_ogretmen_sifre
            // 
            this.textBox_ogretmen_sifre.Location = new System.Drawing.Point(179, 164);
            this.textBox_ogretmen_sifre.Name = "textBox_ogretmen_sifre";
            this.textBox_ogretmen_sifre.Size = new System.Drawing.Size(122, 22);
            this.textBox_ogretmen_sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "kullanici adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "şifre :";
            // 
            // Form_ogretmen_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ogretmen_sifre);
            this.Controls.Add(this.textBox_ogretmen_isim);
            this.Controls.Add(this.button_ogretmen_giris_kontrol);
            this.Controls.Add(this.label1);
            this.Name = "Form_ogretmen_giris";
            this.Text = "e-okul öğretmen giriş sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ogretmen_giris_kontrol;
        private System.Windows.Forms.TextBox textBox_ogretmen_isim;
        private System.Windows.Forms.TextBox textBox_ogretmen_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}