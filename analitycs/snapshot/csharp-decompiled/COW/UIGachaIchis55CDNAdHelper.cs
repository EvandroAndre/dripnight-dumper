using System;
using GCommon;

namespace COW;

public static class UIGachaIchis55CDNAdHelper
{
	public enum ECdnSubType : uint
	{
		OverviewPopupBg = 1u,
		CollectionTitle,
		CollectionFg,
		CollectionBg,
		ConfirmWndBg
	}

	public static void StopDownloadIfAny(UINetworkTexture texture)
	{
	}

	public static void SetCdnTexture(UINetworkTexture texture, ECdnSubType subType, bool isMakePerfect = false, Action successCallBack = null)
	{
	}
}
