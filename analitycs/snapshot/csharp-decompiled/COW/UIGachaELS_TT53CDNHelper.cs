using System;
using GCommon;

namespace COW;

public class UIGachaELS_TT53CDNHelper
{
	public enum ECDNSubType
	{
		NONE = 0,
		CONTENT_BG = 1,
		PURCHASE_BG = 2,
		PURCHASE_BG_ICON = 3,
		REWARD_PREVIEW_BG = 6,
		COMPLETE_REMINDER_ICON = 7,
		COMPLETE_REMINDER_BG = 9,
		REWARD_BG = 10,
		SHARE_BG = 12
	}

	public static void SetCDNBG(UINetworkTexture texture, ECDNSubType subType, Action successCallBack = null)
	{
	}

	public static string GetCDNURL(ECDNSubType subType)
	{
		return null;
	}
}
