using System.Web;
using System.Web.Mvc;

namespace EF6_CodeFirst_Yakuza
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
