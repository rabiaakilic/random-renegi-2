namespace random_örnegi_2_1359
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblDuz = new System.Windows.Forms.Label();
            this.lblTesekur = new System.Windows.Forms.Label();
            this.lblTaktir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "ortalama not üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "geçme kalma durumu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(154, 34);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(144, 173);
            this.lbNotlar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "öğrenci notları";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(165, 247);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(123, 13);
            this.lblKalan.TabIndex = 4;
            this.lblKalan.Text = "kalan öğrenci sayısı:";
            // 
            // lblDuz
            // 
            this.lblDuz.AutoSize = true;
            this.lblDuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuz.Location = new System.Drawing.Point(165, 275);
            this.lblDuz.Name = "lblDuz";
            this.lblDuz.Size = new System.Drawing.Size(116, 13);
            this.lblDuz.TabIndex = 5;
            this.lblDuz.Text = "düz geçen oğrenci:";
            // 
            // lblTesekur
            // 
            this.lblTesekur.AutoSize = true;
            this.lblTesekur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesekur.Location = new System.Drawing.Point(168, 302);
            this.lblTesekur.Name = "lblTesekur";
            this.lblTesekur.Size = new System.Drawing.Size(88, 13);
            this.lblTesekur.TabIndex = 6;
            this.lblTesekur.Text = "teşekür sayısı:";
            // 
            // lblTaktir
            // 
            this.lblTaktir.AutoSize = true;
            this.lblTaktir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaktir.Location = new System.Drawing.Point(168, 331);
            this.lblTaktir.Name = "lblTaktir";
            this.lblTaktir.Size = new System.Drawing.Size(75, 13);
            this.lblTaktir.TabIndex = 7;
            this.lblTaktir.Text = "taktir sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 394);
            this.Controls.Add(this.lblTaktir);
            this.Controls.Add(this.lblTesekur);
            this.Controls.Add(this.lblDuz);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblDuz;
        private System.Windows.Forms.Label lblTesekur;
        private System.Windows.Forms.Label lblTaktir;
    }
}

