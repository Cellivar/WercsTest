using System.Web.Mvc;

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

	}
}
