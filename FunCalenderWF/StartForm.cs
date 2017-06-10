using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunCalenderWF
{
    public partial class MainForm : Form
    {
        public static Calender MyCalender;
        public static DayList MyDayList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            MyCalender = new Calender();
            MyDayList = new DayList();
            MainPanel.Controls.Add(MyCalender);
            MainPanel.Controls.Add(MyDayList);
            Start.Dispose();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
