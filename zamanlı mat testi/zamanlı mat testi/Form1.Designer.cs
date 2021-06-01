namespace zamanlı_mat_testi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cikarma = new System.Windows.Forms.Label();
            this.carpma = new System.Windows.Forms.Label();
            this.bolme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.toplasayac = new System.Windows.Forms.NumericUpDown();
            this.cikarsayac = new System.Windows.Forms.NumericUpDown();
            this.bolmesayac = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tekrarbutonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toplasayac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikarsayac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolmesayac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cikarma
            // 
            this.cikarma.AutoSize = true;
            this.cikarma.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikarma.Location = new System.Drawing.Point(57, 181);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(106, 29);
            this.cikarma.TabIndex = 1;
            this.cikarma.Text = "Cikarma";
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click);
            // 
            // carpma
            // 
            this.carpma.AutoSize = true;
            this.carpma.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpma.Location = new System.Drawing.Point(57, 223);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(97, 29);
            this.carpma.TabIndex = 2;
            this.carpma.Text = "carpma";
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // bolme
            // 
            this.bolme.AutoSize = true;
            this.bolme.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolme.Location = new System.Drawing.Point(57, 267);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(84, 29);
            this.bolme.TabIndex = 3;
            this.bolme.Text = "bölme";
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(237, 23);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(123, 73);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Başla";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.Location = new System.Drawing.Point(91, 44);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 25);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // toplasayac
            // 
            this.toplasayac.Location = new System.Drawing.Point(306, 148);
            this.toplasayac.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.toplasayac.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.toplasayac.Name = "toplasayac";
            this.toplasayac.Size = new System.Drawing.Size(220, 22);
            this.toplasayac.TabIndex = 6;
            this.toplasayac.ValueChanged += new System.EventHandler(this.toplasayac_ValueChanged);
            // 
            // cikarsayac
            // 
            this.cikarsayac.Location = new System.Drawing.Point(306, 188);
            this.cikarsayac.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.cikarsayac.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.cikarsayac.Name = "cikarsayac";
            this.cikarsayac.Size = new System.Drawing.Size(220, 22);
            this.cikarsayac.TabIndex = 7;
            this.cikarsayac.ValueChanged += new System.EventHandler(this.cikarsayac_ValueChanged);
            // 
            // bolmesayac
            // 
            this.bolmesayac.Location = new System.Drawing.Point(306, 274);
            this.bolmesayac.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.bolmesayac.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.bolmesayac.Name = "bolmesayac";
            this.bolmesayac.Size = new System.Drawing.Size(220, 22);
            this.bolmesayac.TabIndex = 8;
            this.bolmesayac.ValueChanged += new System.EventHandler(this.bolmesayac_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(306, 231);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(220, 22);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(284, 324);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(123, 76);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Bitir";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(548, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(548, 188);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(548, 231);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(548, 283);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // tekrarbutonu
            // 
            this.tekrarbutonu.Location = new System.Drawing.Point(468, 324);
            this.tekrarbutonu.Name = "tekrarbutonu";
            this.tekrarbutonu.Size = new System.Drawing.Size(110, 76);
            this.tekrarbutonu.TabIndex = 15;
            this.tekrarbutonu.Text = "Tekrar Oyna";
            this.tekrarbutonu.UseVisualStyleBackColor = true;
            this.tekrarbutonu.Visible = false;
            this.tekrarbutonu.Click += new System.EventHandler(this.tekrarbutonu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 422);
            this.Controls.Add(this.tekrarbutonu);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.bolmesayac);
            this.Controls.Add(this.cikarsayac);
            this.Controls.Add(this.toplasayac);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.cikarma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplasayac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikarsayac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolmesayac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cikarma;
        private System.Windows.Forms.Label carpma;
        private System.Windows.Forms.Label bolme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NumericUpDown toplasayac;
        private System.Windows.Forms.NumericUpDown cikarsayac;
        private System.Windows.Forms.NumericUpDown bolmesayac;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button tekrarbutonu;
    }
}

