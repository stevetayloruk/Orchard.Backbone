using System.Web.Mvc;
using Orchard.UI.Admin;

namespace Backbone.Sample.Controllers
{
    public class ActorsAdminController : Controller {

        [Admin]
        public ActionResult Index() {
            return View();
        }
    }
}