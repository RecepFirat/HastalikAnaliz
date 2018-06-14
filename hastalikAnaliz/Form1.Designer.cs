namespace hastalikAnaliz
{
    partial class Ana_Main
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
            this.Btn_Anket_Sonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Anket_Sonuc
            // 
            this.Btn_Anket_Sonuc.Location = new System.Drawing.Point(33, 424);
            this.Btn_Anket_Sonuc.Name = "Btn_Anket_Sonuc";
            this.Btn_Anket_Sonuc.Size = new System.Drawing.Size(130, 55);
            this.Btn_Anket_Sonuc.TabIndex = 0;
            this.Btn_Anket_Sonuc.Text = "Anket Sonuc Gör";
            this.Btn_Anket_Sonuc.UseVisualStyleBackColor = true;
            this.Btn_Anket_Sonuc.Click += new System.EventHandler(this.Btn_Anket_Sonuc_Click);
            // 
            // Ana_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.Btn_Anket_Sonuc);
            this.Name = "Ana_Main";
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Anket_Sonuc;
    }
}

