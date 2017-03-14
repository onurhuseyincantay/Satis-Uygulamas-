namespace NYP_Final_Projesi
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblKlncID = new System.Windows.Forms.Label();
            this.txtkullaniciID = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.chkSfrGstr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKlncID
            // 
            this.lblKlncID.AutoSize = true;
            this.lblKlncID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.lblKlncID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblKlncID.Location = new System.Drawing.Point(34, 103);
            this.lblKlncID.Name = "lblKlncID";
            this.lblKlncID.Size = new System.Drawing.Size(254, 48);
            this.lblKlncID.TabIndex = 0;
            this.lblKlncID.Text = "Kullanici ID :";
            // 
            // txtkullaniciID
            // 
            this.txtkullaniciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtkullaniciID.Location = new System.Drawing.Point(371, 110);
            this.txtkullaniciID.Multiline = true;
            this.txtkullaniciID.Name = "txtkullaniciID";
            this.txtkullaniciID.Size = new System.Drawing.Size(171, 45);
            this.txtkullaniciID.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSifre.Location = new System.Drawing.Point(371, 191);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(171, 45);
            this.txtSifre.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.lblSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblSifre.Location = new System.Drawing.Point(158, 184);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(130, 48);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Sifre :";
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = global::NYP_Final_Projesi.Properties.Resources.Button;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Location = new System.Drawing.Point(229, 257);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(133, 43);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // chkSfrGstr
            // 
            this.chkSfrGstr.AutoSize = true;
            this.chkSfrGstr.BackgroundImage = global::NYP_Final_Projesi.Properties.Resources.GirisArkaplan;
            this.chkSfrGstr.Location = new System.Drawing.Point(426, 279);
            this.chkSfrGstr.Name = "chkSfrGstr";
            this.chkSfrGstr.Size = new System.Drawing.Size(116, 21);
            this.chkSfrGstr.TabIndex = 5;
            this.chkSfrGstr.Text = "Şifreyi Göster";
            this.chkSfrGstr.UseVisualStyleBackColor = true;
            this.chkSfrGstr.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(179, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sisteme Giriş";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NYP_Final_Projesi.Properties.Resources.GirisArkaplan;
            this.ClientSize = new System.Drawing.Size(642, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSfrGstr);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtkullaniciID);
            this.Controls.Add(this.lblKlncID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NYP Final Projesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlncID;
        private System.Windows.Forms.TextBox txtkullaniciID;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.CheckBox chkSfrGstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
    }
}

