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
    public partial class FrmHomework3 : Form
    {
        public FrmHomework3()
        {
            InitializeComponent();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if(tbAmountMoney.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณาป้อนจำนวนเงินที่จะหาร");
            }
            else if(tbAmountPeople.Text.Trim().Length == 0)
            {
                GlobalData.showWarningMSG("กรุณาป้อนจำนวนคนที่จะหาร");
            }
            else
            {
                double amountMoney = double.Parse(tbAmountMoney.Text);
                double amountPeople = double.Parse(tbAmountPeople.Text);
                double result = amountMoney / amountPeople;
                lbResult.Text = result.ToString("N2");
            }
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

        private void tbAmountMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text.Length == 0 && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            GlobalData.exitApplication();
        }

        private void FrmHomework3_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FrmHomework3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCal_Click(sender, e);
            }
        }
    }
}
