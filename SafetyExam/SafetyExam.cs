namespace SafetyExam
{
    partial class SafetyExamDataContext
    {
    }

    public partial class DANXUAN
    {
        public string UserAnswer { get; set; } //用户答案

        public bool answered { get; set; }  //用户是否打过此题

        public bool correct { get; set; }  //是否正确

        public float ItemScore { get; set; } //试题分数

        public float UserScore { get; set; } //用户得分

        public int ItemNum { get; set; }  //题号

        public void MarkItem()
        {
            if (answered == false)
            {
                correct = false;
                UserScore = 0;
            }
            else
            {
                if (UserAnswer.Equals(Answer))
                {
                    correct = true;
                    UserScore = ItemScore;
                }
                else
                {
                    correct = false;
                    UserScore = 0;
                }
            }

        }
    }


}
