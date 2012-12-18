using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SafetyExam
{
    public partial class FormExam : Form
    {

        SafetyExamDataContext db = new SafetyExamDataContext();

        Paper paper = new Paper();

        public FormExam()
        {
            InitializeComponent();
        }

        private void FormExam_Load(object sender, EventArgs e)
        {
            btnBegin.Enabled = true;
            btnFinish.Enabled = false;

            lblAnswer.Visible = false;
        }      

        private void btnBegin_Click(object sender, EventArgs e)
        {           
            paper.StartAnswering();
            
            rbA.Enabled = true;
            rbB.Enabled = true;
            rbC.Enabled = true;

            lblAnswer.Visible = false;

            btnBegin.Enabled = false;
            btnFinish.Enabled = true;
            btnReview.Enabled = false;
            fpReview.Controls.Clear();
            boxTestCond.Visible = false;
            boxTestCond.Visible = false;

            pbRight.Visible = false;
            pbError.Visible = false;

            RefreshItem();
        }

        private void RefreshItem()
        {
            boxContent.Text = String.Format("{0}、{1}", paper.DisplayItemNum, paper.CurrentItem.Content);

            rbA.Text = paper.CurrentItem.A;
            rbB.Text = paper.CurrentItem.B;
            rbC.Text = paper.CurrentItem.C;

            lblAnswer.Text = String.Format("正确答案是：{0}", paper.CurrentItem.Answer);
            RefreshOptions();

            btnPre.Enabled = !paper.IsFirst;
            btnNext.Enabled = !paper.IsLast;

            lblItemNum.Text = String.Format("{0}/{1}", paper.DisplayItemNum, paper.ItemCount);

            if (paper.Status == 2) RefreshOptionsImage();
        }

        private void RefreshOptions()
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;

            if (paper.CurrentItem.answered)
            {
                if (paper.CurrentItem.UserAnswer.Equals("A")) rbA.Checked = true;
                if (paper.CurrentItem.UserAnswer.Equals("B")) rbB.Checked = true;
                if (paper.CurrentItem.UserAnswer.Equals("C")) rbC.Checked = true;
            }
        }

        private void RefreshOptionsImage()
        {
            pbRight.Visible = false;
            pbError.Visible = false;

            if (paper.CurrentItem.answered)
            {
                RadioButton checkedRB = null;

                foreach (Control ctl in plOptions.Controls)
                {
                    if (ctl is RadioButton)
                    { 
                        if ((ctl as RadioButton).Checked) checkedRB = (ctl as RadioButton);
                    }
                }
                if (paper.CurrentItem.correct)
                {
                    pbRight.Top = checkedRB.Top;
                    pbRight.Visible = true;
                }
                else
                {
                    pbError.Top = checkedRB.Top;
                    pbError.Visible = true;
                }
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            paper.NextItem();

            RefreshItem();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            paper.PrevItem();

            RefreshItem();
        }

        private void rbA_Click(object sender, EventArgs e)
        {
            paper.CurrentItem.answered = true;
            paper.CurrentItem.UserAnswer = "A";
        }

        private void rbB_Click(object sender, EventArgs e)
        {
            paper.CurrentItem.answered = true;
            paper.CurrentItem.UserAnswer = "B";
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            paper.CurrentItem.answered = true;
            paper.CurrentItem.UserAnswer = "C";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            paper.Mark();

            using (TestConditions test = new TestConditions())
            {
                test.UserScore = paper.UserScore;
                test.UsedTime = paper.UsedTime;
                test.rate = paper.rate;

                test.ShowDialog();
            }

            btnFinish.Enabled = false;
            btnBegin.Enabled = true;
            btnReview.Enabled = true;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            //回顾
            paper.Review();

            foreach(DANXUAN item in paper.items)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Text = item.ItemNum.ToString();
                if (item.answered)
                {
                    if (item.correct) btn.BackColor = System.Drawing.Color.LimeGreen;
                    else btn.BackColor = System.Drawing.Color.Red;
                }

                btn.Click += new EventHandler(btnItemNum_Click);

                this.fpReview.Controls.Add(btn);
            }

            boxTestCond.Visible = true;
            boxTestCond.Text = paper.TestConditions();

            rbA.Enabled = false;
            rbB.Enabled = false;
            rbC.Enabled = false;

            lblAnswer.Visible = true;
            btnReview.Enabled = false;
        }

        private void btnItemNum_Click(object sender, EventArgs e)
        {
            int itemnum = Convert.ToInt16(((Button)sender).Text);
            paper.FindByItemNum(itemnum);

            RefreshItem();
        }

      
    }
}
