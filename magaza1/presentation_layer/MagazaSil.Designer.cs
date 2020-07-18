namespace magaza1.presentation_layer
{
    partial class MagazaSil
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sehirCbx = new System.Windows.Forms.ComboBox();
            this.ilceCbx = new System.Windows.Forms.ComboBox();
            this.mgzadCbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mağazanın Bulundu Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bulunduğu İlçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mağaza Adı:";
            // 
            // sehirCbx
            // 
            this.sehirCbx.FormattingEnabled = true;
            this.sehirCbx.Location = new System.Drawing.Point(159, 57);
            this.sehirCbx.Name = "sehirCbx";
            this.sehirCbx.Size = new System.Drawing.Size(121, 21);
            this.sehirCbx.TabIndex = 3;
            this.sehirCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ilceCbx
            // 
            this.ilceCbx.FormattingEnabled = true;
            this.ilceCbx.Location = new System.Drawing.Point(159, 88);
            this.ilceCbx.Name = "ilceCbx";
            this.ilceCbx.Size = new System.Drawing.Size(121, 21);
            this.ilceCbx.TabIndex = 4;
            this.ilceCbx.SelectedIndexChanged += new System.EventHandler(this.ilceCbx_SelectedIndexChanged);
            // 
            // mgzadCbx
            // 
            this.mgzadCbx.FormattingEnabled = true;
            this.mgzadCbx.Location = new System.Drawing.Point(159, 122);
            this.mgzadCbx.Name = "mgzadCbx";
            this.mgzadCbx.Size = new System.Drawing.Size(121, 21);
            this.mgzadCbx.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mağaza Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MagazaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mgzadCbx);
            this.Controls.Add(this.ilceCbx);
            this.Controls.Add(this.sehirCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MagazaSil";
            this.Text = "MagazaSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sehirCbx;
        private System.Windows.Forms.ComboBox ilceCbx;
        private System.Windows.Forms.ComboBox mgzadCbx;
        private System.Windows.Forms.Button button1;
    }
}