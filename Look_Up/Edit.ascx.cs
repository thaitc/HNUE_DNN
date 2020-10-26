using Hnue.Helper;
using Look_Up.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Look_Up
{
    public partial class Edit : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var datacontext = new LookUpDataContext();
            var userId = Request.QueryString["id"].ToInt();
            var c = datacontext.nguvan_lookups.FirstOrDefault(i => i.ID == userId) ?? new nguvan_lookup();
            tbTitle.Text = c.Title;
            tbInstroctor.Text = c.Instructor;
            tb_Author.Text = c.Author;
            tbYear.Text = c.Year;
            tbKey.InnerText = c.Keys;

        }
        protected void bt_Update_Click(object sender, EventArgs e)
        {
            var datacontext = new LookUpDataContext();
            LookUpDataContext db = new LookUpDataContext();
            var userId = Request.QueryString["id"].ToInt();
            nguvan_lookup c = db.nguvan_lookups.Single(i => i.ID == userId);
            c.Title = tbTitle.Text;
            c.Instructor = tbInstroctor.Text;
            c.Author = tb_Author.Text;
            c.Year = tbYear.Text;
            c.Keys = tbKey.InnerText;
            c.TabID = TabId;
            db.SubmitChanges();
            Response.Redirect(BuildUrl("LookUp"));
        }

        protected void bt_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(BuildUrl("LookUp"));
        }
    }
}