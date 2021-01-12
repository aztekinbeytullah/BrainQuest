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
    public partial class ekraniGapla : Form
    {
        public ekraniGapla()
        {
            InitializeComponent();
        }

        private void ekraniGapla_Load(object sender, EventArgs e)
        {
            mainForm a = new mainForm();
            a.MdiParent = this;
            a.Show();
            a.Activate();
        }
    }
}
