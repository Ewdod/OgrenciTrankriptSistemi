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
            btnGuncelle = new Button();
            btnSil = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDonem = new TextBox();
            SuspendLayout();
            // 
            // lstDerslerListesi
            // 
            lstDerslerListesi.FormattingEnabled = true;
            lstDerslerListesi.ItemHeight = 15;
            lstDerslerListesi.Location = new Point(290, 49);
            lstDerslerListesi.Name = "lstDerslerListesi";
            lstDerslerListesi.Size = new Size(382, 334);
            lstDerslerListesi.TabIndex = 0;
            lstDerslerListesi.SelectedIndexChanged += lstDerslerListesi_SelectedIndexChanged;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(115, 49);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(143, 23);
            txtDersAdi.TabIndex = 1;
            // 
            // txtDersKisaltma
            // 
            txtDersKisaltma.Location = new Point(115, 105);
            txtDersKisaltma.Name = "txtDersKisaltma";
            txtDersKisaltma.Size = new Size(143, 23);
            txtDersKisaltma.TabIndex = 2;
            // 
            // txtDersKredi
            // 
            txtDersKredi.Location = new Point(115, 161);
            txtDersKredi.Name = "txtDersKredi";
            txtDersKredi.Size = new Size(143, 23);
            txtDersKredi.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(115, 277);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(143, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Enabled = false;
            btnGuncelle.Location = new Point(115, 317);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(143, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Enabled = false;
            btnSil.Location = new Point(115, 360);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(143, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Ders Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 8;
            label2.Text = "Ders Kısaltması:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Ders Kredisi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Dönem:";
            // 
            // txtDonem
            // 
            txtDonem.Location = new Point(115, 216);
            txtDonem.Name = "txtDonem";
            txtDonem.Size = new Size(143, 23);
            txtDonem.TabIndex = 12;
            // 
            // DersIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 419);
            Controls.Add(txtDonem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtDersKredi);
            Controls.Add(txtDersKisaltma);
            Controls.Add(txtDersAdi);
            Controls.Add(lstDerslerListesi);
            Name = "DersIslemleri";
            Text = "Ders İşlemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDerslerListesi;
        private TextBox txtDersAdi;
        private TextBox txtDersKisaltma;
        private TextBox txtDersKredi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDonem;
    }
}