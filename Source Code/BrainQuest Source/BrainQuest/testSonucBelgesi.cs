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
    public partial class testSonucBelgesi : Form
    {
        public testSonucBelgesi()
        {
            InitializeComponent();
        }
        //deĞİŞKENLER VE oBJELER
        string strTestAdi="";
        int intDogruSayisi,intYanlisSayisi;
        double douHamPuan,douDuzeltilenPuan;
        string[] gelenCvpAnahtari = new string[10];
        string[] gelenCvplar = new string[10];
        //---------------------------------------------
        
        public void testSonuclariniAl(string testAdi,int dogruSayisi,int yanlisSayisi,double hamPuan,double duzeltilenPuan,ref string[] cvpAnahtari,ref string[] verilenCvplar)
        {
            try
            {
                strTestAdi = testAdi;
                intDogruSayisi = dogruSayisi;
                intYanlisSayisi = yanlisSayisi;
                douHamPuan = hamPuan;
                douDuzeltilenPuan = duzeltilenPuan;
                for (int i = 0; i < 10; i++)
                {
                    gelenCvpAnahtari[i] = cvpAnahtari[i];
                    gelenCvplar[i] = verilenCvplar[i];
                }
            }
            catch
            {
                MessageBox.Show(this, "Test Dökümü alınırken bir hata olustu...", "BrainQuest Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void testSonucBelgesi_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                testCvpAnahtariLabel.Text += gelenCvpAnahtari[i] + "   ";
                sizincvplarinizLabel.Text += gelenCvplar[i] + "   ";
            }
            dogruCvpLabel.Text = intDogruSayisi.ToString();
            yanlisCvpLabel.Text = intYanlisSayisi.ToString();
            hamPuanLabel.Text = douHamPuan.ToString();
            testAdiLabel.Text= strTestAdi;
            if (douDuzeltilenPuan <= 0)
                guvenilirPuanLabel.Text = "--";
            else
                guvenilirPuanLabel.Text = douDuzeltilenPuan.ToString();
            
            

        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
           
            strTestAdi = "";
            intDogruSayisi = 0;
            intYanlisSayisi = 0;
            douHamPuan = 0;
            douDuzeltilenPuan = 0;
            testCvpAnahtariLabel.ResetText();
            sizincvplarinizLabel.ResetText();
            for (int i = 0; i < 10; i++)
            {
                gelenCvpAnahtari[i] = "";
                gelenCvplar[i] = "";
            }
            
                this.Close();

        }

        private void testSonucBelgesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            kapatButton_Click(sender, e);
        }

     }
}
