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
            this.en4 = new System.Windows.Forms.PictureBox();
            this.en3 = new System.Windows.Forms.PictureBox();
            this.en2 = new System.Windows.Forms.PictureBox();
            this.en1 = new System.Windows.Forms.PictureBox();
            this.astronaut = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.cr2 = new System.Windows.Forms.PictureBox();
            this.en5 = new System.Windows.Forms.PictureBox();
            this.cr1 = new System.Windows.Forms.PictureBox();
            this.cr3 = new System.Windows.Forms.PictureBox();
            this.cr4 = new System.Windows.Forms.PictureBox();
            this.crx = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.en4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crx)).BeginInit();
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
            // en2
            // 
            this.en2.BackColor = System.Drawing.Color.Black;
            this.en2.Image = global::AppDevGame.Properties.Resources.Enemy;
            this.en2.Location = new System.Drawing.Point(200, 347);
            this.en2.Name = "en2";
            this.en2.Size = new System.Drawing.Size(22, 31);
            this.en2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en2.TabIndex = 3;
            this.en2.TabStop = false;
            this.en2.Tag = "enemy";
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
            // cr2
            // 
            this.cr2.BackColor = System.Drawing.Color.Black;
            this.cr2.Image = global::AppDevGame.Properties.Resources.GoldAsteroid;
            this.cr2.Location = new System.Drawing.Point(549, 347);
            this.cr2.Name = "cr2";
            this.cr2.Size = new System.Drawing.Size(27, 31);
            this.cr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cr2.TabIndex = 4;
            this.cr2.TabStop = false;
            this.cr2.Tag = "currency";
            // 
            // en5
            // 
            this.en5.BackColor = System.Drawing.Color.Black;
            this.en5.Image = global::AppDevGame.Properties.Resources.Enemy;
            this.en5.Location = new System.Drawing.Point(407, 347);
            this.en5.Name = "en5";
            this.en5.Size = new System.Drawing.Size(22, 31);
            this.en5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en5.TabIndex = 3;
            this.en5.TabStop = false;
            this.en5.Tag = "enemy";
            // 
            // cr1
            // 
            this.cr1.BackColor = System.Drawing.Color.Black;
            this.cr1.Image = global::AppDevGame.Properties.Resources.GoldAsteroid;
            this.cr1.Location = new System.Drawing.Point(331, 278);
            this.cr1.Name = "cr1";
            this.cr1.Size = new System.Drawing.Size(27, 31);
            this.cr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cr1.TabIndex = 4;
            this.cr1.TabStop = false;
            this.cr1.Tag = "currency";
            // 
            // cr3
            // 
            this.cr3.BackColor = System.Drawing.Color.Black;
            this.cr3.Image = global::AppDevGame.Properties.Resources.GoldAsteroid;
            this.cr3.Location = new System.Drawing.Point(42, 185);
            this.cr3.Name = "cr3";
            this.cr3.Size = new System.Drawing.Size(27, 31);
            this.cr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cr3.TabIndex = 4;
            this.cr3.TabStop = false;
            this.cr3.Tag = "currency";
            // 
            // cr4
            // 
            this.cr4.BackColor = System.Drawing.Color.Black;
            this.cr4.Image = global::AppDevGame.Properties.Resources.GoldAsteroid;
            this.cr4.Location = new System.Drawing.Point(272, 112);
            this.cr4.Name = "cr4";
            this.cr4.Size = new System.Drawing.Size(27, 31);
            this.cr4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cr4.TabIndex = 4;
            this.cr4.TabStop = false;
            this.cr4.Tag = "currency";
            // 
            // crx
            // 
            this.crx.BackColor = System.Drawing.Color.Black;
            this.crx.Image = global::AppDevGame.Properties.Resources.GoldAsteroid;
            this.crx.Location = new System.Drawing.Point(561, 57);
            this.crx.Name = "crx";
            this.crx.Size = new System.Drawing.Size(27, 31);
            this.crx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crx.TabIndex = 4;
            this.crx.TabStop = false;
            this.crx.Tag = "currency";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(129, 44);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 398);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.crx);
            this.Controls.Add(this.cr4);
            this.Controls.Add(this.cr3);
            this.Controls.Add(this.cr1);
            this.Controls.Add(this.cr2);
            this.Controls.Add(this.en5);
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
            ((System.ComponentModel.ISupportInitialize)(this.en4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crx)).EndInit();
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
        private System.Windows.Forms.PictureBox cr2;
        private System.Windows.Forms.PictureBox en5;
        private System.Windows.Forms.PictureBox cr1;
        private System.Windows.Forms.PictureBox cr3;
        private System.Windows.Forms.PictureBox cr4;
        private System.Windows.Forms.PictureBox crx;
        private System.Windows.Forms.Label scoreLabel;
    }
}

