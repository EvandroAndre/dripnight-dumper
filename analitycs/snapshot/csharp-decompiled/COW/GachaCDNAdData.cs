using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class GachaCDNAdData
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AdvertDesc> _003C_003E9__41_0;

		public static Predicate<AdvertDesc> _003C_003E9__42_0;

		public static Predicate<AdvertDesc> _003C_003E9__43_0;

		public static Predicate<AdvertDesc> _003C_003E9__44_0;

		public static Predicate<AdvertDesc> _003C_003E9__55_0;

		public static Predicate<AdvertDesc> _003C_003E9__56_0;

		public static Predicate<AdvertDesc> _003C_003E9__57_0;

		public static Predicate<AdvertDesc> _003C_003E9__58_0;

		public static Predicate<AdvertDesc> _003C_003E9__59_0;

		public static Predicate<AdvertDesc> _003C_003E9__60_0;

		public static Predicate<AdvertDesc> _003C_003E9__61_0;

		public static Predicate<AdvertDesc> _003C_003E9__62_0;

		public static Predicate<AdvertDesc> _003C_003E9__63_0;

		public static Predicate<AdvertDesc> _003C_003E9__64_0;

		public static Predicate<AdvertDesc> _003C_003E9__69_0;

		public static Comparison<AdvertDesc> _003C_003E9__70_0;

		public static Comparison<AdvertDesc> _003C_003E9__70_1;

		internal bool _003CGetOneBuyBtnCDNBg_003Eb__41_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetMultiBuyBtnCDNBg_003Eb__42_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetGachaOneDiscountTagCDNBg_003Eb__43_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetGachaMultiDiscountTagCDNBg_003Eb__44_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerCDNProgressBarSegment1_003Eb__55_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerCDNProgressBarSegment2_003Eb__56_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerCDNProgressBarSegment3_003Eb__57_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerCDNProgressBarSegment4_003Eb__58_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerCDNProgressBarSegment5_003Eb__59_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerExtraListItem1_003Eb__60_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerExtraListItem2_003Eb__61_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerExtraListItem3_003Eb__62_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerExtraListItem4_003Eb__63_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetTokenTowerExtraListItem5_003Eb__64_0(AdvertDesc ad)
		{
			return false;
		}

		internal bool _003CGetSwitchBtnCDNBg_003Eb__69_0(AdvertDesc ad)
		{
			return false;
		}

		internal int _003CProcessData_003Eb__70_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}

		internal int _003CProcessData_003Eb__70_1(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}
	}

	private Dictionary<uint, List<AdvertDesc>> m_GachaAdsDescDict;

	private Dictionary<uint, AdvertDesc> m_GachaTabADDict;

	private Dictionary<uint, AdvertDesc> m_TurntableCDNDict;

	private Dictionary<uint, AdvertDesc> m_LuckyBagCDNDict;

	private Dictionary<uint, AdvertDesc> m_GachaCDNBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_GachaTitleCDNDict;

	private Dictionary<uint, AdvertDesc> m_GachaFrontEndCDNBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_GachaSplashCDNDict;

	private Dictionary<uint, List<AdvertDesc>> m_UnlimtedCustomBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_UnlimtedBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_ExchangeIconCDNDict;

	private Dictionary<uint, List<AdvertDesc>> m_GachaBuyBtnBgCDNDict;

	private Dictionary<uint, List<AdvertDesc>> m_GachaDiscountTagBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_PurchaseConfirmationBoxIconCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerPreviewBtnSmallBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerPreviewBtnBigBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerPrivilegePanelBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerPropertyBtnBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerAvatarTransformBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerGuaranteedDropBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerSpinForTokensCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerProgressBarMainCDNDict;

	private Dictionary<uint, AdvertDesc> m_TokenTowerProgressBarPointCDNDict;

	private Dictionary<uint, List<AdvertDesc>> m_TokenTowerProgressBarSegmentCDNDict;

	private Dictionary<uint, List<AdvertDesc>> m_TokenTowerExtraListItemCDNDict;

	private Dictionary<uint, AdvertDesc> m_FadedWheelRewardPoolBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_DoubleWheelBgCDNDict;

	private Dictionary<uint, AdvertDesc> m_DoubleWheelKeyCDNDict;

	private Dictionary<uint, List<AdvertDesc>> m_UnlimitedChestInfoCDNDict;

	public void ResetData()
	{
	}

	public void GetGachaAdRes()
	{
	}

	public List<AdvertDesc> GetCurAdList(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTabRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTurntableCDNRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetGachaCDNBgCDNRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetGachaTitleCDNBgRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetFrontEndCDNBgRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetSplashCDNRes(uint chestID)
	{
		return null;
	}

	public List<AdvertDesc> GetUnlimtedCustomCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetUnlimitedBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetExchangeCDNIcon(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetOneBuyBtnCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetMultiBuyBtnCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetGachaOneDiscountTagCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetGachaMultiDiscountTagCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetPurchaseConfirmationBoxCDNIcon(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPreviewBtnSmallCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPreviewBtnBigCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPrivilegePanelCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPropertyBtnCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerAvatarTransformCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerGuaranteedDropCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNSpinForTokens(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerProgressBarCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarPoint(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment1(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment2(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment3(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment4(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment5(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem1(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem2(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem3(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem4(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem5(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetFadedWheelRewardPoolCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetDoubleWheelCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetDoubleWheelKeyCDN(uint chestID)
	{
		return null;
	}

	public List<AdvertDesc> GetUnlimitedChestInfoCDN(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetSwitchBtnCDNBg(uint chestID)
	{
		return null;
	}

	public void ProcessData(List<AdvertDesc> adList)
	{
	}
}
