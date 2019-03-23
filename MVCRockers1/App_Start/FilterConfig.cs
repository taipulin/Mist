using System.Web;
using System.Web.Mvc;

namespace MVCRockers1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Controllers.Filters.MyLoggingFilterAttribute());
        }
    }
}
