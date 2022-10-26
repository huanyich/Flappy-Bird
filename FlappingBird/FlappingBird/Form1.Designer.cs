namespace FlappingBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.h2 = new System.Windows.Forms.PictureBox();
            this.h1 = new System.Windows.Forms.PictureBox();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.h4 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // t1
            // 
            this.t1.Image = ((System.Drawing.Image)(resources.GetObject("t1.Image")));
            this.t1.Location = new System.Drawing.Point(40, 281);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(102, 68);
            this.t1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1.TabIndex = 1;
            this.t1.TabStop = false;
            // 
            // t2
            // 
            this.t2.Image = ((System.Drawing.Image)(resources.GetObject("t2.Image")));
            this.t2.Location = new System.Drawing.Point(337, 267);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(68, 82);
            this.t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2.TabIndex = 1;
            this.t2.TabStop = false;
            // 
            // t3
            // 
            this.t3.Image = ((System.Drawing.Image)(resources.GetObject("t3.Image")));
            this.t3.Location = new System.Drawing.Point(587, 238);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(90, 111);
            this.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3.TabIndex = 1;
            this.t3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // h2
            // 
            this.h2.BackColor = System.Drawing.Color.Gray;
            this.h2.Location = new System.Drawing.Point(194, 238);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(79, 220);
            this.h2.TabIndex = 2;
            this.h2.TabStop = false;
            // 
            // h1
            // 
            this.h1.BackColor = System.Drawing.Color.Gray;
            this.h1.Location = new System.Drawing.Point(194, -1);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(79, 132);
            this.h1.TabIndex = 2;
            this.h1.TabStop = false;
            // 
            // h3
            // 
            this.h3.BackColor = System.Drawing.Color.Gray;
            this.h3.Location = new System.Drawing.Point(538, -1);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(79, 132);
            this.h3.TabIndex = 2;
            this.h3.TabStop = false;
            // 
            // h4
            // 
            this.h4.BackColor = System.Drawing.Color.Gray;
            this.h4.Location = new System.Drawing.Point(538, 301);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(79, 153);
            this.h4.TabIndex = 2;
            this.h4.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(25, 166);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(61, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.h4);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox t1;
        private PictureBox t2;
        private PictureBox t3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox h2;
        private PictureBox h1;
        private PictureBox h3;
        private PictureBox h4;
        private PictureBox bird;
        private System.Windows.Forms.Timer timer2;
    }
}