
using System;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WercsTest.DAL
{
	public static class LanguagesXmlDal
	{
		public static Array GetNames()
		{
			// Pull file into XDocument format for Linq
			XDocument langFile = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/LocalDB.xml"));

			// <3 Linq
			var retList = from lang in langFile.Root.Elements()
						  select lang.Attribute("F_Language_Name").Value;
			return retList.ToArray();
		}
	}
}