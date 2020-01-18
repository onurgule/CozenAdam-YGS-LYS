namespace CozenAdam_YGS_LYS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbKitap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCozum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wb1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap:";
            // 
            // cbKitap
            // 
            this.cbKitap.Enabled = false;
            this.cbKitap.FormattingEnabled = true;
            this.cbKitap.Items.AddRange(new object[] {
            "Karekök Matematik YGS"});
            this.cbKitap.Location = new System.Drawing.Point(12, 48);
            this.cbKitap.Name = "cbKitap";
            this.cbKitap.Size = new System.Drawing.Size(221, 24);
            this.cbKitap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayfa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soru:";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(15, 100);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(45, 22);
            this.txtSayfa.TabIndex = 4;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(85, 99);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(45, 22);
            this.txtSoru.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // btnCozum
            // 
            this.btnCozum.Location = new System.Drawing.Point(137, 95);
            this.btnCozum.Name = "btnCozum";
            this.btnCozum.Size = new System.Drawing.Size(96, 27);
            this.btnCozum.TabIndex = 7;
            this.btnCozum.Text = "Çözüm";
            this.btnCozum.UseVisualStyleBackColor = true;
            this.btnCozum.Click += new System.EventHandler(this.btnCozum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CozenAdam_YGS_LYS.Properties.Resources.CA_logo_64;
            this.pictureBox1.Location = new System.Drawing.Point(907, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // wb1
            // 
            this.wb1.Location = new System.Drawing.Point(246, 13);
            this.wb1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb1.Name = "wb1";
            this.wb1.Size = new System.Drawing.Size(706, 395);
            this.wb1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 196);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 457);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wb1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCozum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKitap);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Çözen Adam YGS LYS Çözümleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCozum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser wb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

