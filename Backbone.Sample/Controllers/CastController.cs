using System.Web.Mvc;
using Orchard.Themes;

namespace Backbone.Sample.Controllers
{
    [Themed]
    public class CastController : Controller {

        public ActionResult Index() {
            return View();
        }
   
    }
}