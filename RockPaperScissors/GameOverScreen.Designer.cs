namespace RockPaperScissors
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // overLabel
            // 
            this.overLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overLabel.Location = new System.Drawing.Point(103, 38);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(164, 81);
            this.overLabel.TabIndex = 0;
            this.overLabel.Text = "Game Over";
            // 
            // finalLabel
            // 
            this.finalLabel.Location = new System.Drawing.Point(58, 213);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(304, 119);
            this.finalLabel.TabIndex = 1;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.overLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(450, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label overLabel;
        private System.Windows.Forms.Label finalLabel;
    }
}
