using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_LAB_6
{
    public partial class colorForm : Form
    {
        public colorForm(Form1 par)
        {
            InitializeComponent();
            parent = par;
            int color = parent.getPenColor();
            if (color == 0)
            {
                blackRadioBtn.Checked = true;
            }
            if (color == 1)
            {
                redRadioBtn.Checked = true;
            }
            if (color==2)
            {
                blueRadioBtn.Checked = true;
            }
            if (color==3)
            {
                yellowRadioBtn.Checked = true;
            }
        }

        Form1 parent;

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (blackRadioBtn.Checked)
            {
                parent.setPenColor(0);
            }
            if (redRadioBtn.Checked)
            {
                parent.setPenColor(1);
            }
            if (blueRadioBtn.Checked)
            {
                parent.setPenColor(2);
            }
            if (yellowRadioBtn.Checked)
            {
                parent.setPenColor(3);
            }
            this.Close();
        }
    }
}
