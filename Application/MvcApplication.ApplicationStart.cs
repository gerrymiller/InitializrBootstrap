using System.Web.Mvc;
using InitializrBootstrap.Application.Bootstrappers;

namespace InitializrBootstrap.Application
{
    public partial class MvcApplication
	{
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Bootstrapper.Routes();
            Bootstrapper.WebApi();
            Bootstrapper.ActionFilters();

        }
	}
}

