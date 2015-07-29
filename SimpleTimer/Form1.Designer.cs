namespace SimpleTimer
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
            this.tmrSimple = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnEndTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrSimple
            // 
            this.tmrSimple.Interval = 1000;
            this.tmrSimple.Tick += new System.EventHandler(this.tmrSimple_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(12, 12);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(95, 23);
            this.btnStartTimer.TabIndex = 0;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnEndTimer
            // 
            this.btnEndTimer.Location = new System.Drawing.Point(238, 12);
            this.btnEndTimer.Name = "btnEndTimer";
            this.btnEndTimer.Size = new System.Drawing.Size(91, 23);
            this.btnEndTimer.TabIndex = 1;
            this.btnEndTimer.Text = "End Timer";
            this.btnEndTimer.UseVisualStyleBackColor = true;
            this.btnEndTimer.Click += new System.EventHandler(this.btnEndTimer_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(142, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 17);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 47);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnEndTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Name = "Form1";
            this.Text = "Simple Timer Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSimple;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnEndTimer;
        private System.Windows.Forms.Label lblTime;
    }
}

