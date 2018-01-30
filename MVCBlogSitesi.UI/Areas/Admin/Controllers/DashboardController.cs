using System.Web.Mvc;

namespace AdminLayout.Areas.Admin.Controllers
{
    [Authorize]
    //sadece oturum açanlar ulaşsın
    public class DashboardController : Controller
    {

        [OutputCache(Duration =30)]
        public ActionResult Index()
        {
            ViewBag.UserName = HttpContext.User.Identity.Name;

            return View();
        }
    }
}