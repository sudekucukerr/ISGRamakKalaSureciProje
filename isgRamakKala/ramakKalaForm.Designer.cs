namespace isgRamakKala
{
    partial class ramakKalaForm
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
            this.jdfhf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jdfhf
            // 
            this.jdfhf.Location = new System.Drawing.Point(345, 260);
            this.jdfhf.Name = "jdfhf";
            this.jdfhf.Size = new System.Drawing.Size(184, 29);
            this.jdfhf.TabIndex = 0;
            this.jdfhf.Text = "Ramak Kala Talep Formu";
            this.jdfhf.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "İSG Uzmanı Girişi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kullanıcı Girişi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ana Giriş Ekran";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ramakKalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jdfhf);
            this.Name = "ramakKalaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jdfhf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

