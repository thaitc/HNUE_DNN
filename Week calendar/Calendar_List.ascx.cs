using Hnue.Helper;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using Week_calendar.DataAccess;

namespace Week_calendar
{
    public partial class Calendar_List : BaseController
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
            var db = new CalendarDataContext();
            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = db.CALENDAR_MANAGERs.OrderByDescending(i => i.Id).ToList();
            pgitems.AllowPaging = true;
            pgitems.PageSize = 2;
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
            pgitems.DataSource = db.CALENDAR_MANAGERs.OrderByDescending(i => i.Id).ToList();
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
            var db = new CalendarDataContext();
            db.CALENDAR_MANAGERs.DeleteOnSubmit(db.CALENDAR_MANAGERs.First(i => i.Id == ((LinkButton)sender).CommandArgument.ToInt()));
            db.SubmitChanges();
            LoadData();
        }

        protected void bt_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}