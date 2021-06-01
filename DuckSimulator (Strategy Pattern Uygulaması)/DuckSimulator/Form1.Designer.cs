namespace DuckSimulator
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
            this.FlyBtn = new System.Windows.Forms.Button();
            this.QuackBtn = new System.Windows.Forms.Button();
            this.MallardBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            this.rubberBtn = new System.Windows.Forms.Button();
            this.decoyBtn = new System.Windows.Forms.Button();
            this.SwimBtn = new System.Windows.Forms.Button();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FlyBtn
            // 
            this.FlyBtn.Location = new System.Drawing.Point(63, 296);
            this.FlyBtn.Name = "FlyBtn";
            this.FlyBtn.Size = new System.Drawing.Size(91, 62);
            this.FlyBtn.TabIndex = 0;
            this.FlyBtn.Text = "FLY";
            this.FlyBtn.UseVisualStyleBackColor = true;
            this.FlyBtn.Click += new System.EventHandler(this.FlyBtn_Click);
            // 
            // QuackBtn
            // 
            this.QuackBtn.Location = new System.Drawing.Point(63, 389);
            this.QuackBtn.Name = "QuackBtn";
            this.QuackBtn.Size = new System.Drawing.Size(91, 62);
            this.QuackBtn.TabIndex = 1;
            this.QuackBtn.Text = "QUACK";
            this.QuackBtn.UseVisualStyleBackColor = true;
            // 
            // MallardBtn
            // 
            this.MallardBtn.BackgroundImage = global::DuckSimulator.Properties.Resources.mallard1;
            this.MallardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MallardBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MallardBtn.Location = new System.Drawing.Point(63, 59);
            this.MallardBtn.Name = "MallardBtn";
            this.MallardBtn.Size = new System.Drawing.Size(91, 71);
            this.MallardBtn.TabIndex = 2;
            this.MallardBtn.UseVisualStyleBackColor = true;
            this.MallardBtn.Click += new System.EventHandler(this.MallardBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.BackgroundImage = global::DuckSimulator.Properties.Resources.red;
            this.RedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RedBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RedBtn.Location = new System.Drawing.Point(201, 59);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(91, 71);
            this.RedBtn.TabIndex = 3;
            this.RedBtn.UseVisualStyleBackColor = true;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // rubberBtn
            // 
            this.rubberBtn.BackgroundImage = global::DuckSimulator.Properties.Resources._367_3676938_rubber_ducky_sunglasses_coffee_mug_pixel_art_clipart;
            this.rubberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rubberBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rubberBtn.Location = new System.Drawing.Point(63, 179);
            this.rubberBtn.Name = "rubberBtn";
            this.rubberBtn.Size = new System.Drawing.Size(75, 71);
            this.rubberBtn.TabIndex = 4;
            this.rubberBtn.UseVisualStyleBackColor = true;
            this.rubberBtn.Click += new System.EventHandler(this.rubberBtn_Click);
            // 
            // decoyBtn
            // 
            this.decoyBtn.BackgroundImage = global::DuckSimulator.Properties.Resources.decoy;
            this.decoyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decoyBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.decoyBtn.Location = new System.Drawing.Point(201, 179);
            this.decoyBtn.Name = "decoyBtn";
            this.decoyBtn.Size = new System.Drawing.Size(82, 71);
            this.decoyBtn.TabIndex = 5;
            this.decoyBtn.UseVisualStyleBackColor = true;
            this.decoyBtn.Click += new System.EventHandler(this.decoyBtn_Click);
            // 
            // SwimBtn
            // 
            this.SwimBtn.Location = new System.Drawing.Point(192, 296);
            this.SwimBtn.Name = "SwimBtn";
            this.SwimBtn.Size = new System.Drawing.Size(91, 62);
            this.SwimBtn.TabIndex = 6;
            this.SwimBtn.Text = "SWIM";
            this.SwimBtn.UseVisualStyleBackColor = true;
            this.SwimBtn.Click += new System.EventHandler(this.SwimBtn_Click);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(192, 389);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(91, 62);
            this.DisplayBtn.TabIndex = 7;
            this.DisplayBtn.Text = "DISPLAY";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DuckSimulator.Properties.Resources.duck_hunt_background_by_nickanater1_on_deviantart_duck_hunting_backgrounds_png_799_1000_crop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 490);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.SwimBtn);
            this.Controls.Add(this.decoyBtn);
            this.Controls.Add(this.rubberBtn);
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.MallardBtn);
            this.Controls.Add(this.QuackBtn);
            this.Controls.Add(this.FlyBtn);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FlyBtn;
        private System.Windows.Forms.Button QuackBtn;
        private System.Windows.Forms.Button MallardBtn;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button rubberBtn;
        private System.Windows.Forms.Button decoyBtn;
        private System.Windows.Forms.Button SwimBtn;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

