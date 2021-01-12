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
    public partial class sozlukForm : Form
    {
        public sozlukForm()
        {
            InitializeComponent();
        }

       myClass myClass1 = new myClass();

       private void arananKelimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                myClass1.sorguIfadesi = "SELECT *FROM tblSozluk WHERE Kelime like'" + arananKelimeTextBox.Text.ToString() + "%'";
                myClass1.sorguTablosu = "tblSozluk";
                myClass1.baglan();
                kelimeListBox.Items.Clear();
                while (myClass1.reader.Read())
                {
                    if (arananKelimeTextBox.Text == "")
                    {
                        kelimeListBox.Items.Clear();
                        kelimeAnlamiTextBox.Clear();
                    }
                    else
                    {
                        kelimeListBox.Items.Add(myClass1.reader.GetValue(1).ToString());
                    }
                }
                               
            }
            catch
            {
                DialogResult cvp=MessageBox.Show(this, "Veri Tabanı Okuma Hatası Sözlük Kullanılamaz", "Veri tabanı Hatası", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (cvp == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }

        }
       private void kelimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass1.sorguIfadesi = "SELECT * FROM tblSozluk WHERE Kelime like'" + kelimeListBox.Text.ToString() + "%'";
            myClass1.sorguTablosu = "tblSozluk";
            myClass1.baglan();
            while (myClass1.reader.Read())
            {
                kelimeAnlamiTextBox.Text = myClass1.reader.GetString(2).ToString();
            }     
        }
       private void kapatLabel_Click(object sender, EventArgs e)
       {
           if (myClass1.intBaglantiDurumu == 1)
           {
               myClass1.baglantiyiKes();
               myClass1.intBaglantiDurumu = 0;
               this.Close();
               
           }
           else
           {
               this.Close();
               myClass1.intBaglantiDurumu = 0;
           }
       }

          
    }
}
