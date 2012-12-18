namespace SafetyExam
{
    partial class SafetyExamDataContext
    {
    }

    public partial class DANXUAN
    {
        public string UserAnswer { get; set; } //�û���

        public bool answered { get; set; }  //�û��Ƿ�������

        public bool correct { get; set; }  //�Ƿ���ȷ

        public float ItemScore { get; set; } //�������

        public float UserScore { get; set; } //�û��÷�

        public int ItemNum { get; set; }  //���

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
