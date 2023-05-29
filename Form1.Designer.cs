namespace OgrenciTrankriptSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOgrenciIslemleri = new Button();
            btnDersIslemleri = new Button();
            btnDonemIslemleri = new Button();
            SuspendLayout();
            // 
            // btnOgrenciIslemleri
            // 
            btnOgrenciIslemleri.Location = new Point(56, 54);
            btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            btnOgrenciIslemleri.Size = new Size(149, 23);
            btnOgrenciIslemleri.TabIndex = 0;
            btnOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            btnOgrenciIslemleri.UseVisualStyleBackColor = true;
            btnOgrenciIslemleri.Click += btnOgrenciIslemleri_Click;
            // 
            // btnDersIslemleri
            // 
            btnDersIslemleri.Location = new Point(56, 97);
            btnDersIslemleri.Name = "btnDersIslemleri";
            btnDersIslemleri.Size = new Size(149, 23);
            btnDersIslemleri.TabIndex = 1;
            btnDersIslemleri.Text = "Ders İşlemleri";
            btnDersIslemleri.UseVisualStyleBackColor = true;
            btnDersIslemleri.Click += btnDersIslemleri_Click;
            // 
            // btnDonemIslemleri
            // 
            btnDonemIslemleri.Location = new Point(56, 141);
            btnDonemIslemleri.Name = "btnDonemIslemleri";
            btnDonemIslemleri.Size = new Size(149, 23);
            btnDonemIslemleri.TabIndex = 2;
            btnDonemIslemleri.Text = "Dönem İşlemleri";
            btnDonemIslemleri.UseVisualStyleBackColor = true;
            btnDonemIslemleri.Click += btnDonemIslemleri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 233);
            Controls.Add(btnDonemIslemleri);
            Controls.Add(btnDersIslemleri);
            Controls.Add(btnOgrenciIslemleri);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOgrenciIslemleri;
        private Button btnDersIslemleri;
        private Button btnDonemIslemleri;
    }
}