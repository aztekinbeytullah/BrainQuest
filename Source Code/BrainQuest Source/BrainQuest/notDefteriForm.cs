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
    public partial class notDefteriForm : Form
    {
        public notDefteriForm()
        {
            InitializeComponent();
        }
        myClass myClass1 = new myClass();
        string islemTipi = "";
        private void alanlariTemizle()
        {
            konuComboBox.SelectedIndex = -1;
            baslikComboBox.Text = "";
            baslikTextBox.Clear();
            icerikTextBox.Clear();
            
        }

        private void aramaAktifCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            alanlariTemizle();
            konuComboBox.SelectedIndex = -1;
            if (aramaAktifCheckBox.Checked)
            {
                
                baslikComboBox.Items.Clear();
                icerikTextBox.Clear();
                baslikTextBox.Clear();
                icerikTextBox.ReadOnly = true;
                kaydetLabel.Enabled = false;
                silLabel.Enabled = true;
                duzeltLabel.Enabled = true;
                baslikComboBox.Visible = true;
                baslikTextBox.Visible = false;
                kaydetLabel.Enabled = false;
                islemDurumLabel.Text = "Arama Modu";
                islemTipi = "arama";
            
            }
            else
            {
              
                baslikComboBox.Items.Clear();
                icerikTextBox.Clear();
                baslikTextBox.Clear();
                icerikTextBox.ReadOnly = false;
                kaydetLabel.Enabled = true;
                silLabel.Enabled = false;
                duzeltLabel.Enabled = false;

                baslikComboBox.Visible = false;
                baslikTextBox.Visible = true;
                kaydetLabel.Enabled = true;
                islemDurumLabel.Text = "Kayıt Modu";
                islemTipi = "kayit";

            }
        }

        private void kaydetLabel_Click(object sender, EventArgs e)
        {
            if (konuComboBox.SelectedIndex == -1 || baslikTextBox.Text == ""||icerikTextBox.Text=="")
            {
                MessageBox.Show(this, "Gerekli bilgileri girmeden not kaydı yapamazsınız.Lütfen gerekli alanları Doldururnuz", "BrainQuest Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string islemSonuc = "";
                islemSonuc = (myClass1.kayitIslemleri(konuComboBox.Text, baslikTextBox.Text, icerikTextBox.Text,"kayıt")).ToString();
                if (islemSonuc == "basarısız")
                {
                    DialogResult cvp;
                    cvp = MessageBox.Show(this, "Kayıt esnasında  bir hata ile karşılaşıldı.Program kapatılacak yeniden açıp devam edebilirsiniz", "BrainQuest Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cvp == DialogResult.OK)
                    {
                        myClass1.baglantiyiKes();
                        Application.Exit();
                    }
                }
                else if (islemSonuc == "basarılı")
                {
                    MessageBox.Show(this, "Notunuz başarılı bir şekilde kaydedildi.Daha sonra kullanmak istedinizde >Arama Aktif< kontrolü ile notunuza ulaşabilirsiniz", "BrainQuest Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alanlariTemizle();
                }
            }
        }

        private void kapatLabel_Click(object sender, EventArgs e)
        {
            if (myClass1.intBaglantiDurumu == 1)
            {
                myClass1.baglantiyiKes();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void silLabel_Click(object sender, EventArgs e)
        {

            string islemSonuc = "";
            islemSonuc = (myClass1.kayitIslemleri(konuComboBox.Text, baslikComboBox.Text, icerikTextBox.Text, "sil")).ToString();
            if (islemSonuc == "basarısız")
            {
                DialogResult cvp;
                cvp = MessageBox.Show(this, "Silme esnasında  bir hata ile karşılaşıldı.Program kapatılacak yeniden açıp devam edebilirsiniz", "BrainQuest Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cvp == DialogResult.OK)
                {
                    myClass1.baglantiyiKes();
                    Application.Exit();
                }
            }
            else if (islemSonuc == "basarılı")
            {
                MessageBox.Show(this, "Notunuz başarılı bir şekilde Silindi.", "BrainQuest Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                alanlariTemizle();
                aramaAktifCheckBox.Checked = false;
            }
            


        }

        private void konuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Konuya göre Başlıkları süzme
            if (islemTipi == "arama")
            { 
              try
                {
                    myClass1.sorguIfadesi = "SELECT *FROM tblNotDefteri WHERE konu like'" + konuComboBox.Text.ToString() + "%'";
                    myClass1.sorguTablosu = "tblNotDefteri";
                    myClass1.baglan();
                    baslikComboBox.Text = "";
                    icerikTextBox.Clear();
                    baslikComboBox.Items.Clear();
                    while (myClass1.reader.Read())
                    {
                        if (konuComboBox.Text == "")
                        {
                            baslikComboBox.Items.Clear();
                            icerikTextBox.Clear();
                        }
                        else
                        {
                            baslikComboBox.Items.Add(myClass1.reader.GetValue(1).ToString());
                        }
                    }
                }
                catch
                {
                    DialogResult cvp = MessageBox.Show(this, "Veri Tabanı Okuma Hatası NotDefteri Kullanılamaz", "Veri tabanı Hatası", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (cvp == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
            }
            #endregion
        }

        private void baslikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region başlığa göre not içeriği süzme
            if (islemTipi == "arama")
            {
                try
                {
                    myClass1.sorguIfadesi = "SELECT *FROM tblNotDefteri WHERE baslik like'" + baslikComboBox.Text.ToString() + "%'";
                    myClass1.sorguTablosu = "tblNotDefteri";
                    myClass1.baglan();
                    icerikTextBox.Clear();
                    myClass1.reader.Read();
                    
                        if (konuComboBox.Text == "")
                        {
                            baslikComboBox.Items.Clear();
                            icerikTextBox.Clear();
                        }
                        else
                        {
                            icerikTextBox.Text = myClass1.reader.GetValue(2).ToString();
                        }
                 }
                catch
                {
                     DialogResult cvp = MessageBox.Show(this, "Veri Tabanı Okuma Hatası NotDefteri Kullanılamaz", "Veri tabanı Hatası", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                     if (cvp == DialogResult.Cancel)
                     {
                        Application.Exit();
                     }
                }
            }
            #endregion
        }

        private void notDefteriForm_Load(object sender, EventArgs e)
        {
            alanlariTemizle();
        }

        private void duzeltLabel_Click(object sender, EventArgs e)
        {
            string islemSonuc = "";
            string strDuzKayitKonu = "", strDuzKayitBaslik = "", strDuzKayitNot = "";
            strDuzKayitKonu = konuComboBox.Text;
            strDuzKayitBaslik = baslikComboBox.Text;
            strDuzKayitNot = icerikTextBox.Text;
            islemSonuc = (myClass1.kayitIslemleri(konuComboBox.Text, baslikComboBox.Text, icerikTextBox.Text, "sil")).ToString();
            islemSonuc = "";
            aramaAktifCheckBox.Checked = false;
            konuComboBox.SelectedItem = strDuzKayitKonu;
            baslikTextBox.Text = strDuzKayitBaslik;
            icerikTextBox.Text = strDuzKayitNot;
        }
    }
}
