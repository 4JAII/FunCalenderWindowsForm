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
    public partial class DayList : UserControl
    {
        int y, m, d;
        public DayList(int y,int m,int d)
        {
            InitializeComponent();
            this.y = y;this.m = m; this.d = d;
            day.Text = string.Format("{0}年{1}月{2}日",y,m,d);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new Calender(y,m,d));
        }
    }
}
