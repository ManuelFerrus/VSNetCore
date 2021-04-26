using System.Web;
using System.Web.Mvc;

namespace TecgurusAdvanced2021.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
