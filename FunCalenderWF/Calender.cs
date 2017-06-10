using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunCalenderWF
{
    public partial class Calender : UserControl
    {
        int y, m, d;

        public Calender()
        {
            y = DateTime.Now.Year; m = DateTime.Now.Month; d = DateTime.Now.Day;
            InitializeComponent();
        }

        public Calender(int y,int m,int d)
        {
            this.y = y;this.m = m;this.d = d;
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            m++;
            if (m > 12)
            {
                m = 1;
                y++;
            }
            YearMonth.Text = string.Format("{0}年{1}月", y, m);
            PaintCalender(y, m, d);
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            m--;
            if (m < 1)
            {
                m = 12;
                y--;
            }
            YearMonth.Text = string.Format("{0}年{1}月", y, m);
            PaintCalender(y, m, d);
        }
    

        private void Calender_Load(object sender, EventArgs e)
        {         
            YearMonth.Text = string.Format("{0}年{1}月", y, m);
            PaintCalender(y, m, d);
   
        }

        public void PaintCalender(int y,int m,int d)
        {
            int i,j,start=0;
            int[] monthlen = { 31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            DateTime dt = new DateTime(y, m, 1);
            monthlen[1]= y % 4 == 0 ? (y % 100 == 0 ?  (y % 400 != 0 ? 29 : 28): 29 ): 28;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    start = 0;break;
                case DayOfWeek.Monday:
                    start = 1;break;
                case DayOfWeek.Tuesday:
                    start = 2;break;
                case DayOfWeek.Wednesday:
                    start = 3;break;
                case DayOfWeek.Thursday:
                    start = 4;break;
                case DayOfWeek.Friday:
                    start = 5;break;
                case DayOfWeek.Saturday:
                    start = 6;break;
                default:break;
            }
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 7; j++) {

                    var temp = Controls.Find("day"+(i*7+j+1).ToString(),true);
                    temp[0].Click -= new EventHandler(this.DayLabel_Click);
                    if (i*7+j < start || (i*7+j-start) >= monthlen[m - 1])
                    {
                        temp[0].Text = ""; 
                    }
                    else
                    {
                        temp[0].Text = (i * 7 + j + 1 - start).ToString();
                        temp[0].Cursor = Cursors.Hand;
                        temp[0].Click += new EventHandler(this.DayLabel_Click);
                    }
                }
            }
        }

        private void DayLabel_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new DayList(y,m,int.Parse(((Label)sender).Text)));
        }

    }
}
