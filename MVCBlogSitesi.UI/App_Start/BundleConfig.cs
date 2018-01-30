using System.Web.Optimization;

namespace MVCBlogSitesi.UI
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new StyleBundle("~/bundles/sitestyles").IncludeDirectory("~/Content/Site/css", "*.css"));
            bundles.Add(new StyleBundle("~/bundles/sitestyles")
                .Include("~/Content/Site/css/bootstrap.min.css"
                ,"~/Content/Site/inc/venobox/venobox.css"
                ,"~/Content/Site/css/animate.css"
                ,"~/Content/Site/css/font-awesome.min.css"
                ,"~/Content/Site/css/owl.carousel.css"
                ,"~/Content/Site/style.css"
                ,"~/Content/Site/css/responsive.css"
                ,"~/Content/Site/css/color-change-function.css"));
            //bundles.Add(new ScriptBundle("~/bundles/sitescripts").IncludeDirectory("~/Content/Site/js", "*.js"));
            bundles.Add(new ScriptBundle("~/bundles/sitescripts")
                .Include("~/Content/Site/js/vendor/jquery.1.11.1.js",
                "~/Content/Site/js/bootstrap.min.js",
                "~/Content/Site/js/jquery.sticky.js",
                "~/Content/Site/js/owl.carousel.min.js",
                "~/Content/Site/js/jquery.tweet.min.js",
                "~/Content/Site/js/instafeed.min.js",
                "~/Content/Site/js/masonry.pkgd.min.js",
                "~/Content/Site/inc/venobox/venobox.min.js",
                "~/Content/Site/js/main.js",
                "~/Content/Site/js/color-change-function.js"
                ));
            bundles.Add(new StyleBundle("~/bundles/adminstyles").IncludeDirectory("~/Content/Admin/css","*.css"));
            bundles.Add(new ScriptBundle("~/bundles/adminscripts").IncludeDirectory("~/Content/Admin/js","*.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}