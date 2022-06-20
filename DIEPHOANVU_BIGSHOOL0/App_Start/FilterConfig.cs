using System.Web;
using System.Web.Mvc;

namespace DIEPHOANVU_BIGSHOOL0
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
