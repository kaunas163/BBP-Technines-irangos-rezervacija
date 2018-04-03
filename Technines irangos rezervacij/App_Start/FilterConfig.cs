using System.Web;
using System.Web.Mvc;

namespace Technines_irangos_rezervacij
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
