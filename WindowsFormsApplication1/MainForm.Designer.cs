namespace GuessTheMelody
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playPicBox = new System.Windows.Forms.PictureBox();
            this.rulesPicBox = new System.Windows.Forms.PictureBox();
            this.exitPicBox = new System.Windows.Forms.PictureBox();
            this.recordsPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playPicBox
            // 
            this.playPicBox.BackColor = System.Drawing.Color.Transparent;
            this.playPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playPicBox.BackgroundImage")));
            this.playPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playPicBox.Location = new System.Drawing.Point(121, 102);
            this.playPicBox.MaximumSize = new System.Drawing.Size(168, 80);
            this.playPicBox.MinimumSize = new System.Drawing.Size(168, 80);
            this.playPicBox.Name = "playPicBox";
            this.playPicBox.Size = new System.Drawing.Size(168, 80);
            this.playPicBox.TabIndex = 0;
            this.playPicBox.TabStop = false;
            this.playPicBox.Click += new System.EventHandler(this.playPicBox_Click);
            this.playPicBox.MouseLeave += new System.EventHandler(this.playPicBox_MouseLeave);
            this.playPicBox.MouseHover += new System.EventHandler(this.playPicBox_MouseHover);
            // 
            // rulesPicBox
            // 
            this.rulesPicBox.BackColor = System.Drawing.Color.Transparent;
            this.rulesPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rulesPicBox.BackgroundImage")));
            this.rulesPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rulesPicBox.Location = new System.Drawing.Point(121, 170);
            this.rulesPicBox.MaximumSize = new System.Drawing.Size(168, 80);
            this.rulesPicBox.MinimumSize = new System.Drawing.Size(168, 80);
            this.rulesPicBox.Name = "rulesPicBox";
            this.rulesPicBox.Size = new System.Drawing.Size(168, 80);
            this.rulesPicBox.TabIndex = 1;
            this.rulesPicBox.TabStop = false;
            this.rulesPicBox.Click += new System.EventHandler(this.rulesPicBox_Click);
            this.rulesPicBox.MouseLeave += new System.EventHandler(this.rulesPicBox_MouseLeave);
            this.rulesPicBox.MouseHover += new System.EventHandler(this.rulesPicBox_MouseHover);
            // 
            // exitPicBox
            // 
            this.exitPicBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitPicBox.BackgroundImage")));
            this.exitPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitPicBox.Location = new System.Drawing.Point(609, 2);
            this.exitPicBox.Name = "exitPicBox";
            this.exitPicBox.Size = new System.Drawing.Size(81, 74);
            this.exitPicBox.TabIndex = 2;
            this.exitPicBox.TabStop = false;
            this.exitPicBox.Click += new System.EventHandler(this.exitPicBox_Click);
            this.exitPicBox.MouseLeave += new System.EventHandler(this.exitPicBox_MouseLeave);
            this.exitPicBox.MouseHover += new System.EventHandler(this.exitPicBox_MouseHover);
            // 
            // recordsPicBox
            // 
            this.recordsPicBox.BackColor = System.Drawing.Color.Transparent;
            this.recordsPicBox.BackgroundImage = global::GuessTheMelody.Properties.Resources.Рекорды;
            this.recordsPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recordsPicBox.Location = new System.Drawing.Point(306, 102);
            this.recordsPicBox.Name = "recordsPicBox";
            this.recordsPicBox.Size = new System.Drawing.Size(112, 148);
            this.recordsPicBox.TabIndex = 3;
            this.recordsPicBox.TabStop = false;
            this.recordsPicBox.Click += new System.EventHandler(this.recordsPicBox_Click);
            this.recordsPicBox.MouseLeave += new System.EventHandler(this.recordsPicBox_MouseLeave);
            this.recordsPicBox.MouseHover += new System.EventHandler(this.recordsPicBox_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 391);
            this.Controls.Add(this.recordsPicBox);
            this.Controls.Add(this.exitPicBox);
            this.Controls.Add(this.rulesPicBox);
            this.Controls.Add(this.playPicBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 430);
            this.MinimumSize = new System.Drawing.Size(718, 430);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playPicBox;
        private System.Windows.Forms.PictureBox rulesPicBox;
        private System.Windows.Forms.PictureBox exitPicBox;
        private System.Windows.Forms.PictureBox recordsPicBox;
    }
}

