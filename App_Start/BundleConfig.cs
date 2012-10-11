using System.Web.Optimization;

namespace InitializrBootstrap
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/body.css",
                "~/Content/bootstrap-responsive.min.css",
                "~/Content/author.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/libs/modernizr-2.6.1-respond-1.1.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/libs/bootstrap.min.js",
                "~/Scripts/plugins.js",
                "~/Scripts/main.js"));
        }
    }
}