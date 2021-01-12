using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrainQuest
{
    public partial class yardimForm : Form
    {
        public yardimForm()
        {
            InitializeComponent();
        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kapatButton_MouseMove(object sender, MouseEventArgs e)
        {
            kapatButton.ForeColor = Color.Red;
        }

        private void kapatButton_MouseLeave(object sender, EventArgs e)
        {
            kapatButton.ForeColor = Color.Black;
        }

        private void yardimForm_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.LoadMovie(0, Application.StartupPath + "\\yardim\\yardim.swf");
        }
    }
}
