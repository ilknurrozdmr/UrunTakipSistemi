using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite.satis
{
    public partial class yenisatis : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.tbl_urunler select new { x.urunid, x.urunad }).ToList();
                DropDownList1.DataTextField = "urunad";
                DropDownList1.DataValueField = "urunid";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var mus = (from x in db.tbl_musteri
                           select new {
                               x.musteriid,
                           ADSOYAD=x.musteriad+" "+x.musterisoyad }).ToList();
                DropDownList2.DataTextField = "ADSOYAD";
                DropDownList2.DataValueField = "musteriid";
                DropDownList2.DataSource = mus;
                DropDownList2.DataBind();

                var per = (from x in db.tbl_personel select new { x.personelid, x.perdoneladsoyad }).ToList();
                DropDownList3.DataTextField = "perdoneladsoyad";
                DropDownList3.DataValueField = "personelid";
                DropDownList3.DataSource = per;
                DropDownList3.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_satis s = new tbl_satis();
            s.musteri = int.Parse(DropDownList2.SelectedValue);
            s.urun = int.Parse(DropDownList1.SelectedValue);
            s.personel = byte.Parse(DropDownList3.SelectedValue);
            s.fiyat = decimal.Parse(txtfiyat.Text);
            db.tbl_satis.Add(s);
            db.SaveChanges();
            Response.Redirect("satislar.aspx");
        }
    }
}