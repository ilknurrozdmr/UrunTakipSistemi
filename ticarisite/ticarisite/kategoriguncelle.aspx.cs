using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;
namespace ticarisite
{
    public partial class kategoriguncelle : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
            { 
            int id = Convert.ToInt32(Request.QueryString["kategoriid"]);
            txtid.Text = id.ToString();
            var ktgr = db.tbl_kategori.Find(id);
            txtad.Text = ktgr.kategoriad;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["kategoriid"]);
            var ktgr = db.tbl_kategori.Find(id);
            ktgr.kategoriad = txtad.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}