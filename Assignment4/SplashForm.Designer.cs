namespace Assignment4
{
    partial class SplashForm
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
            this.SplashFormProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashFormProgressBar
            // 
            this.SplashFormProgressBar.Location = new System.Drawing.Point(7, 390);
            this.SplashFormProgressBar.MarqueeAnimationSpeed = 50;
            this.SplashFormProgressBar.Name = "SplashFormProgressBar";
            this.SplashFormProgressBar.Size = new System.Drawing.Size(291, 28);
            this.SplashFormProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SplashFormProgressBar.TabIndex = 1;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Interval = 150;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 3000;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment4.Properties.Resources.scale;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 372);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SplashFormProgressBar);
            this.MaximizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashForm_FormClosing);
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar SplashFormProgressBar;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}