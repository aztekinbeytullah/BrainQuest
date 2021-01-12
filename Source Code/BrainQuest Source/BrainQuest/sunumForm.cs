using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BrainQuest
{
    public partial class sunumForm : Form
    {
        public sunumForm()
        {
            InitializeComponent();
        }

        //değişkenler ve yaratılan nesneler
        int alinanIndex;
        myClass myClass1 = new myClass();
        sozlukForm sozlukForm = new sozlukForm();
        notDefteriForm notDefteriForm = new notDefteriForm();

        public void indexAktar(ref int gelen)
        {
            alinanIndex = gelen;
        }
        private void baglanVeFlashCalistir()
        {
            

            myClass1.sorguIfadesi = "select * from tblKonular";
            myClass1.sorguTablosu = "tblKonular";
            myClass1.baglan();
            myClass1.myDataSet.Tables[myClass1.sorguTablosu].DefaultView.RowStateFilter = DataViewRowState.CurrentRows;
            string veriTabaniYolu;
            veriTabaniYolu=myClass1.myDataSet.Tables[myClass1.sorguTablosu].DefaultView.Table.Rows[alinanIndex]["yol"].ToString();
            flashPanel.LoadMovie(0, Application.StartupPath + veriTabaniYolu);
            
        }
        private void sunumForm_Load(object sender, EventArgs e)
        {
            try
            {
                baglanVeFlashCalistir();

            }
            catch
            {
                DialogResult cvp=MessageBox.Show(this, "Veri tabanına bağlanılırken bir hata oluştur dersi izleyemeyeceksiniz", "Veri tabanı hatası", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (cvp ==DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }
        private void kapatButton_Click(object sender, EventArgs e)
        {
            if (myClass1.intBaglantiDurumu == 1)
            {
                myClass1.baglantiyiKes();
                this.Close();
                myClass1.intBaglantiDurumu = 0;
            }
            else
            {
                this.Close();
                myClass1.intBaglantiDurumu = 0;
            }

        }
        private void kapatButton_MouseMove(object sender, MouseEventArgs e)
        {
            kapatButton.ForeColor = Color.Red;
        }
        private void kapatButton_MouseLeave(object sender, EventArgs e)
        {
            kapatButton.ForeColor = Color.Black;
        }
        private void sozlükPictureBox_Click(object sender, EventArgs e)
        {
            sozlukForm.ShowDialog();

        }
        private void notDefteriPictureBox_Click(object sender, EventArgs e)
        {
            notDefteriForm.ShowDialog();
        }

            
    }
}
