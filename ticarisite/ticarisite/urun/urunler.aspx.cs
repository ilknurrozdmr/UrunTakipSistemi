using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;
   

namespace ticarisite.urun
{
    public partial class urunler : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.tbl_urunler.Where(x=>x.durum==true).ToList();
            var urunler = (from x in db.tbl_urunler
                           where x.durum==true
                           select new
                           {
                               x.urunid,
                               x.urunad,
                               x.urunmarka,
                               x.tbl_kategori.kategoriad,
                               x.urunfiyat,
                               x.urunstok
                           }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}