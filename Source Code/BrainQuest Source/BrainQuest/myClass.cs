using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace BrainQuest
{
    class myClass
    {
        #region Değişkenlerim
        //---------------------------------------------
        public OleDbConnection baglanti;
        OleDbDataAdapter adaptor;
        public DataSet myDataSet;
        public OleDbDataReader reader;
        public OleDbCommand command;
        public string sorguIfadesi;
        public string sorguTablosu;
        public int intBaglantiDurumu;
        public string strkayitIslemKontrol ="";
        //------------------------------------------
        
        #endregion

        public void baglan()
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\db\\db.mdb");
                command = new OleDbCommand(sorguIfadesi, baglanti);
                command.Connection.Open();
                intBaglantiDurumu = 1;   
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                adaptor = new OleDbDataAdapter(sorguIfadesi, baglanti);
                myDataSet = new DataSet();
                adaptor.Fill(myDataSet, sorguTablosu);
            }
            catch
            {
                
            }
        }
        public string kayitIslemleri(string konu,string baslik,string not,string tip)
        {
            if (tip == "kayıt")
            {

                try
                {
                    baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\db\\db.mdb");
                    baglanti.Open();
                    command = new OleDbCommand("insert into tblNotDefteri values(@konu,@baslik,@not)", baglanti);
                    command.Parameters.Add("@konu", konu);
                    command.Parameters.Add("@baslik", baslik);
                    command.Parameters.Add("@not", not);
                    command.ExecuteNonQuery();
                    strkayitIslemKontrol = "basarılı";
                }
                catch
                {
                    strkayitIslemKontrol = "basarısız";

                }
                
            }
            else if(tip=="sil")
            {
                try
                {
                    baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\db\\db.mdb");
                    baglanti.Open();
                    command = new OleDbCommand("delete from tblNotDefteri where konu=@konu AND baslik=@baslik", baglanti);
                    command.Parameters.Add("@konu", konu);
                    command.Parameters.Add("@baslik", baslik);
                    command.Parameters.Add("@not", not);
                    command.ExecuteNonQuery();
                    strkayitIslemKontrol = "basarılı";
                }
                catch
                {
                    strkayitIslemKontrol = "basarısız";

                }
            }
            else if (tip == "düzenle")
            {

                try
                {
                    baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\db\\db.mdb");
                    baglanti.Open();

                    command = new OleDbCommand("update tblNotDefteri set konu=@konu,baslik=@baslik,not=@not where", baglanti);
                    command.Parameters.Add("@konu", konu);
                    command.Parameters.Add("@baslik", baslik);
                    command.Parameters.Add("@not", not);
                    command.ExecuteNonQuery();
                    strkayitIslemKontrol = "basarılı";
                }
                catch
                {
                    strkayitIslemKontrol = "basarısız";

                }
               



            }



            return strkayitIslemKontrol;
        }
        public void baglantiyiKes()
        {
            try
            {
                baglanti.Close();
                intBaglantiDurumu = 0;
            }
            catch
            {     
            }
        }

    }
}
