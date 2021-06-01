namespace Asistan
{
    partial class Asistan
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
            this.label2 = new System.Windows.Forms.Label();
            this.addGorevBtn = new System.Windows.Forms.Button();
            this.DeleteGorevBtn = new System.Windows.Forms.Button();
            this.ShowGorevBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GorevText = new System.Windows.Forms.TextBox();
            this.sureSayaci = new System.Windows.Forms.NumericUpDown();
            this.okBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gecBtn = new System.Windows.Forms.Button();
            this.ok2Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.calismaSayaci = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sureSayaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calismaSayaci)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yapılacak Tüm İşler";
            // 
            // addGorevBtn
            // 
            this.addGorevBtn.BackColor = System.Drawing.Color.DimGray;
            this.addGorevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addGorevBtn.ForeColor = System.Drawing.Color.White;
            this.addGorevBtn.Location = new System.Drawing.Point(211, 344);
            this.addGorevBtn.Name = "addGorevBtn";
            this.addGorevBtn.Size = new System.Drawing.Size(82, 56);
            this.addGorevBtn.TabIndex = 2;
            this.addGorevBtn.Text = "Yeni Görev Ekle";
            this.addGorevBtn.UseVisualStyleBackColor = false;
            this.addGorevBtn.Click += new System.EventHandler(this.addGorevBtn_Click);
            // 
            // DeleteGorevBtn
            // 
            this.DeleteGorevBtn.BackColor = System.Drawing.Color.DimGray;
            this.DeleteGorevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteGorevBtn.Location = new System.Drawing.Point(325, 344);
            this.DeleteGorevBtn.Name = "DeleteGorevBtn";
            this.DeleteGorevBtn.Size = new System.Drawing.Size(84, 56);
            this.DeleteGorevBtn.TabIndex = 3;
            this.DeleteGorevBtn.Text = "Görev Sil ";
            this.DeleteGorevBtn.UseVisualStyleBackColor = false;
            this.DeleteGorevBtn.Click += new System.EventHandler(this.DeleteGorevBtn_Click);
            // 
            // ShowGorevBtn
            // 
            this.ShowGorevBtn.BackColor = System.Drawing.Color.DimGray;
            this.ShowGorevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowGorevBtn.Location = new System.Drawing.Point(429, 344);
            this.ShowGorevBtn.Name = "ShowGorevBtn";
            this.ShowGorevBtn.Size = new System.Drawing.Size(82, 56);
            this.ShowGorevBtn.TabIndex = 4;
            this.ShowGorevBtn.Text = "Uygun Görevleri Göster";
            this.ShowGorevBtn.UseVisualStyleBackColor = false;
            this.ShowGorevBtn.Click += new System.EventHandler(this.ShowGorevBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(416, 29);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(414, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şu an bu görevi tamamlayabilirsiniz:";
            this.label3.Visible = false;
            // 
            // GorevText
            // 
            this.GorevText.Location = new System.Drawing.Point(316, 61);
            this.GorevText.Name = "GorevText";
            this.GorevText.Size = new System.Drawing.Size(100, 20);
            this.GorevText.TabIndex = 6;
            this.GorevText.Text = "Görev Adı";
            this.GorevText.Visible = false;
            // 
            // sureSayaci
            // 
            this.sureSayaci.Location = new System.Drawing.Point(316, 107);
            this.sureSayaci.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sureSayaci.Name = "sureSayaci";
            this.sureSayaci.Size = new System.Drawing.Size(100, 20);
            this.sureSayaci.TabIndex = 7;
            this.sureSayaci.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okBtn.Location = new System.Drawing.Point(333, 149);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(57, 36);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "Tamam";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Visible = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(516, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6);
            this.label4.Size = new System.Drawing.Size(12, 29);
            this.label4.TabIndex = 10;
            this.label4.Visible = false;
            // 
            // gecBtn
            // 
            this.gecBtn.BackColor = System.Drawing.Color.Gray;
            this.gecBtn.Location = new System.Drawing.Point(572, 149);
            this.gecBtn.Name = "gecBtn";
            this.gecBtn.Size = new System.Drawing.Size(57, 36);
            this.gecBtn.TabIndex = 12;
            this.gecBtn.Text = "Geç";
            this.gecBtn.UseVisualStyleBackColor = false;
            this.gecBtn.Visible = false;
            this.gecBtn.Click += new System.EventHandler(this.gecBtn_Click);
            // 
            // ok2Btn
            // 
            this.ok2Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok2Btn.Location = new System.Drawing.Point(333, 283);
            this.ok2Btn.Name = "ok2Btn";
            this.ok2Btn.Size = new System.Drawing.Size(57, 36);
            this.ok2Btn.TabIndex = 13;
            this.ok2Btn.Text = "Tamam";
            this.ok2Btn.UseVisualStyleBackColor = true;
            this.ok2Btn.Visible = false;
            this.ok2Btn.Click += new System.EventHandler(this.ok2Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(286, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kaç dakika çalışacaksınız?";
            this.label5.Visible = false;
            // 
            // calismaSayaci
            // 
            this.calismaSayaci.Location = new System.Drawing.Point(316, 245);
            this.calismaSayaci.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.calismaSayaci.Name = "calismaSayaci";
            this.calismaSayaci.Size = new System.Drawing.Size(100, 20);
            this.calismaSayaci.TabIndex = 15;
            this.calismaSayaci.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Yeni Görev:";
            this.label1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 17;
            this.label6.Tag = "";
            this.label6.Text = "Kaç dakika sürecek?";
            this.label6.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 199);
            this.listBox1.TabIndex = 18;
            // 
            // Asistan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImage = global::Asistan.Properties.Resources.Minimal_Patterns_Sound_Waves_Wallpaper__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 451);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calismaSayaci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ok2Btn);
            this.Controls.Add(this.gecBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.sureSayaci);
            this.Controls.Add(this.GorevText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowGorevBtn);
            this.Controls.Add(this.DeleteGorevBtn);
            this.Controls.Add(this.addGorevBtn);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Asistan";
            this.ShowIcon = false;
            this.Text = "Asistan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sureSayaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calismaSayaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addGorevBtn;
        private System.Windows.Forms.Button DeleteGorevBtn;
        private System.Windows.Forms.Button ShowGorevBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GorevText;
        private System.Windows.Forms.NumericUpDown sureSayaci;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gecBtn;
        private System.Windows.Forms.Button ok2Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown calismaSayaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
    }
}

