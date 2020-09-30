using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ticarisite.Entity;

namespace ticarisite
{
    public partial class personel : System.Web.UI.Page
    {
        ticarisiteEntities2 db = new ticarisiteEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.tbl_personel.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}