using System.Web;
using System.Web.Mvc;

namespace B3_NguyenMinhThuan_2011061100
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
