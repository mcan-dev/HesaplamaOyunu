namespace MatematikOyunu
{
    partial class SkorForm
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
            this.lstSkorlar = new System.Windows.Forms.ListBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSkorlar
            // 
            this.lstSkorlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstSkorlar.FormattingEnabled = true;
            this.lstSkorlar.ItemHeight = 16;
            this.lstSkorlar.Location = new System.Drawing.Point(149, 12);
            this.lstSkorlar.Name = "lstSkorlar";
            this.lstSkorlar.Size = new System.Drawing.Size(437, 260);
            this.lstSkorlar.TabIndex = 0;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeriDon.Location = new System.Drawing.Point(169, 305);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(186, 45);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "Ana Menüye Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Cyan;
            this.btnTemizle.Location = new System.Drawing.Point(409, 305);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(152, 45);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Skorları Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // SkorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lstSkorlar);
            this.Name = "SkorForm";
            this.Text = "SkorForm";
            this.Load += new System.EventHandler(this.SkorForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSkorlar;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnTemizle;
    }
}