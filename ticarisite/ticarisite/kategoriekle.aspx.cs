using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite
{
    public partial class kategoriekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ticarisiteEntities2 db = new ticarisiteEntities2();
            tbl_kategori t = new tbl_kategori();
            t.kategoriad = TextBox1.Text;
            db.tbl_kategori.Add(t);
            db.SaveChanges();
        }
    }
}