namespace AppDevGame
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Animation = new System.Windows.Forms.Timer(this.components);
            this.astronaut = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.en1 = new System.Windows.Forms.PictureBox();
            this.en2 = new System.Windows.Forms.PictureBox();
            this.en3 = new System.Windows.Forms.PictureBox();
            this.en4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en4)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Animation
            // 
            this.Animation.Enabled = true;
            this.Animation.Interval = 250;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // astronaut
            // 
            this.astronaut.BackColor = System.Drawing.Color.Black;
            this.astronaut.Image = global::AppDevGame.Properties.Resources.Idle;
            this.astronaut.Location = new System.Drawing.Point(23, 300);
            this.astronaut.Name = "astronaut";
            this.astronaut.Size = new System.Drawing.Size(46, 79);
            this.astronaut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.astronaut.TabIndex = 2;
            this.astronaut.TabStop = false;
            this.astronaut.Tag = "astronaut";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::AppDevGame.Properties.Resources.Platform;
            this.pictureBox5.Location = new System.Drawing.Point(476, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(124, 10);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "base";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::AppDevGame.Properties.Resources.Platform;
            this.pictureBox4.Location = new System.Drawing.Point(232, 309);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "base";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::AppDevGame.Properties.Resources.Platform;
            this.pictureBox3.Location = new System.Drawing.Point(232, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "base";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AppDevGame.Properties.Resources.Platform;
            this.pictureBox2.Location = new System.Drawing.Point(0, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "base";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AppDevGame.Properties.Resources.Platform;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "base";
            // 
            // background
            // 
            this.background.Image = global::AppDevGame.Properties.Resources.Space;
            this.background.Location = new System.Drawing.Point(0, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(600, 400);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "background";
            // 
            // en1
            // 
            this.en1.BackColor = System.Drawing.Color.Black;
            this.en1.Image = global::AppDevGame.Properties.Resources.Enemy;
            this.en1.Location = new System.Drawing.Point(257, 276);
            this.en1.Name = "en1";
            this.en1.Size = new System.Drawing.Size(22, 31);
            this.en1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en1.TabIndex = 3;
            this.en1.TabStop = false;
            this.en1.Tag = "enemy";
            // 
            // en2
            // 
            this.en2.BackColor = System.Drawing.Color.Black;
            this.en2.Image = global::AppDevGame.Properties.Resources.Enemy;
            this.en2.Location = new System.Drawing.Point(414, 345);
            this.en2.Name = "en2";
            this.en2.Size = new System.Drawing.Size(22, 31);
            this.en2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en2.TabIndex = 3;
            this.en2.TabStop = false;
            this.en2.Tag = "enemy";
            // 
            // en3
            // 
            this.en3.BackColor = System.Drawing.Color.Black;
            this.en3.Image = global::AppDevGame.Properties.Resources.Enemy;
            this.en3.Location = new System.Drawing.Point(12, 183);
            this.en3.Name = "en3";
            this.en3.Size = new System.Drawing.Size(22, 31);
            this.en3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en3.TabIndex = 3;
            this.en3.TabStop = false;
            this.en3.Tag = "enemy";
            // 
            // en4
            // 
            this.en4.BackColor = System.Drawing.Color.Black;
            this.en4.Image = global::AppDevGame.Properties.Resources.Enemy;
            this.en4.Location = new System.Drawing.Point(331, 110);
            this.en4.Name = "en4";
            this.en4.Size = new System.Drawing.Size(22, 31);
            this.en4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en4.TabIndex = 3;
            this.en4.TabStop = false;
            this.en4.Tag = "enemy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 398);
            this.Controls.Add(this.en4);
            this.Controls.Add(this.en3);
            this.Controls.Add(this.en2);
            this.Controls.Add(this.en1);
            this.Controls.Add(this.astronaut);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Tag = "platform";
            this.Text = "AD Game Prototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IsKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox astronaut;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer Animation;
        private System.Windows.Forms.PictureBox en1;
        private System.Windows.Forms.PictureBox en2;
        private System.Windows.Forms.PictureBox en3;
        private System.Windows.Forms.PictureBox en4;
    }
}

