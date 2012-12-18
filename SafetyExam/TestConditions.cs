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
    public partial class TestConditions : Form
    {
        public float UserScore;

        public int UsedTime;

        public float rate;

        public TestConditions()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TestConditions_Load(object sender, EventArgs e)
        {
            lblUserScore.Text = String.Format("{0}分", UserScore);
            lblUsedTime.Text = String.Format("{0}秒", UsedTime);
            lblRate.Text = String.Format("{0}%", rate * 100);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
