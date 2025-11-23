namespace MatematikOyunu
{
    partial class OyunForm
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
            this.components = new System.ComponentModel.Container();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnCevaplariKontrolEt = new System.Windows.Forms.Button();
            this.lblSoru1 = new System.Windows.Forms.Label();
            this.lblSoru2 = new System.Windows.Forms.Label();
            this.lblSoru3 = new System.Windows.Forms.Label();
            this.lblSoru4 = new System.Windows.Forms.Label();
            this.lblSoru5 = new System.Windows.Forms.Label();
            this.txtCevap1 = new System.Windows.Forms.TextBox();
            this.txtCevap2 = new System.Windows.Forms.TextBox();
            this.txtCevap3 = new System.Windows.Forms.TextBox();
            this.txtCevap4 = new System.Windows.Forms.TextBox();
            this.txtCevap5 = new System.Windows.Forms.TextBox();
            this.chkPas1 = new System.Windows.Forms.CheckBox();
            this.chkPas2 = new System.Windows.Forms.CheckBox();
            this.chkPas3 = new System.Windows.Forms.CheckBox();
            this.chkPas4 = new System.Windows.Forms.CheckBox();
            this.chkPas5 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKaydetVeCik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeviye
            // 
            this.lblSeviye.AutoSize = true;
            this.lblSeviye.Location = new System.Drawing.Point(65, 41);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(62, 16);
            this.lblSeviye.TabIndex = 0;
            this.lblSeviye.Text = "Seviye: 1";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(589, 41);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(51, 16);
            this.lblPuan.TabIndex = 0;
            this.lblPuan.Text = "Puan: 0";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Location = new System.Drawing.Point(324, 41);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(55, 16);
            this.lblKalanSure.TabIndex = 0;
            this.lblKalanSure.Text = "Süre: 60";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDurum.Location = new System.Drawing.Point(65, 505);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(117, 16);
            this.lblDurum.TabIndex = 0;
            this.lblDurum.Text = "Doğru: 0 - Yanlış: 0";
            // 
            // btnCevaplariKontrolEt
            // 
            this.btnCevaplariKontrolEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCevaplariKontrolEt.Location = new System.Drawing.Point(286, 492);
            this.btnCevaplariKontrolEt.Name = "btnCevaplariKontrolEt";
            this.btnCevaplariKontrolEt.Size = new System.Drawing.Size(176, 42);
            this.btnCevaplariKontrolEt.TabIndex = 2;
            this.btnCevaplariKontrolEt.Text = "Cevapları Kontrol Et";
            this.btnCevaplariKontrolEt.UseVisualStyleBackColor = false;
            this.btnCevaplariKontrolEt.Click += new System.EventHandler(this.btnCevaplariKontrolEt_Click);
            // 
            // lblSoru1
            // 
            this.lblSoru1.AutoSize = true;
            this.lblSoru1.Location = new System.Drawing.Point(65, 153);
            this.lblSoru1.Name = "lblSoru1";
            this.lblSoru1.Size = new System.Drawing.Size(85, 16);
            this.lblSoru1.TabIndex = 3;
            this.lblSoru1.Text = "1)  15 + 28 = ?";
            // 
            // lblSoru2
            // 
            this.lblSoru2.AutoSize = true;
            this.lblSoru2.Location = new System.Drawing.Point(65, 206);
            this.lblSoru2.Name = "lblSoru2";
            this.lblSoru2.Size = new System.Drawing.Size(82, 16);
            this.lblSoru2.TabIndex = 3;
            this.lblSoru2.Text = "2)  45 - 12 = ?";
            // 
            // lblSoru3
            // 
            this.lblSoru3.AutoSize = true;
            this.lblSoru3.Location = new System.Drawing.Point(65, 264);
            this.lblSoru3.Name = "lblSoru3";
            this.lblSoru3.Size = new System.Drawing.Size(70, 16);
            this.lblSoru3.TabIndex = 3;
            this.lblSoru3.Text = "3)  8 x 7 = ?";
            // 
            // lblSoru4
            // 
            this.lblSoru4.AutoSize = true;
            this.lblSoru4.Location = new System.Drawing.Point(65, 320);
            this.lblSoru4.Name = "lblSoru4";
            this.lblSoru4.Size = new System.Drawing.Size(75, 16);
            this.lblSoru4.TabIndex = 3;
            this.lblSoru4.Text = "4)  72 / 9 = ?";
            // 
            // lblSoru5
            // 
            this.lblSoru5.AutoSize = true;
            this.lblSoru5.Location = new System.Drawing.Point(65, 372);
            this.lblSoru5.Name = "lblSoru5";
            this.lblSoru5.Size = new System.Drawing.Size(85, 16);
            this.lblSoru5.TabIndex = 3;
            this.lblSoru5.Text = "5)  33 + 18 = ?";
            // 
            // txtCevap1
            // 
            this.txtCevap1.Location = new System.Drawing.Point(306, 147);
            this.txtCevap1.Name = "txtCevap1";
            this.txtCevap1.Size = new System.Drawing.Size(100, 22);
            this.txtCevap1.TabIndex = 4;
            // 
            // txtCevap2
            // 
            this.txtCevap2.Location = new System.Drawing.Point(306, 200);
            this.txtCevap2.Name = "txtCevap2";
            this.txtCevap2.Size = new System.Drawing.Size(100, 22);
            this.txtCevap2.TabIndex = 4;
            // 
            // txtCevap3
            // 
            this.txtCevap3.Location = new System.Drawing.Point(306, 258);
            this.txtCevap3.Name = "txtCevap3";
            this.txtCevap3.Size = new System.Drawing.Size(100, 22);
            this.txtCevap3.TabIndex = 4;
            // 
            // txtCevap4
            // 
            this.txtCevap4.Location = new System.Drawing.Point(306, 314);
            this.txtCevap4.Name = "txtCevap4";
            this.txtCevap4.Size = new System.Drawing.Size(100, 22);
            this.txtCevap4.TabIndex = 4;
            // 
            // txtCevap5
            // 
            this.txtCevap5.Location = new System.Drawing.Point(306, 366);
            this.txtCevap5.Name = "txtCevap5";
            this.txtCevap5.Size = new System.Drawing.Size(100, 22);
            this.txtCevap5.TabIndex = 4;
            // 
            // chkPas1
            // 
            this.chkPas1.AutoSize = true;
            this.chkPas1.Location = new System.Drawing.Point(592, 147);
            this.chkPas1.Name = "chkPas1";
            this.chkPas1.Size = new System.Drawing.Size(56, 20);
            this.chkPas1.TabIndex = 5;
            this.chkPas1.Text = "PAS";
            this.chkPas1.UseVisualStyleBackColor = true;
            this.chkPas1.CheckedChanged += new System.EventHandler(this.chkPas1_CheckedChanged);
            // 
            // chkPas2
            // 
            this.chkPas2.AutoSize = true;
            this.chkPas2.Location = new System.Drawing.Point(592, 200);
            this.chkPas2.Name = "chkPas2";
            this.chkPas2.Size = new System.Drawing.Size(56, 20);
            this.chkPas2.TabIndex = 5;
            this.chkPas2.Text = "PAS";
            this.chkPas2.UseVisualStyleBackColor = true;
            this.chkPas2.CheckedChanged += new System.EventHandler(this.chkPas2_CheckedChanged);
            // 
            // chkPas3
            // 
            this.chkPas3.AutoSize = true;
            this.chkPas3.Location = new System.Drawing.Point(592, 258);
            this.chkPas3.Name = "chkPas3";
            this.chkPas3.Size = new System.Drawing.Size(56, 20);
            this.chkPas3.TabIndex = 5;
            this.chkPas3.Text = "PAS";
            this.chkPas3.UseVisualStyleBackColor = true;
            this.chkPas3.CheckedChanged += new System.EventHandler(this.chkPas3_CheckedChanged);
            // 
            // chkPas4
            // 
            this.chkPas4.AutoSize = true;
            this.chkPas4.Location = new System.Drawing.Point(592, 314);
            this.chkPas4.Name = "chkPas4";
            this.chkPas4.Size = new System.Drawing.Size(56, 20);
            this.chkPas4.TabIndex = 5;
            this.chkPas4.Text = "PAS";
            this.chkPas4.UseVisualStyleBackColor = true;
            this.chkPas4.CheckedChanged += new System.EventHandler(this.chkPas4_CheckedChanged);
            // 
            // chkPas5
            // 
            this.chkPas5.AutoSize = true;
            this.chkPas5.Location = new System.Drawing.Point(592, 368);
            this.chkPas5.Name = "chkPas5";
            this.chkPas5.Size = new System.Drawing.Size(56, 20);
            this.chkPas5.TabIndex = 5;
            this.chkPas5.Text = "PAS";
            this.chkPas5.UseVisualStyleBackColor = true;
            this.chkPas5.CheckedChanged += new System.EventHandler(this.chkPas5_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKaydetVeCik
            // 
            this.btnKaydetVeCik.Location = new System.Drawing.Point(523, 492);
            this.btnKaydetVeCik.Name = "btnKaydetVeCik";
            this.btnKaydetVeCik.Size = new System.Drawing.Size(170, 42);
            this.btnKaydetVeCik.TabIndex = 6;
            this.btnKaydetVeCik.Text = "Kaydet  ve  Çık";
            this.btnKaydetVeCik.UseVisualStyleBackColor = true;
            this.btnKaydetVeCik.Click += new System.EventHandler(this.btnKaydetVeCik_Click);
            // 
            // OyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 645);
            this.Controls.Add(this.btnKaydetVeCik);
            this.Controls.Add(this.chkPas5);
            this.Controls.Add(this.chkPas4);
            this.Controls.Add(this.chkPas3);
            this.Controls.Add(this.chkPas2);
            this.Controls.Add(this.chkPas1);
            this.Controls.Add(this.txtCevap5);
            this.Controls.Add(this.txtCevap4);
            this.Controls.Add(this.txtCevap3);
            this.Controls.Add(this.txtCevap2);
            this.Controls.Add(this.txtCevap1);
            this.Controls.Add(this.lblSoru5);
            this.Controls.Add(this.lblSoru4);
            this.Controls.Add(this.lblSoru3);
            this.Controls.Add(this.lblSoru2);
            this.Controls.Add(this.lblSoru1);
            this.Controls.Add(this.btnCevaplariKontrolEt);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblSeviye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OyunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matematik Oyunu";
            this.Load += new System.EventHandler(this.OyunForm_Load);
            this.VisibleChanged += new System.EventHandler(this.OyunForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnCevaplariKontrolEt;
        private System.Windows.Forms.Label lblSoru1;
        private System.Windows.Forms.Label lblSoru2;
        private System.Windows.Forms.Label lblSoru3;
        private System.Windows.Forms.Label lblSoru4;
        private System.Windows.Forms.Label lblSoru5;
        private System.Windows.Forms.TextBox txtCevap1;
        private System.Windows.Forms.TextBox txtCevap2;
        private System.Windows.Forms.TextBox txtCevap3;
        private System.Windows.Forms.TextBox txtCevap4;
        private System.Windows.Forms.TextBox txtCevap5;
        private System.Windows.Forms.CheckBox chkPas1;
        private System.Windows.Forms.CheckBox chkPas2;
        private System.Windows.Forms.CheckBox chkPas3;
        private System.Windows.Forms.CheckBox chkPas4;
        private System.Windows.Forms.CheckBox chkPas5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKaydetVeCik;
    }
}