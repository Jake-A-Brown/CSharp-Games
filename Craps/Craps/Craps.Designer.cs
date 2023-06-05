namespace Craps
{
    partial class Craps
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RollBtn = new System.Windows.Forms.Button();
            this.PlayAgainBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(240, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // RollBtn
            // 
            this.RollBtn.BackColor = System.Drawing.Color.Yellow;
            this.RollBtn.Location = new System.Drawing.Point(84, 280);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(75, 23);
            this.RollBtn.TabIndex = 2;
            this.RollBtn.Text = "Roll";
            this.RollBtn.UseVisualStyleBackColor = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // PlayAgainBtn
            // 
            this.PlayAgainBtn.BackColor = System.Drawing.Color.Yellow;
            this.PlayAgainBtn.Location = new System.Drawing.Point(174, 280);
            this.PlayAgainBtn.Name = "PlayAgainBtn";
            this.PlayAgainBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayAgainBtn.TabIndex = 3;
            this.PlayAgainBtn.Text = "Play Again";
            this.PlayAgainBtn.UseVisualStyleBackColor = false;
            this.PlayAgainBtn.Click += new System.EventHandler(this.PlayAgainBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Yellow;
            this.ExitBtn.Location = new System.Drawing.Point(265, 280);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Green;
            this.OutputLabel.ForeColor = System.Drawing.Color.Yellow;
            this.OutputLabel.Location = new System.Drawing.Point(191, 214);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(35, 13);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(157, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Craps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(439, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PlayAgainBtn);
            this.Controls.Add(this.RollBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.Button PlayAgainBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label label1;
    }
}

