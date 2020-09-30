using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite.urun
{
    public partial class urunguncelle : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var kate = (from x in db.tbl_kategori select new { x.kategoriid, x.kategoriad }).ToList();
                DropDownList1.DataTextField = "kategoriad";
                DropDownList1.DataValueField = "kategoriid";
                DropDownList1.DataSource = kate;
                DropDownList1.DataBind();

                int id = Convert.ToInt32(Request.QueryString["urunid"]);
                var p = db.tbl_urunler.Find(id);
                txturunad.Text = p.urunad;
                txtstok.Text = p.urunstok.ToString();
                txtmarka.Text = p.urunmarka.ToString();
                txtfiyat.Text = p.urunfiyat.ToString();
                DropDownList1.SelectedValue = p.urunkategori.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["urunid"]);
            var p = db.tbl_urunler.Find(id);
            p.urunad = txturunad.Text;
            p.urunstok =short.Parse(txtstok.Text);
            p.urunmarka = txtmarka.Text;
            p.urunfiyat =decimal.Parse(txtfiyat.Text);
            p.urunkategori = byte.Parse(DropDownList1.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("urunler.aspx");
        }
    }
}