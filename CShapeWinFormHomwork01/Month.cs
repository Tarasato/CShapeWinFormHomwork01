using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomwork01
{
    public partial class Month : Form
    {
        public Month()
        {
            InitializeComponent();
        }

        private void Mouth_Load(object sender, EventArgs e)
        {
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.ShowWeekNumbers = false;
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.SetDate(new DateTime(DateTime.Now.Year, GlobalData.Month, 1));
        }

        private void Month_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHomework1 frmHomework1 = new FrmHomework1();
            frmHomework1.Show();
        }
    }
}
