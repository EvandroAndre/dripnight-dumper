using System;
using UnityEngine;

namespace COW;

public class UIMysteryMallItemThemeView : MonoBehaviour
{
	[Serializable]
	public class UIMysteryMallItemThemeObject
	{
		public EThemeType themeType;

		public GameObject mainObject;

		public GameObject priceBg;

		public UISprite discountBg;

		public UISprite qualityBg;

		public UISprite itemNameQualityBg;

		public UILabel discountLabel;

		public UISprite SpriteBuy;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<UIMysteryMallItemThemeObject> _003C_003E9__3_0;

		internal bool _003CSetThemeActive_003Eb__3_0(UIMysteryMallItemThemeObject value)
		{
			return false;
		}
	}

	public UIMysteryMallItemThemeObject[] ThemeObjectArray;

	private UIMysteryMallItemThemeObject m_CurTheme;

	public void SetThemeActive(bool isSuperReward)
	{
	}

	public void SetDiscount(uint discount, VFXCreateHelper VFXDiscout)
	{
	}

	public void SetQualityBG(BaseItemInfo itemInfo)
	{
	}

	public static void SetItemNameTheme(UILabel label)
	{
	}

	public static void SetQualityTimeLimit(UILabel label)
	{
	}

	public static void SetDiscountPriceTheme(UILabel label)
	{
	}
}
