using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;
namespace ticarisite.linq_kartlar
{
    public partial class istatistik : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.tbl_urunler.Count().ToString();
            Label2.Text = db.tbl_musteri.Count().ToString();
            Label3.Text = db.tbl_satis.Sum(x => x.fiyat).ToString();
            Label4.Text = db.tbl_kategori.Count().ToString();
            Label5.Text = db.tbl_urunler.Count(x => x.durum == true).ToString();
            Label6.Text = db.tbl_urunler.Count(x => x.durum == false).ToString();
            Label7.Text = (from x in db.tbl_urunler orderby x.urunstok descending select x.urunad).FirstOrDefault();
            Label8.Text = db.tbl_personel.Count().ToString();
        }
    }
}