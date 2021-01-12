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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        #region Değişkenlerim
        myClass myClass1 = new myClass();
        int secilenindex;
        sunumForm sunuForm = new sunumForm();
        sozlukForm sozlukForm = new sozlukForm();
        hakkimizdaForm hakkimizdaForm = new hakkimizdaForm();
        notDefteriForm notDefteriForm = new notDefteriForm();
        yardimForm yardimForm = new yardimForm();
        testFormu testForm = new testFormu();
        #endregion

        private void saatTimer_Tick(object sender, EventArgs e)
        {
           saatToolStripLabel.Text = DateTime.Now.ToString();
        }          
        private void sunuFormaGec()
        {
            sunuForm.indexAktar(ref secilenindex);
            sunuForm.ShowDialog();
        }   
        private void sozlukToolStripButton_Click_1(object sender, EventArgs e)
        {
            sozlukForm.ShowDialog();
        }
        private void simgeListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

                if (simgeListView.Items[0].Selected == true)
                {
                    secilenindex = 0;
                    sunuFormaGec();
                }
                if (simgeListView.Items[1].Selected == true)
                {
                    secilenindex = 1;
                    sunuFormaGec();
                }
                if (simgeListView.Items[2].Selected == true)
                {
                    secilenindex = 2;
                    sunuFormaGec();
                }
                if (simgeListView.Items[3].Selected == true)
                {
                    secilenindex = 3;
                    sunuFormaGec();
                }
                if (simgeListView.Items[4].Selected == true)
                {
                    secilenindex = 4;
                    sunuFormaGec();
                }
                if (simgeListView.Items[5].Selected == true)
                {
                    secilenindex = 5;
                    sunuFormaGec();
                }
                if (simgeListView.Items[6].Selected == true)
                {
                    secilenindex = 6;
                    sunuFormaGec();
                }
                if (simgeListView.Items[7].Selected == true)
                {
                    secilenindex = 7;
                    sunuFormaGec();
                }
                if (simgeListView.Items[8].Selected == true)
                {
                    secilenindex = 8;
                    sunuFormaGec();
                }
            

        }
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                myClass1.baglantiyiKes();
                Application.Exit();
            }
            catch
            {
                Application.Exit();
            }
        }
        private void sözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sozlukToolStripButton_Click_1(sender, e);
        }
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkimizdaForm.ShowDialog();
        }
        private void notDefteriToolStripButton_Click(object sender, EventArgs e)
        {
            notDefteriForm.ShowDialog();
            
        }
        private void yardimToolStripButton_Click(object sender, EventArgs e)
        {
            yardimForm.ShowDialog();
        }
        private void denemSinavlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testForm.ShowDialog();

        }
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yardimForm.ShowDialog();
        }
    }
}
