using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite
{
    public partial class kategorisil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ticarisiteEntities2 db = new ticarisiteEntities2();
            int x =Convert.ToInt32(Request.QueryString["kategoriid"]);
            var p = db.tbl_kategori.Find(x);
            db.tbl_kategori.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}