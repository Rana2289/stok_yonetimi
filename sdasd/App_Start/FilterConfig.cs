using System.Web.Mvc;

namespace sdasd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomActionFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
