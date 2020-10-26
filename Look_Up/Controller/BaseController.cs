
using DotNetNuke.Common;
using DotNetNuke.Entities.Modules;
using System.Linq;
using System.Web.UI.WebControls;

namespace Look_Up
{
    public class BaseController: PortalModuleBase
    {
        public virtual string BuildUrl( string control, params string[] ps)
        {
            var prm = ps.ToList();
            prm.Add("moduleId=" + ModuleId);
            if (!string.IsNullOrEmpty(control))
            {
                prm.Add("control=" + control);
            }
            return Globals.NavigateURL(TabId, "", prm.ToArray());
        }   
      //  public SVDataContext DataContext { get; private set; }
    }
}