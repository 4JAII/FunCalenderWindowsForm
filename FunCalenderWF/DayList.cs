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
        public static List<WishListTable> AllWishList = new List<WishListTable>();

        public DayList()
        {
            InitializeComponent();
        }

        public void SetDate(int y,int m,int d)
        {
            this.y = y;this.m = m; this.d = d;
            day.Text = string.Format("{0}年{1}月{2}日",y,m,d);
            /* タブページのコレクション登録処理 */
        }

        private void prev_Click(object sender, EventArgs e)
        {
            
            MainForm.MyCalender.Visible=true;
            MainForm.MyDayList.Visible = false;
            
        }

        private void DayList_Load(object sender, EventArgs e)
        {

        }

    }
}
