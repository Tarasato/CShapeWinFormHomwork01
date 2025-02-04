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
    public partial class FrmHomework4 : Form
    {
        public FrmHomework4()
        {
            InitializeComponent();
        }

        private void FrmHomework4_Load(object sender, EventArgs e)
        {
            rbJAVA.Checked = true;
        }

        private void tbAmountPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            rbJAVA.Checked = true;
            tbAmountPeople.Text = "";
            lbTopicResult.Text = "XXX";
            lbAmountResult.Text = "XXX";
            lbTotalCostResult.Text = "XXX";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            GlobalData.exitApplication();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if (tbAmountPeople.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณากรอกจำนวนคนที่เข้าอบรม");
            }else {
                double result = 0;
                if (rbJAVA.Checked)
                {
                    lbTopicResult.Text = "Java Developer";
                    lbAmountResult.Text = tbAmountPeople.Text.Trim();
                     result = (int.Parse(tbAmountPeople.Text.Trim()) * 1000);
                }
                else if (rbAndroid.Checked)
                {
                    lbTopicResult.Text = "Android Developer";
                    lbAmountResult.Text = tbAmountPeople.Text.Trim();
                     result = (int.Parse(tbAmountPeople.Text.Trim()) * 1200);
                }
                else if (rbiOS.Checked)
                {
                    lbTopicResult.Text = "IOS Developer";
                    lbAmountResult.Text = tbAmountPeople.Text.Trim();
                     result = (int.Parse(tbAmountPeople.Text.Trim()) * 1400);
                }
                else if (rbPHP.Checked)
                {
                    lbTopicResult.Text = "PHP Developer";
                    lbAmountResult.Text = tbAmountPeople.Text.Trim();
                     result = (int.Parse(tbAmountPeople.Text.Trim()) * 1600);
                }
                
                if (int.Parse(tbAmountPeople.Text.Trim()) >= 5)
                {
                    lbTotalCostResult.Text = (result * 0.9).ToString("N2");
                }
                else if (int.Parse(tbAmountPeople.Text.Trim()) >= 2)
                {
                    lbTotalCostResult.Text = (result * 0.85).ToString("N2");
                }
                else
                {
                    lbTotalCostResult.Text = result.ToString("N2");
                }
            }
        }

        private void FrmHomework4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void FrmHomework4_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
