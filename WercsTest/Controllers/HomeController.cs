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
			return View();
		}

		[HttpPost]
		public ContentResult ReverseText(string textToReverse)
		{
			return new ContentResult { Content = textToReverse.FancyStringReverse() };
		}

		[HttpGet]
		public ContentResult LanguagesXml()
		{
			return null;
		}

	}
}
