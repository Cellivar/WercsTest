using System.Web.Mvc;
using WercsTest.DAL;

namespace WercsTest.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			// Could use an actual model, but for quick'n'dirty the ViewData
			// will work just fine.
			ViewData["sqlLanguages"] = LanguagesDal.GetLanguage(5);
			ViewData["sqlXmlLanguages"] = LanguagesXmlDal.GetNames();
			return View();
		}

		[HttpPost]
		public ContentResult ReverseText(string textToReverse)
		{
			return new ContentResult { Content = textToReverse.FancyStringReverse() };
		}

		[HttpGet]
		public JsonResult LanguagesXml()
		{
			return Json(LanguagesXmlDal.GetNames(), JsonRequestBehavior.AllowGet);
		}

	}
}
