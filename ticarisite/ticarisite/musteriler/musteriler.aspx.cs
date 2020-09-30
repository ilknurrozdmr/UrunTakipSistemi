using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite.musteriler
{
    public partial class musteriler : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.tbl_musteri.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_musteri t = new tbl_musteri();
            t.musteriad = TextBox1.Text;
            t.musterisoyad = TextBox2.Text;
            db.tbl_musteri.Add(t);
            db.SaveChanges();
        }
    }
}