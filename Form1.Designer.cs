namespace ClickerGameWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ClickerButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(12, 61);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(626, 76);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "10:0";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimerLabel.Click += new System.EventHandler(this.TimerLabel_Click);
            // 
            // ClickerButton
            // 
            this.ClickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickerButton.Location = new System.Drawing.Point(198, 164);
            this.ClickerButton.Name = "ClickerButton";
            this.ClickerButton.Size = new System.Drawing.Size(253, 125);
            this.ClickerButton.TabIndex = 1;
            this.ClickerButton.Text = "Click Here";
            this.ClickerButton.UseVisualStyleBackColor = true;
            this.ClickerButton.Click += new System.EventHandler(this.ClickerButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(288, 323);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(70, 76);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ClickerButton);
            this.Controls.Add(this.TimerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Datorium Clicker Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button ClickerButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}

