using System.Web.Mvc;

namespace MongoDbWebUi.UI.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}
