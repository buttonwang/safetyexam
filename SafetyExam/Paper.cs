using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

//------------------------------------------------------------------------------
// 试卷类
// 
// 
//------------------------------------------------------------------------------

namespace SafetyExam
{

    class Paper
    {
        SafetyExamDataContext db = new SafetyExamDataContext();

        public List<SafetyExam.DANXUAN> items { get; set; }

        public int Status { get; set; }  //试卷状态， 1：正在答题；2：回顾试题

        public DANXUAN CurrentItem { get; set; }

        public int CurrentItemNum  { get; set; } //当前题号

        public int DisplayItemNum { get { return this.CurrentItemNum + 1; } }

        public int ItemCount { get; set; }  //总题数

        public DateTime BeginTime  { get; set; }

        public DateTime EndTime  { get; set; }

        public int UsedTime { get; set; }       //用时秒

        public bool IsFirst { get; set; }

        public bool IsLast { get; set; }

        public float Score { get; set; }        //试卷总分

        public float UserScore { get; set; }    //用户得分

        public float rate { get; set; } //正确率

        public void StartAnswering()
        {
            Status = 1;
            Score = 100;
            ItemCount = 50;

            UsedTime = 0;
            UserScore = 0;
            rate = 0;
                       
            items = (from exam in db.DANXUANs
                           orderby db.NEWID()
                     select exam).Take(ItemCount).ToList();

            this.BeginTime = DateTime.Now;

            CurrentItem = items.First();

            CurrentItemNum = items.IndexOf(CurrentItem);

            CalcItemScore();
        }

        public void Review()
        {
            Status = 2;
        }

        public void PrevItem()
        {
            CurrentItemNum = CurrentItemNum - 1;

            CurrentItem = items[CurrentItemNum];

            IsFirst = CurrentItemNum == 0;

            IsLast = false;
        }

        public void NextItem()
        {
            CurrentItemNum = CurrentItemNum + 1;

            CurrentItem = items[CurrentItemNum];

            IsLast = CurrentItemNum +1 == ItemCount;

            IsFirst = false;
        }

        public void Mark()
        {
            EndTime = DateTime.Now;

            TimeSpan ts = EndTime - BeginTime;

            UsedTime = ts.Seconds;

            foreach (DANXUAN item in items)
            {
                item.MarkItem();
                UserScore = UserScore + item.UserScore;
            }

            rate = UserScore / Score;
        }

        public void FindByItemNum(int ItemNum)
        {
            CurrentItemNum = ItemNum - 1;

            CurrentItem = items[CurrentItemNum];

            IsLast = CurrentItemNum + 1 == ItemCount;

            IsFirst = CurrentItemNum == 0;
        }

        public String TestConditions()
        {
            return String.Format("本次答题得分为：{0}\r\n用时：{1}秒 正确率：{2}%",
                                   UserScore, UsedTime, rate * 100);
        }



        private void CalcItemScore()
        {
            var score = 100/ItemCount;

            var index = 1;

            foreach (DANXUAN item in items)
            {
                item.ItemScore = score;
                item.ItemNum = index;
                index++;
            }
        }
    }
}
