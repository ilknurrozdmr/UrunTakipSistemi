using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite.urun
{
    public partial class urunsil : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["urunid"]);
            var urun = db.tbl_urunler.Find(id);
            urun.durum = false;
            db.SaveChanges();
            Response.Redirect("urunler.aspx");
        }
    }
}