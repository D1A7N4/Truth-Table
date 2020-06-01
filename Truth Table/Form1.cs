using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Truth_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Table_Click(object sender, EventArgs e)
        {
            TBL_TruthTable.Controls.Clear();
            TextBox tbx_1 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_1, 1, 0);
            TextBox tbx_2 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_2, 2, 0);
            TextBox tbx_3 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_3, 0, 1);
            TextBox tbx_4 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_4, 1, 1);
            TextBox tbx_5 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_5, 2, 1);
            TextBox tbx_6 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_6, 0, 2);
            TextBox tbx_7 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_7, 1, 2);
            TextBox tbx_8 = new TextBox();
            TBL_TruthTable.Controls.Add(tbx_8, 2, 2);
            tbx_1.Text = "1";
            tbx_2.Text = "0";
            tbx_3.Text = "1";
            tbx_6.Text = "0";
            if (CBX_Operators.Text == "AND")
            {
                tbx_4.Text = "1";
                tbx_5.Text = "0";
                tbx_7.Text = "0";
                tbx_8.Text = "0";
            }
            if (CBX_Operators.Text == "OR")
            {
                tbx_4.Text = "1";
                tbx_5.Text = "1";
                tbx_7.Text = "1";
                tbx_8.Text = "0";
            }
            if (CBX_Operators.Text == "NAND")
            {
                tbx_4.Text = "0";
                tbx_5.Text = "1";
                tbx_7.Text = "1";
                tbx_8.Text = "1";
            }
            if (CBX_Operators.Text == "NOR")
            {
                tbx_4.Text = "0";
                tbx_5.Text = "0";
                tbx_7.Text = "0";
                tbx_8.Text = "1";
            }
            if (CBX_Operators.Text == "XOR")
            {
                tbx_4.Text = "0";
                tbx_5.Text = "1";
                tbx_7.Text = "1";
                tbx_8.Text = "0";
            }
        }
    }
}