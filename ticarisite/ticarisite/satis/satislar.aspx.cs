using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite.satis
{
    public partial class satislar : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var satislar = db.tbl_satis.ToList();
            var satislar = (from x in db.tbl_satis
                           select new
                           {
                               x.satisid,
                               x.tbl_urunler.urunad,
                               x.tbl_personel.perdoneladsoyad,
                               MUSTERI= x.tbl_musteri.musteriad+" "+x.tbl_musteri.musterisoyad,
                               x.fiyat


                           }).ToList();
            Repeater1.DataSource = satislar;
            Repeater1.DataBind();
        }
    }
}