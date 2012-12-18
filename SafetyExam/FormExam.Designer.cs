namespace SafetyExam
{
    partial class FormExam
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.plOptions = new System.Windows.Forms.Panel();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.boxContent = new System.Windows.Forms.RichTextBox();
            this.fpReview = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxTestCond = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.plOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.plOptions);
            this.splitContainer1.Panel1.Controls.Add(this.boxContent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.fpReview);
            this.splitContainer1.Size = new System.Drawing.Size(812, 329);
            this.splitContainer1.SplitterDistance = 618;
            this.splitContainer1.TabIndex = 3;
            // 
            // plOptions
            // 
            this.plOptions.Controls.Add(this.pbError);
            this.plOptions.Controls.Add(this.pbRight);
            this.plOptions.Controls.Add(this.lblAnswer);
            this.plOptions.Controls.Add(this.rbC);
            this.plOptions.Controls.Add(this.rbB);
            this.plOptions.Controls.Add(this.rbA);
            this.plOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plOptions.Location = new System.Drawing.Point(0, 96);
            this.plOptions.Name = "plOptions";
            this.plOptions.Size = new System.Drawing.Size(618, 233);
            this.plOptions.TabIndex = 1;
            // 
            // pbError
            // 
            this.pbError.Image = global::SafetyExam.Properties.Resources.candle;
            this.pbError.Location = new System.Drawing.Point(12, 87);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(16, 16);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbError.TabIndex = 5;
            this.pbError.TabStop = false;
            this.pbError.Visible = false;
            // 
            // pbRight
            // 
            this.pbRight.Image = global::SafetyExam.Properties.Resources._true;
            this.pbRight.Location = new System.Drawing.Point(12, 35);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(16, 16);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRight.TabIndex = 4;
            this.pbRight.TabStop = false;
            this.pbRight.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Linen;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAnswer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAnswer.Location = new System.Drawing.Point(41, 174);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(112, 18);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "正确答案是：";
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.BackColor = System.Drawing.Color.Snow;
            this.rbC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbC.ForeColor = System.Drawing.Color.Black;
            this.rbC.Location = new System.Drawing.Point(43, 140);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(14, 13);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.UseVisualStyleBackColor = false;
            this.rbC.Click += new System.EventHandler(this.rbC_Click);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.BackColor = System.Drawing.Color.Snow;
            this.rbB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbB.ForeColor = System.Drawing.Color.Black;
            this.rbB.Location = new System.Drawing.Point(43, 87);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(14, 13);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.UseVisualStyleBackColor = false;
            this.rbB.Click += new System.EventHandler(this.rbB_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.BackColor = System.Drawing.Color.Snow;
            this.rbA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbA.ForeColor = System.Drawing.Color.Black;
            this.rbA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbA.Location = new System.Drawing.Point(43, 35);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(14, 13);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.UseVisualStyleBackColor = false;
            this.rbA.Click += new System.EventHandler(this.rbA_Click);
            // 
            // boxContent
            // 
            this.boxContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxContent.Location = new System.Drawing.Point(0, 0);
            this.boxContent.Name = "boxContent";
            this.boxContent.ReadOnly = true;
            this.boxContent.Size = new System.Drawing.Size(618, 96);
            this.boxContent.TabIndex = 0;
            this.boxContent.Text = "";
            // 
            // fpReview
            // 
            this.fpReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpReview.Location = new System.Drawing.Point(0, 0);
            this.fpReview.Name = "fpReview";
            this.fpReview.Size = new System.Drawing.Size(190, 329);
            this.fpReview.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(350, 45);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(131, 27);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "开始答题";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(487, 45);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(131, 27);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "交卷";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.btnBegin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 78);
            this.panel1.TabIndex = 1;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(624, 45);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(131, 27);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "回顾答题";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(226, 9);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "上一题";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(331, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Location = new System.Drawing.Point(431, 14);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(0, 12);
            this.lblItemNum.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.boxTestCond);
            this.panel2.Controls.Add(this.lblItemNum);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 44);
            this.panel2.TabIndex = 2;
            // 
            // boxTestCond
            // 
            this.boxTestCond.BackColor = System.Drawing.Color.DimGray;
            this.boxTestCond.Dock = System.Windows.Forms.DockStyle.Right;
            this.boxTestCond.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boxTestCond.ForeColor = System.Drawing.Color.Yellow;
            this.boxTestCond.Location = new System.Drawing.Point(622, 0);
            this.boxTestCond.Multiline = true;
            this.boxTestCond.Name = "boxTestCond";
            this.boxTestCond.ReadOnly = true;
            this.boxTestCond.Size = new System.Drawing.Size(190, 44);
            this.boxTestCond.TabIndex = 5;
            this.boxTestCond.Visible = false;
            // 
            // FormExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SafetyExam.Properties.Resources.gjdllogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(812, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "山西地方有限公司-安规题库练习软件";
            this.Load += new System.EventHandler(this.FormExam_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.plOptions.ResumeLayout(false);
            this.plOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel plOptions;
        private System.Windows.Forms.RichTextBox boxContent;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.FlowLayoutPanel fpReview;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.TextBox boxTestCond;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.PictureBox pbRight;
    }
}

