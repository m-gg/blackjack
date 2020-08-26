namespace Blackjack
{
    partial class How_To_Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(How_To_Play));
            this.PictureHelp = new System.Windows.Forms.PictureBox();
            this.TextHelp = new System.Windows.Forms.PictureBox();
            this.PreviousPageBtn = new System.Windows.Forms.Button();
            this.PageOfLabel = new System.Windows.Forms.Label();
            this.NextPageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureHelp
            // 
            this.PictureHelp.BackColor = System.Drawing.Color.Transparent;
            this.PictureHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureHelp.Location = new System.Drawing.Point(0, 197);
            this.PictureHelp.Name = "PictureHelp";
            this.PictureHelp.Size = new System.Drawing.Size(1344, 412);
            this.PictureHelp.TabIndex = 0;
            this.PictureHelp.TabStop = false;
            // 
            // TextHelp
            // 
            this.TextHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextHelp.Location = new System.Drawing.Point(0, 0);
            this.TextHelp.Name = "TextHelp";
            this.TextHelp.Size = new System.Drawing.Size(1344, 181);
            this.TextHelp.TabIndex = 1;
            this.TextHelp.TabStop = false;
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Location = new System.Drawing.Point(547, 628);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Size = new System.Drawing.Size(91, 23);
            this.PreviousPageBtn.TabIndex = 2;
            this.PreviousPageBtn.Text = "Previous Page";
            this.PreviousPageBtn.UseVisualStyleBackColor = true;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
            // 
            // PageOfLabel
            // 
            this.PageOfLabel.AutoSize = true;
            this.PageOfLabel.Location = new System.Drawing.Point(644, 633);
            this.PageOfLabel.Name = "PageOfLabel";
            this.PageOfLabel.Size = new System.Drawing.Size(62, 13);
            this.PageOfLabel.TabIndex = 4;
            this.PageOfLabel.Text = "Page 1 of 9";
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Location = new System.Drawing.Point(712, 628);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(91, 23);
            this.NextPageBtn.TabIndex = 2;
            this.NextPageBtn.Text = "Next Page";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // How_To_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 657);
            this.Controls.Add(this.TextHelp);
            this.Controls.Add(this.PageOfLabel);
            this.Controls.Add(this.NextPageBtn);
            this.Controls.Add(this.PreviousPageBtn);
            this.Controls.Add(this.PictureHelp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1360, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1360, 700);
            this.Name = "How_To_Play";
            this.Text = "How To Play";
            ((System.ComponentModel.ISupportInitialize)(this.PictureHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureHelp;
        private System.Windows.Forms.PictureBox TextHelp;
        private System.Windows.Forms.Button PreviousPageBtn;
        private System.Windows.Forms.Label PageOfLabel;
        private System.Windows.Forms.Button NextPageBtn;
    }
}