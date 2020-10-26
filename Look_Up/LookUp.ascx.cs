using Hnue.Helper;
using Look_Up.DataAccess;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Look_Up
{
    public partial class LookUp : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        void LoadData()
        {
            var db = new LookUpDataContext();
            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = db.nguvan_lookups.OrderByDescending(i => i.ID).Where(i=>i.TabID==TabId).ToList();
            pgitems.AllowPaging = true;
            pgitems.PageSize = 3;
            pgitems.CurrentPageIndex = PageNumber;
            if (pgitems.PageCount > 1)
            {
                lb_total.Text = "Trang hiện tại: " + (PageNumber + 1);
                //lb_Trang.Visible = true;
                lbPrevious.Visible = true;
                lbNext.Visible = true;
                rptPages.Visible = true;
                System.Collections.ArrayList pages = new System.Collections.ArrayList();
                for (int i = PageNumber; i < pgitems.PageCount; i++)
                    if (pages.Count < 5)
                    {
                        pages.Add((i + 1).ToString());
                    }
                rptLookUp.DataSource = pgitems;
                rptLookUp.DataBind();
                rptPages.DataSource = pages;
                rptPages.DataBind();
            }
            else
            {
                //lb_Trang.Visible = false;
                lbPrevious.Visible = false;
                lbNext.Visible = false;
                rptPages.Visible = false;
                rptLookUp.DataSource = pgitems;
                rptLookUp.DataBind();
            }
        }
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }
        protected void rptPages_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            LoadData();
        }
        protected void lbPrevious_Click(object sender, EventArgs e)
        {
            if (PageNumber > 0)
            {
                PageNumber -= 1;
            }
            LoadData();
        }
        protected void lbNext_Click(object sender, EventArgs e)
        {
            var db = new LookUpDataContext();
            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = db.nguvan_lookups.OrderByDescending(i => i.ID).ToList();
            System.Collections.ArrayList pages = new System.Collections.ArrayList();
            for (int i = 0; i < pgitems.PageCount; i++)
                pages.Add((i + 1).ToString());
            if (PageNumber <= pages.Count)
            {
                PageNumber += 1;
            }
            LoadData();
        }
        protected void Del(object sender, EventArgs e)
        {
            var db = new LookUpDataContext();
            db.nguvan_lookups.DeleteOnSubmit(db.nguvan_lookups.First(i => i.ID == ((LinkButton)sender).CommandArgument.ToInt()));
            db.SubmitChanges();
            LoadData();
        }

        protected void bt_Create_Click(object sender, EventArgs e)
        {
            Response.Redirect(BuildUrl("Manager_LookUp"));
        }
        protected void bt_Search (object sender, EventArgs e)
        {
            var datacontext = new LookUpDataContext();
            var a = search.Text.Trim();
            if (a != null)
            {
                if (drpSearch.SelectedValue == "1")
                {
                    rptLookUp.DataSource = datacontext.nguvan_lookups.Where(i => i.Title.Contains(a) && i.TabID==TabId).ToList();
                    rptLookUp.DataBind();
                }
                if (drpSearch.SelectedValue == "2")
                {
                    rptLookUp.DataSource = datacontext.nguvan_lookups.Where(i => i.Author.Contains(a) && i.TabID == TabId).ToList();
                    rptLookUp.DataBind();
                }
                if (drpSearch.SelectedValue == "3")
                {
                    rptLookUp.DataSource = datacontext.nguvan_lookups.Where(i => i.Year.Contains(a) && i.TabID == TabId).ToList();
                    rptLookUp.DataBind();
                }
                if (drpSearch.SelectedValue == "4")
                {
                    rptLookUp.DataSource = datacontext.nguvan_lookups.Where(i => i.LibraryID.Contains(a) && i.TabID == TabId).ToList();
                    rptLookUp.DataBind();
                }
                if (drpSearch.SelectedValue == "5")
                {
                    rptLookUp.DataSource = datacontext.nguvan_lookups.Where(i => i.Instructor.Contains(a) && i.TabID == TabId).ToList();
                    rptLookUp.DataBind();
                }
            }
            if (a == "")
            {
                LoadData();
            }
        }
    }
}