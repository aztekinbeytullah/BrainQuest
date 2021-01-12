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
    public partial class hakkimizdaForm : Form
    {
        public hakkimizdaForm()
        {
            InitializeComponent();
        }
        private void kapatLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
