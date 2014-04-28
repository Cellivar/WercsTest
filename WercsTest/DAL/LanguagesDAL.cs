
using System;
using System.Linq;

namespace WercsTest.DAL
{
	public static class LanguagesDal
	{
		public static Array GetLanguage(int limit)
		{
			return new LocalDBDataContext().T_Languages.Take(limit).ToArray();
		}
	}
}