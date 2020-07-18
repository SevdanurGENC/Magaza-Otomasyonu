namespace magaza1.presentation_layer
{
    partial class UrunSil
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
            this.ktgrCbx = new System.Windows.Forms.ComboBox();
            this.urunCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ktgrCbx
            // 
            this.ktgrCbx.FormattingEnabled = true;
            this.ktgrCbx.Location = new System.Drawing.Point(140, 35);
            this.ktgrCbx.Name = "ktgrCbx";
            this.ktgrCbx.Size = new System.Drawing.Size(121, 21);
            this.ktgrCbx.TabIndex = 0;
            this.ktgrCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // urunCbx
            // 
            this.urunCbx.FormattingEnabled = true;
            this.urunCbx.Location = new System.Drawing.Point(140, 62);
            this.urunCbx.Name = "urunCbx";
            this.urunCbx.Size = new System.Drawing.Size(121, 21);
            this.urunCbx.TabIndex = 1;
            this.urunCbx.SelectedIndexChanged += new System.EventHandler(this.urunCbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kategori Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Seçiniz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "İşlemi Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunCbx);
            this.Controls.Add(this.ktgrCbx);
            this.Name = "UrunSil";
            this.Text = "UrunSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ktgrCbx;
        private System.Windows.Forms.ComboBox urunCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}