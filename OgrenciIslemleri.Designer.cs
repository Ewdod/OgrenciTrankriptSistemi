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
            button1 = new Button();
            listBox1 = new ListBox();
            cmbDersler = new ComboBox();
            cmbDonemler = new ComboBox();
            SuspendLayout();
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(78, 56);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(130, 23);
            txtOgrenciAd.TabIndex = 0;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(78, 104);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(130, 23);
            txtOgrenciSoyad.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(77, 266);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 2;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(314, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(437, 214);
            listBox1.TabIndex = 3;
            // 
            // cmbDersler
            // 
            cmbDersler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDersler.FormattingEnabled = true;
            cmbDersler.Location = new Point(78, 158);
            cmbDersler.Name = "cmbDersler";
            cmbDersler.Size = new Size(131, 23);
            cmbDersler.TabIndex = 4;
            // 
            // cmbDonemler
            // 
            cmbDonemler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonemler.FormattingEnabled = true;
            cmbDonemler.Location = new Point(76, 211);
            cmbDonemler.Name = "cmbDonemler";
            cmbDonemler.Size = new Size(131, 23);
            cmbDonemler.TabIndex = 5;
            // 
            // OgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDonemler);
            Controls.Add(cmbDersler);
            Controls.Add(listBox1);
            Controls.Add(button1);
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
        private Button button1;
        private ListBox listBox1;
        private ComboBox cmbDersler;
        private ComboBox cmbDonemler;
    }
}