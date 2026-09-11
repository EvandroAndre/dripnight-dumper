using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class LocGlobalComponent
{
	public class Language
	{
		public string Name;

		public string FontNormal;

		public string FontBold;

		public int UILabelTopMargin;

		private Font fontNormalRes;

		private Font fontBoldRes;

		public Font FontNormalRes => null;

		public Font FontBoldRes => null;

		public void ResetFont()
		{
		}

		private Font LoadFontRes(string fontpath)
		{
			return null;
		}
	}

	public List<Language> Languages;
}
