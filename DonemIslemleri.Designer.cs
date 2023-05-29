namespace OgrenciTrankriptSistemi
{
    partial class DonemIslemleri
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
            txtKacinciDonem = new TextBox();
            lstDonemler = new ListBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // txtKacinciDonem
            // 
            txtKacinciDonem.Location = new Point(90, 57);
            txtKacinciDonem.Name = "txtKacinciDonem";
            txtKacinciDonem.Size = new Size(160, 23);
            txtKacinciDonem.TabIndex = 0;
            // 
            // lstDonemler
            // 
            lstDonemler.FormattingEnabled = true;
            lstDonemler.ItemHeight = 15;
            lstDonemler.Location = new Point(380, 57);
            lstDonemler.Name = "lstDonemler";
            lstDonemler.Size = new Size(324, 229);
            lstDonemler.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(90, 142);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(160, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // DonemIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEkle);
            Controls.Add(lstDonemler);
            Controls.Add(txtKacinciDonem);
            Name = "DonemIslemleri";
            Text = "DonemIslemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKacinciDonem;
        private ListBox lstDonemler;
        private Button btnEkle;
    }
}