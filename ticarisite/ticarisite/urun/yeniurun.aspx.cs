using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite.urun
{
    public partial class yeniurun : System.Web.UI.Page
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_urunler t = new tbl_urunler();
            t.urunad = txturunad.Text;
            t.urunstok =short.Parse(txtstok.Text);
            t.urunmarka = txtmarka.Text;
            t.urunfiyat =decimal.Parse(txtfiyat.Text);
            t.urunkategori =byte.Parse(DropDownList1.SelectedValue.ToString());
            txtfiyat.Text = DropDownList1.SelectedValue;
            db.tbl_urunler.Add(t);
            db.SaveChanges();
            Response.Redirect("urunler.aspx");
        }
    }
}