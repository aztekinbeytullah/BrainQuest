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
    public partial class testFormu : Form
    {
        public testFormu()
        {
            InitializeComponent();
        }
        //Değişkenler ve objeler
        myClass myClass1 = new myClass();
        testSonucBelgesi sonucBelgesi = new testSonucBelgesi();
        string[] cvpAnahtari = new string[10];
        string[] verilenCvplar = new string[10];
        int intDogruCvpSayisi=0,intYanlisCvpSayisi=0,intBosSoruSayisi=0;
        double douHamPuan = 0,douDuzeltilenPuan=0;
        string strTestAdi = "";
        private int secilenTestNumrasi;
        int sureSaniyeSayacı = 0,sureDakikaSayaci=0;
       
        private void baglanVeCalistir()
        {
            try
            {
                myClass1.sorguIfadesi = "select * from tblTest";
                myClass1.sorguTablosu = "tblTest";
                myClass1.baglan();
                myClass1.myDataSet.Tables[myClass1.sorguTablosu].DefaultView.RowStateFilter = DataViewRowState.CurrentRows;
                string testYolu;
                testYolu = myClass1.myDataSet.Tables[myClass1.sorguTablosu].DefaultView.Table.Rows[secilenTestNumrasi]["yol"].ToString();
                flashPanel.LoadMovie(0, Application.StartupPath + testYolu);
                for (int i = 0; i < 10; i++)
                {
                    cvpAnahtari[i] = myClass1.myDataSet.Tables[myClass1.sorguTablosu].DefaultView.Table.Rows[secilenTestNumrasi][i + 2].ToString();

                }
            }
            catch
            {
                MessageBox.Show(this, "Test yüklenirken bir hata oluştu...Programı kapatıp tekrar açmak sorunu giderebilir", "BrainQuest Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void testSecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sureSaniyeSayacı = 0;
            sureDakikaSayaci = 0;
            timer1.Enabled = true;
            secilenTestNumrasi = testSecComboBox.SelectedIndex;
            baglanVeCalistir();
            testAdiLabel.Text = testSecComboBox.Text;
        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            if (myClass1.intBaglantiDurumu==1)
            {
                myClass1.baglantiyiKes();               
            }
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

        private void testiDegerlendirLabel_MouseMove(object sender, MouseEventArgs e)
        {
            testiDegerlendirLabel.ForeColor = Color.Red;
        }

        private void testiDegerlendirLabel_MouseLeave(object sender, EventArgs e)
        {
            testiDegerlendirLabel.ForeColor = Color.Black;

        }
           
        private void testiDegerlendirLabel_Click(object sender, EventArgs e)
        {
            try
            {

                #region İşlenen Cvpların Diziye Aktarılması
                #region Soru_1
                if (soru_1A.Checked)
                    verilenCvplar[0] = "A";
                else if (soru_2B.Checked)
                    verilenCvplar[0] = "B";
                else if (soru_1C.Checked)
                    verilenCvplar[0] = "C";
                else
                    verilenCvplar[0] = "X";

                #endregion

                #region Soru_2
                if (soru_2A.Checked)
                    verilenCvplar[1] = "A";
                else if (soru_2B.Checked)
                    verilenCvplar[1] = "B";
                else if (soru_2C.Checked)
                    verilenCvplar[1] = "C";
                else
                    verilenCvplar[1] = "X";

                #endregion

                #region Soru_3
                if (soru_3A.Checked)
                    verilenCvplar[2] = "A";
                else if (soru_3B.Checked)
                    verilenCvplar[2] = "B";
                else if (soru_3C.Checked)
                    verilenCvplar[2] = "C";
                else
                    verilenCvplar[2] = "X";

                #endregion

                #region Soru_4
                if (soru_4A.Checked)
                    verilenCvplar[3] = "A";
                else if (soru_4B.Checked)
                    verilenCvplar[3] = "B";
                else if (soru_4C.Checked)
                    verilenCvplar[3] = "C";
                else
                    verilenCvplar[3] = "X";

                #endregion

                #region Soru_5
                if (soru_5A.Checked)
                    verilenCvplar[4] = "A";
                else if (soru_5B.Checked)
                    verilenCvplar[4] = "B";
                else if (soru_5C.Checked)
                    verilenCvplar[4] = "C";
                else
                    verilenCvplar[4] = "X";

                #endregion

                #region Soru_6
                if (soru_6A.Checked)
                    verilenCvplar[5] = "A";
                else if (soru_6B.Checked)
                    verilenCvplar[5] = "B";
                else if (soru_6C.Checked)
                    verilenCvplar[5] = "C";
                else
                    verilenCvplar[5] = "X";
                #endregion

                #region Soru_7
                if (soru_7A.Checked)
                    verilenCvplar[6] = "A";
                else if (soru_7B.Checked)
                    verilenCvplar[6] = "B";
                else if (soru_7C.Checked)
                    verilenCvplar[6] = "C";
                else
                    verilenCvplar[6] = "X";
                #endregion

                #region Soru_8
                if (soru_8A.Checked)
                    verilenCvplar[7] = "A";
                else if (soru_8B.Checked)
                    verilenCvplar[7] = "B";
                else if (soru_8C.Checked)
                    verilenCvplar[7] = "C";
                else
                    verilenCvplar[7] = "X";
                #endregion

                #region Soru_9
                if (soru_9A.Checked)
                    verilenCvplar[8] = "A";
                else if (soru_9B.Checked)
                    verilenCvplar[8] = "B";
                else if (soru_9C.Checked)
                    verilenCvplar[8] = "C";
                else
                    verilenCvplar[8] = "X";
                #endregion

                #region Soru_10
                if (soru_10A.Checked)
                    verilenCvplar[9] = "A";
                else if (soru_10B.Checked)
                    verilenCvplar[9] = "B";
                else if (soru_10C.Checked)
                    verilenCvplar[9] = "C";
                else
                    verilenCvplar[9] = "X";
                #endregion
                #endregion

            /*cvplar karşılaştırılmak üzere diziye aktarıldı
             * verilenCvplar dizisi ile cvpAnahtari dizinin karşlaştırmasını yap
             * X cvp ı soruya yanıt verilmeidğini göstermektedir.Dogru yada yanlış sayacını uygulama.
             */
                for (int i = 0; i < 10; i++)
                {
                    if (verilenCvplar[i] == cvpAnahtari[i])
                    {
                        intDogruCvpSayisi++;
                    }
                    else if (verilenCvplar[i] != cvpAnahtari[i] & verilenCvplar[i]!="X")
                    {
                        intYanlisCvpSayisi++;
                    }
                    else if (verilenCvplar[i] == "X")
                    {
                        intBosSoruSayisi++;
                    }
                }
                douHamPuan = intDogruCvpSayisi * 10;
                douDuzeltilenPuan = Convert.ToDouble(intDogruCvpSayisi - (Convert.ToDecimal(intYanlisCvpSayisi) / 2)) * 10;
                strTestAdi = testAdiLabel.Text;
                sonucBelgesi.testSonuclariniAl(strTestAdi, intDogruCvpSayisi, intYanlisCvpSayisi, douHamPuan, douDuzeltilenPuan, ref cvpAnahtari, ref verilenCvplar);
                sonucBelgesi.ShowDialog();
                intDogruCvpSayisi = 0;
                intYanlisCvpSayisi = 0;
                intBosSoruSayisi = 0;
                douHamPuan = 0;
                douDuzeltilenPuan = 0;
            }
            catch
            {
                MessageBox.Show(this, "Bir hata oluştu...Programı kapatıp tekrar açmak sorunu giderebilir", "BrainQuest Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sureSaniyeSayacı++;
            if (sureSaniyeSayacı == 60)
            {
                sureSaniyeSayacı = 0;
                sureDakikaSayaci++;
            }
            sureLabel.Text = sureDakikaSayaci.ToString() + "  : " +sureSaniyeSayacı.ToString();
        }


       
       

      

        

       

        

       
    }
}
