using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjWeb.WatchYourself.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
