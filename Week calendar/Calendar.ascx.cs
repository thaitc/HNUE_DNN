using Hnue.Helper;
using System;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using Week_calendar.DataAccess;

namespace Week_calendar
{
    public partial class Calendar : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataTable();
            LoadData();
        }
        void BindDataTable()
        {
            var datacontext = new CalendarDataContext();
            var userId = Request.QueryString["id"].ToInt();
            var c = datacontext.CALENDAR_MANAGERs.Select(i => new { i.Id, i.Content, i.Titel, i.Update }).OrderByDescending(i => i.Id).First();
            lb_Date.Text = "Public: " + c.Update.ParseDateTime("dd-MM-yyyy");
            lbTitel.Text = "<b>" + c.Titel + "</b>";
            string table = c.Content;
            calendar.InnerHtml = table;
        }
        void LoadData()
        {
            var db = new CalendarDataContext();
            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = db.CALENDAR_MANAGERs.OrderByDescending(i => i.Id).Skip(1).ToList();
            pgitems.AllowPaging = true;
            pgitems.PageSize = 5;
            pgitems.CurrentPageIndex = PageNumber;
            if (pgitems.PageCount > 1)
            {
                lb_total.Text = "Trang hiện tại: " + (PageNumber+1);
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
                rptTuyensinh.DataSource = pgitems;
                rptTuyensinh.DataBind();
                rptPages.DataSource = pages;
                rptPages.DataBind();
            }
            else
            {
                //lb_Trang.Visible = false;
                lbPrevious.Visible = false;
                lbNext.Visible = false;
                rptPages.Visible = false;
                rptTuyensinh.DataSource = pgitems;
                rptTuyensinh.DataBind();
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
            var db = new CalendarDataContext();
            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = db.CALENDAR_MANAGERs.OrderByDescending(i => i.Id).Skip(1).ToList();
            pgitems.AllowPaging = true;
            pgitems.PageSize = 2;
            pgitems.CurrentPageIndex = PageNumber;
            //lb_Trang.Visible = true;
            lbPrevious.Visible = true;
            lbNext.Visible = true;
            rptPages.Visible = true;
            System.Collections.ArrayList pages = new System.Collections.ArrayList();
            for (int i = 0; i < pgitems.PageCount; i++)
                pages.Add((i + 1).ToString());
            rptTuyensinh.DataSource = pgitems;
            rptTuyensinh.DataBind();
            rptPages.DataSource = pages;
            rptPages.DataBind();
            PageNumber += 1;
            LoadData();
        }

        protected void bt_View_Click(object sender, EventArgs e)
        {
            var datacontext = new CalendarDataContext();
            var userId = Request.QueryString["id"].ToInt();
            var c = datacontext.CALENDAR_MANAGERs.FirstOrDefault(i => i.Id == ((LinkButton)sender).CommandArgument.ToInt());
            lb_Date.Text = "Public: " + c.Update.ParseDateTime("dd-MM-yyyy");
            lbTitel.Text = "<b>" + c.Titel + "</b>";
            string table = c.Content;
            calendar.InnerHtml = table;
        }


    }
}