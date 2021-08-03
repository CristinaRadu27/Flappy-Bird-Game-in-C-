
namespace Flappy_Bird_Windows_Form
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.conductaSuperioara = new System.Windows.Forms.PictureBox();
            this.conductaInferioara = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductaSuperioara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductaInferioara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(63, 228);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(101, 67);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // conductaSuperioara
            // 
            this.conductaSuperioara.Image = ((System.Drawing.Image)(resources.GetObject("conductaSuperioara.Image")));
            this.conductaSuperioara.Location = new System.Drawing.Point(570, -1);
            this.conductaSuperioara.Name = "conductaSuperioara";
            this.conductaSuperioara.Size = new System.Drawing.Size(125, 205);
            this.conductaSuperioara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conductaSuperioara.TabIndex = 1;
            this.conductaSuperioara.TabStop = false;
            // 
            // conductaInferioara
            // 
            this.conductaInferioara.Image = ((System.Drawing.Image)(resources.GetObject("conductaInferioara.Image")));
            this.conductaInferioara.Location = new System.Drawing.Point(345, 387);
            this.conductaInferioara.Name = "conductaInferioara";
            this.conductaInferioara.Size = new System.Drawing.Size(135, 224);
            this.conductaInferioara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conductaInferioara.TabIndex = 2;
            this.conductaInferioara.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-6, 604);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(745, 85);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.scoreText.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(12, 625);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(42, 48);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "  ";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(735, 682);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.conductaInferioara);
            this.Controls.Add(this.conductaSuperioara);
            this.Controls.Add(this.flappyBird);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeysiup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductaSuperioara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductaInferioara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox conductaSuperioara;
        private System.Windows.Forms.PictureBox conductaInferioara;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

