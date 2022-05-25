
namespace Eczane_Otomasyonu
{
    partial class girisForm
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbKlogo = new System.Windows.Forms.PictureBox();
            this.pbSlogo = new System.Windows.Forms.PictureBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pbKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::Eczane_Otomasyonu.Properties.Resources.logo1;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(115, 62);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(64, 64);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbKlogo
            // 
            this.pbKlogo.BackgroundImage = global::Eczane_Otomasyonu.Properties.Resources.kadi_logo;
            this.pbKlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKlogo.Location = new System.Drawing.Point(36, 164);
            this.pbKlogo.Name = "pbKlogo";
            this.pbKlogo.Size = new System.Drawing.Size(24, 24);
            this.pbKlogo.TabIndex = 1;
            this.pbKlogo.TabStop = false;
            // 
            // pbSlogo
            // 
            this.pbSlogo.BackgroundImage = global::Eczane_Otomasyonu.Properties.Resources.sifrelogo;
            this.pbSlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlogo.Location = new System.Drawing.Point(36, 210);
            this.pbSlogo.Name = "pbSlogo";
            this.pbSlogo.Size = new System.Drawing.Size(24, 24);
            this.pbSlogo.TabIndex = 2;
            this.pbSlogo.TabStop = false;
            // 
            // txtKadi
            // 
            this.txtKadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txtKadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKadi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKadi.ForeColor = System.Drawing.SystemColors.Window;
            this.txtKadi.Location = new System.Drawing.Point(66, 171);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(190, 17);
            this.txtKadi.TabIndex = 2;
            this.txtKadi.TabStop = false;
            this.txtKadi.Text = "Kullanıcı Adı";
            this.txtKadi.Click += new System.EventHandler(this.txtKadi_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSifre.Location = new System.Drawing.Point(66, 217);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(190, 17);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.TabStop = false;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(36, 194);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(220, 1);
            this.pnl1.TabIndex = 5;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(36, 240);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(220, 1);
            this.pnl2.TabIndex = 6;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.btnGiris.Location = new System.Drawing.Point(51, 267);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(190, 32);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pbKapat
            // 
            this.pbKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pbKapat.BackgroundImage = global::Eczane_Otomasyonu.Properties.Resources.KptLogo;
            this.pbKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbKapat.Location = new System.Drawing.Point(269, 1);
            this.pbKapat.Name = "pbKapat";
            this.pbKapat.Size = new System.Drawing.Size(28, 24);
            this.pbKapat.TabIndex = 8;
            this.pbKapat.TabStop = false;
            this.pbKapat.Click += new System.EventHandler(this.pbKapat_Click);
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(297, 392);
            this.Controls.Add(this.pbKapat);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.pbSlogo);
            this.Controls.Add(this.pbKlogo);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.girisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbKlogo;
        private System.Windows.Forms.PictureBox pbSlogo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pbKapat;
        public System.Windows.Forms.TextBox txtKadi;
    }
}

