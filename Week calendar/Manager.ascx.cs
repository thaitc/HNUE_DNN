using Hnue.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Week_calendar.DataAccess;

namespace Week_calendar
{
    public partial class Manager : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void bt_Update_Click(object sender, EventArgs e)
        {
            var datacontext = new CalendarDataContext();
            var userId = Request.QueryString["id"].ToInt();
            var c = datacontext.CALENDAR_MANAGERs.FirstOrDefault(i => i.Id == userId) ?? new CALENDAR_MANAGER();
            c.Titel = Titel.Text;
            c.Content = yourTextBoxID.Text;
            c.Update = DateTime.UtcNow;
            c.Update_by = ModuleContext.PortalSettings.UserInfo.Username;
            datacontext.CALENDAR_MANAGERs.InsertOnSubmit(c);
            datacontext.SubmitChanges();
            Response.Redirect(BuildUrl("Calendar_List"));
        }

        protected void bt_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(BuildUrl("Calendar_List"));
        }
    }
}