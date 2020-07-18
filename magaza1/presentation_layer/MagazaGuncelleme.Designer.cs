namespace magaza1.presentation_layer
{
    partial class MagazaGuncelleme
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
            this.sehirCbx = new System.Windows.Forms.ComboBox();
            this.ilceCbx = new System.Windows.Forms.ComboBox();
            this.mgzadCbx = new System.Windows.Forms.ComboBox();
            this.ymgzTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yiltsmTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.yetkiCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir:";
            // 
            // sehirCbx
            // 
            this.sehirCbx.FormattingEnabled = true;
            this.sehirCbx.Location = new System.Drawing.Point(127, 33);
            this.sehirCbx.Name = "sehirCbx";
            this.sehirCbx.Size = new System.Drawing.Size(124, 21);
            this.sehirCbx.TabIndex = 1;
            this.sehirCbx.SelectedIndexChanged += new System.EventHandler(this.sehirCbx_SelectedIndexChanged);
            // 
            // ilceCbx
            // 
            this.ilceCbx.FormattingEnabled = true;
            this.ilceCbx.Location = new System.Drawing.Point(127, 60);
            this.ilceCbx.Name = "ilceCbx";
            this.ilceCbx.Size = new System.Drawing.Size(124, 21);
            this.ilceCbx.TabIndex = 2;
            this.ilceCbx.SelectedIndexChanged += new System.EventHandler(this.ilceCbx_SelectedIndexChanged);
            // 
            // mgzadCbx
            // 
            this.mgzadCbx.FormattingEnabled = true;
            this.mgzadCbx.Location = new System.Drawing.Point(127, 87);
            this.mgzadCbx.Name = "mgzadCbx";
            this.mgzadCbx.Size = new System.Drawing.Size(124, 21);
            this.mgzadCbx.TabIndex = 3;
            this.mgzadCbx.SelectedIndexChanged += new System.EventHandler(this.mgzadCbx_SelectedIndexChanged);
            // 
            // ymgzTxt
            // 
            this.ymgzTxt.Location = new System.Drawing.Point(127, 137);
            this.ymgzTxt.Name = "ymgzTxt";
            this.ymgzTxt.Size = new System.Drawing.Size(124, 20);
            this.ymgzTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İlçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mağaza Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "İletişim Bilgileri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yeni Mağaza Adı:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Mağaza Değiştir";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(127, 273);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "İletişim Bilgisi Değiştir";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İletişim:";
            // 
            // yiltsmTxt
            // 
            this.yiltsmTxt.Location = new System.Drawing.Point(127, 296);
            this.yiltsmTxt.Multiline = true;
            this.yiltsmTxt.Name = "yiltsmTxt";
            this.yiltsmTxt.Size = new System.Drawing.Size(124, 65);
            this.yiltsmTxt.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Bilgileri Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(127, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 69);
            this.listBox1.TabIndex = 15;
            // 
            // yetkiCbx
            // 
            this.yetkiCbx.FormattingEnabled = true;
            this.yetkiCbx.Location = new System.Drawing.Point(127, 163);
            this.yetkiCbx.Name = "yetkiCbx";
            this.yetkiCbx.Size = new System.Drawing.Size(121, 21);
            this.yetkiCbx.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yetki Seçiniz:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(101, 165);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // MagazaGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 447);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yetkiCbx);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yiltsmTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ymgzTxt);
            this.Controls.Add(this.mgzadCbx);
            this.Controls.Add(this.ilceCbx);
            this.Controls.Add(this.sehirCbx);
            this.Controls.Add(this.label1);
            this.Name = "MagazaGuncelleme";
            this.Text = "MagazaGuncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sehirCbx;
        private System.Windows.Forms.ComboBox ilceCbx;
        private System.Windows.Forms.ComboBox mgzadCbx;
        private System.Windows.Forms.TextBox ymgzTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yiltsmTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox yetkiCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}