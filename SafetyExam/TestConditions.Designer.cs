namespace SafetyExam
{
    partial class TestConditions
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblUsedTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本次得分：";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(110, 27);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(11, 12);
            this.lblUserScore.TabIndex = 1;
            this.lblUserScore.Text = "0";
            // 
            // lblUsedTime
            // 
            this.lblUsedTime.AutoSize = true;
            this.lblUsedTime.Location = new System.Drawing.Point(110, 53);
            this.lblUsedTime.Name = "lblUsedTime";
            this.lblUsedTime.Size = new System.Drawing.Size(11, 12);
            this.lblUsedTime.TabIndex = 3;
            this.lblUsedTime.Text = "0";
            this.lblUsedTime.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "本次用时：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(110, 80);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(11, 12);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "  正确率：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(75, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TestConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUsedTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestConditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "答题情况";
            this.Load += new System.EventHandler(this.TestConditions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblUsedTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
    }
}