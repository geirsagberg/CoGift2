using Microsoft.AspNet.Mvc;

namespace CoGift.Web.Features.Welcome
{
    public class WelcomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}