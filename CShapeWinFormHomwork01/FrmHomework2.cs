using System;
using System.Windows.Forms;

namespace CShapeWinFormHomwork01
{
    public partial class FrmHomework2 : Form
    {
        public FrmHomework2()
        {
            InitializeComponent();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if (tbIdStu.Text.Trim().Length == 0) { 
                GlobalData.showWarningMSG("กรุณาป้อนรหัสนักศึกษา");
            }else if(tbFullname.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณาป้อนชื่อ-สกุล");
            }
            else if(tbMidterm.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณาป้อนคะแนนกลางภาค");
            }
            else if (tbFinal.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณาป้อนคะแนนปลายภาค");
            }
            else if(tbScore.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณาป้อนคะแนนเก็บ");
            }
            else
            {
                lbIdResult.Text = tbIdStu.Text.Trim();
                lbFullnameResult.Text = tbFullname.Text.Trim();
                double totalScore = double.Parse(tbMidterm.Text) + double.Parse(tbFinal.Text) + double.Parse(tbScore.Text);
                lbTotalScore.Text = totalScore.ToString("N2");
                lbGradeResult.Text = totalScore >= 90 ? "A" :
                     totalScore >= 85 ? "B+" :
                     totalScore >= 80 ? "B" :
                     totalScore >= 75 ? "C+" :
                     totalScore >= 70 ? "C" :
                     totalScore >= 65 ? "D+" :
                     totalScore >= 60 ? "D" : "F";
            }
            
        }

        private void tbMidterm_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalData.keyNumberAndDotOnly(sender, e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void tbIdStu_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbIdStu.Text = "";
            tbFullname.Text = "";
            tbMidterm.Text = "";
            tbFinal.Text = "";
            tbScore.Text = "";
            lbIdResult.Text = "XXXXXXXX";
            lbFullnameResult.Text = "XXXXXXXX";
            lbTotalScore.Text = "XXXXXXXX";
            lbGradeResult.Text = "XXXXXXXX";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            GlobalData.exitApplication();
        }

        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void FrmHomework2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void FrmHomework2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
