namespace FlappyBIRD
{
    partial class FlappyBird
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
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PIPE = new System.Windows.Forms.PictureBox();
            this.PIPEDown = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPEDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBIRD.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-8, 429);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(522, 84);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // PIPE
            // 
            this.PIPE.Image = global::FlappyBIRD.Properties.Resources.pipe;
            this.PIPE.Location = new System.Drawing.Point(262, 267);
            this.PIPE.Name = "PIPE";
            this.PIPE.Size = new System.Drawing.Size(100, 166);
            this.PIPE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPE.TabIndex = 1;
            this.PIPE.TabStop = false;
            this.PIPE.Click += new System.EventHandler(this.PIPE_Click);
            // 
            // PIPEDown
            // 
            this.PIPEDown.Image = global::FlappyBIRD.Properties.Resources.pipedown;
            this.PIPEDown.Location = new System.Drawing.Point(317, -4);
            this.PIPEDown.Name = "PIPEDown";
            this.PIPEDown.Size = new System.Drawing.Size(100, 167);
            this.PIPEDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPEDown.TabIndex = 2;
            this.PIPEDown.TabStop = false;
            this.PIPEDown.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyBIRD.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(12, 202);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(102, 72);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 3;
            this.Bird.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(12, 20);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(79, 28);
            this.Score.TabIndex = 4;
            this.Score.Text = "SCORE";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(474, 470);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.PIPEDown);
            this.Controls.Add(this.PIPE);
            this.Name = "FlappyBird";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyisUP);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPEDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Ground;
        private PictureBox PIPE;
        private PictureBox PIPEDown;
        private PictureBox Bird;
        private Label Score;
        private System.Windows.Forms.Timer gameTimer;
    }
}