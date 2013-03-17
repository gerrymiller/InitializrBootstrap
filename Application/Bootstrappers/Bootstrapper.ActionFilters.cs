using System.Web.Mvc;

namespace InitializrBootstrap.Application.Bootstrappers
{
    public partial class Bootstrapper
    {
        public static void ActionFilters()
        {
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
            //GlobalFilters.Filters.Add(new AuthorizeAttribute());
        }
    }
}