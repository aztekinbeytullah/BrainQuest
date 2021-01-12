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
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                yuklemeLabel.Text = "Yükleme Başlatıldı...!"; 
            }
            if (sayac == 1)
            {
                yuklemeLabel.Text = "Modüller Yükleniyor...!";
            }
            if (sayac == 2)
            {
                yuklemeLabel.Text = "Yüklendi...!";
            }
            if (sayac == 3)
            {
                yuklemeLabel.Text = "Veritabanına Bağlanılıyor...!";
            }
            if (sayac == 4)
            {
                yuklemeLabel.Text = "Bağlanıldı...!";
            }

            if (sayac == 5)
            {
                yuklemeLabel.Text = "Arayüz Oluşturuluyor...!";
            }
            if (sayac == 6)
            {
                yuklemeLabel.Text = "Oluşturuldu...!";
            }
            if (sayac == 7)
            {
                yuklemeLabel.Text = "Çok Az kaldı...!";
            }
            if (sayac == 8)
            {
                yuklemeLabel.Text = "Yükleme Tamamlandı...!";
            }
            if (sayac == 9)
            {
                yuklemeLabel.Text = "Başlatılıyor...!";
            }

            if (sayac == 10)
            {
                this.Close();
            }
            sayac++;

        }
    }
}
