namespace Blackjack
{
    partial class Scoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scoreboard));
            this.scorePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.PlayedScoreLbl = new System.Windows.Forms.Label();
            this.TieScoreLbl = new System.Windows.Forms.Label();
            this.loseScoreLbl = new System.Windows.Forms.Label();
            this.winScoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.Transparent;
            this.scorePanel.Controls.Add(this.label3);
            this.scorePanel.Controls.Add(this.label4);
            this.scorePanel.Controls.Add(this.line);
            this.scorePanel.Controls.Add(this.PlayedScoreLbl);
            this.scorePanel.Controls.Add(this.TieScoreLbl);
            this.scorePanel.Controls.Add(this.loseScoreLbl);
            this.scorePanel.Controls.Add(this.winScoreLbl);
            this.scorePanel.Controls.Add(this.label2);
            this.scorePanel.Controls.Add(this.label1);
            this.scorePanel.Controls.Add(this.winLabel);
            this.scorePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scorePanel.Location = new System.Drawing.Point(12, 12);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(336, 213);
            this.scorePanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Games Played:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "--------------------------------------";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(3, 125);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(317, 29);
            this.line.TabIndex = 0;
            this.line.Text = "--------------------------------------";
            // 
            // PlayedScoreLbl
            // 
            this.PlayedScoreLbl.AutoSize = true;
            this.PlayedScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayedScoreLbl.ForeColor = System.Drawing.Color.White;
            this.PlayedScoreLbl.Location = new System.Drawing.Point(264, 150);
            this.PlayedScoreLbl.Name = "PlayedScoreLbl";
            this.PlayedScoreLbl.Size = new System.Drawing.Size(26, 29);
            this.PlayedScoreLbl.TabIndex = 0;
            this.PlayedScoreLbl.Text = "0";
            // 
            // TieScoreLbl
            // 
            this.TieScoreLbl.AutoSize = true;
            this.TieScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieScoreLbl.ForeColor = System.Drawing.Color.White;
            this.TieScoreLbl.Location = new System.Drawing.Point(264, 90);
            this.TieScoreLbl.Name = "TieScoreLbl";
            this.TieScoreLbl.Size = new System.Drawing.Size(26, 29);
            this.TieScoreLbl.TabIndex = 0;
            this.TieScoreLbl.Text = "0";
            // 
            // loseScoreLbl
            // 
            this.loseScoreLbl.AutoSize = true;
            this.loseScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseScoreLbl.ForeColor = System.Drawing.Color.White;
            this.loseScoreLbl.Location = new System.Drawing.Point(264, 50);
            this.loseScoreLbl.Name = "loseScoreLbl";
            this.loseScoreLbl.Size = new System.Drawing.Size(26, 29);
            this.loseScoreLbl.TabIndex = 0;
            this.loseScoreLbl.Text = "0";
            // 
            // winScoreLbl
            // 
            this.winScoreLbl.AutoSize = true;
            this.winScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winScoreLbl.ForeColor = System.Drawing.Color.White;
            this.winScoreLbl.Location = new System.Drawing.Point(264, 10);
            this.winScoreLbl.Name = "winScoreLbl";
            this.winScoreLbl.Size = new System.Drawing.Size(26, 29);
            this.winScoreLbl.TabIndex = 0;
            this.winScoreLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ties:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Games Lost:";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(3, 10);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(151, 29);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "Games Won:";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 236);
            this.Controls.Add(this.scorePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 274);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 274);
            this.Name = "Scoreboard";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scoreboard";
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label PlayedScoreLbl;
        private System.Windows.Forms.Label TieScoreLbl;
        private System.Windows.Forms.Label loseScoreLbl;
        private System.Windows.Forms.Label winScoreLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label label4;
    }
}