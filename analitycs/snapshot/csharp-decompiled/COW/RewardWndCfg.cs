using System;
using System.Collections.Generic;

namespace COW;

public class RewardWndCfg
{
	public ERewardFeatureType RewardFeatureType;

	private bool m_ForceShowRewardFeaure;

	private bool m_IsShowAll;

	private bool m_IsBigPrice;

	private bool m_EnableShowFeature;

	public Action m_CloseAction;

	public Action m_OpenAction;

	public bool m_UseSkipReward;

	public bool m_EnableMerge;

	public bool m_KeepRewardListOrder;

	public bool m_BlockAllBtnExceptOKBtn;

	public bool m_EnableFastEquip;

	public bool m_EnableSparkPetRewardEquip;

	public bool m_EnableShowAnim;

	public string m_Title;

	public string m_OptionalTextKey;

	public string m_TransferHint;

	public bool m_EnableOptionalSelect;

	public bool m_IsHyperBookUnLockHiddenPageFail;

	public bool m_EnableOptionalKeyShow;

	public bool m_EnablOkBtn;

	public UICommonRewardWndController.WndStyleEnum m_Style;

	public bool m_ChildWndKeepStyle;

	public bool DoLastWndAction;

	public List<CommonRewardItemInfo> m_RewardInfoList;

	public int m_RewardInfoIndex;

	public bool HasMergedOptionalBundle;

	public bool m_HasVoucherGroup;

	public uint m_DrawShopId;

	public int targetPlanIndex;

	public uint targetSlot;

	public AutoOpenBoxBundleData m_AutoOpenBoxBundleData;

	public List<uint> OpenOptionalBundleRequestList;

	public uint OpenOptionalBundleCount;

	public bool invokeCloseActionAfterAllWndClose;

	public bool m_ShowPermanent;

	public List<CommonRewardItemInfo> m_BeforeOpenBundleList;

	public int m_BundleOpenedNum;

	public int m_BoxOpenedNum;

	public bool m_SkipBundleOpenAnim;

	public string m_CustomTipText;

	public void SetRewardFeatureParam(bool forceShowRewardFeaure = false, bool isShowAll = false, bool isBigPrice = false, bool isEnableShowFeature = false)
	{
	}

	public void SetAutoOpenData(List<CommonRewardItemInfo> rewardInfoList, AutoOpenBoxBundleData autoOpenBoxBundleData, string transferHint)
	{
	}

	public void SetAutoOpenData(AutoOpenIntegrationData autoOpenIntegrationData)
	{
	}

	public bool GetForceShowRewardFeaure()
	{
		return false;
	}

	public bool GetIsShowAll()
	{
		return false;
	}

	public bool GetIsBigPrice()
	{
		return false;
	}

	public bool GetEnableShowFeature()
	{
		return false;
	}
}
