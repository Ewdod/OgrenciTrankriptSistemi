namespace OgrenciTrankriptSistemi
{
    partial class DersIslemleri
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
            lstDerslerListesi = new ListBox();
            txtDersAdi = new TextBox();
            txtDersKisaltma = new TextBox();
            txtDersKredi = new TextBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // lstDerslerListesi
            // 
            lstDerslerListesi.FormattingEnabled = true;
            lstDerslerListesi.ItemHeight = 15;
            lstDerslerListesi.Location = new Point(371, 105);
            lstDerslerListesi.Name = "lstDerslerListesi";
            lstDerslerListesi.Size = new Size(328, 244);
            lstDerslerListesi.TabIndex = 0;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(76, 105);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(143, 23);
            txtDersAdi.TabIndex = 1;
            // 
            // txtDersKisaltma
            // 
            txtDersKisaltma.Location = new Point(76, 161);
            txtDersKisaltma.Name = "txtDersKisaltma";
            txtDersKisaltma.Size = new Size(143, 23);
            txtDersKisaltma.TabIndex = 2;
            // 
            // txtDersKredi
            // 
            txtDersKredi.Location = new Point(76, 217);
            txtDersKredi.Name = "txtDersKredi";
            txtDersKredi.Size = new Size(143, 23);
            txtDersKredi.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(76, 312);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(143, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "button1";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // DersIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEkle);
            Controls.Add(txtDersKredi);
            Controls.Add(txtDersKisaltma);
            Controls.Add(txtDersAdi);
            Controls.Add(lstDerslerListesi);
            Name = "DersIslemleri";
            Text = "DersIslemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDerslerListesi;
        private TextBox txtDersAdi;
        private TextBox txtDersKisaltma;
        private TextBox txtDersKredi;
        private Button btnEkle;
    }
}