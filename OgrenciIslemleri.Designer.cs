namespace OgrenciTrankriptSistemi
{
    partial class OgrenciIslemleri
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
            txtOgrenciAd = new TextBox();
            txtOgrenciSoyad = new TextBox();
            btnEkle = new Button();
            lstOgrenci = new ListBox();
            cmbDersler = new ComboBox();
            cmbDonemler = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(116, 56);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(130, 23);
            txtOgrenciAd.TabIndex = 0;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(116, 104);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(130, 23);
            txtOgrenciSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(116, 266);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstOgrenci
            // 
            lstOgrenci.FormattingEnabled = true;
            lstOgrenci.ItemHeight = 15;
            lstOgrenci.Location = new Point(314, 56);
            lstOgrenci.Name = "lstOgrenci";
            lstOgrenci.Size = new Size(437, 214);
            lstOgrenci.TabIndex = 3;
            lstOgrenci.SelectedIndexChanged += lstOgrenci_SelectedIndexChanged;
            // 
            // cmbDersler
            // 
            cmbDersler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDersler.FormattingEnabled = true;
            cmbDersler.Location = new Point(116, 201);
            cmbDersler.Name = "cmbDersler";
            cmbDersler.Size = new Size(131, 23);
            cmbDersler.TabIndex = 4;
            // 
            // cmbDonemler
            // 
            cmbDonemler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonemler.FormattingEnabled = true;
            cmbDonemler.Location = new Point(115, 153);
            cmbDonemler.Name = "cmbDonemler";
            cmbDonemler.Size = new Size(131, 23);
            cmbDonemler.TabIndex = 5;
            cmbDonemler.SelectedIndexChanged += cmbDonemler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Öğrenci Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 107);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Öğrenci Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 204);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Dersler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 156);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Donemler";
            // 
            // OgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDonemler);
            Controls.Add(cmbDersler);
            Controls.Add(lstOgrenci);
            Controls.Add(btnEkle);
            Controls.Add(txtOgrenciSoyad);
            Controls.Add(txtOgrenciAd);
            Name = "OgrenciIslemleri";
            Text = "OgrenciIslemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOgrenciAd;
        private TextBox txtOgrenciSoyad;
        private Button btnEkle;
        private ListBox lstOgrenci;
        private ComboBox cmbDersler;
        private ComboBox cmbDonemler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}