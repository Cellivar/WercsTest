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
			return View();
		}

		[HttpPost]
		public ContentResult ReverseText(string textToReverse)
		{
			return new ContentResult { Content = textToReverse.FancyStringReverse() };
		}

		[HttpGet]
		public JsonResult Languages()
		{
			return Json(LanguagesDal.GetLanguage(5), JsonRequestBehavior.AllowGet);
		}

		[HttpGet]
		public ContentResult LanguagesXml()
		{
			return null;
		}

	}
}
