namespace Ogrenci_Not_Kayit_Sistemi
{
    partial class FrmGiris
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
            this.mskOgrNo = new System.Windows.Forms.MaskedTextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numara:";
            // 
            // mskOgrNo
            // 
            this.mskOgrNo.Location = new System.Drawing.Point(161, 39);
            this.mskOgrNo.Mask = "0000";
            this.mskOgrNo.Name = "mskOgrNo";
            this.mskOgrNo.Size = new System.Drawing.Size(100, 20);
            this.mskOgrNo.TabIndex = 1;
            this.mskOgrNo.TextChanged += new System.EventHandler(this.mskOgrNo_TextChanged);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.Location = new System.Drawing.Point(117, 83);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(76, 29);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 140);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.mskOgrNo);
            this.Controls.Add(this.label1);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskOgrNo;
        private System.Windows.Forms.Button BtnGiris;
    }
}

