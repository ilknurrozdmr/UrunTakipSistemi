using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite
{
    public partial class login : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.tbl_admin where x.kullanici == TxtKullaniciAd.Text && x.sifre == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Kategoriler.Aspx");
            }
            else
            {
                Response.Write("Hatalı Bilgi Girişi");
            }
        }
    }
}