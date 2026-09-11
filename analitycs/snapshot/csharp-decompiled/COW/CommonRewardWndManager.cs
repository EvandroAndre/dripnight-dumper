using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class CommonRewardWndManager : SingletonModule<CommonRewardWndManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__12_0;

		internal void _003CShowWeaponPermanentView_003Eb__12_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public UnlockMatchRewardWndCfg cfg;

		public CommonRewardWndManager _003C_003E4__this;

		internal void _003CShowUnlockMatchRewardView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public RewardWndCfg cfg;

		internal void _003CShowWeaponPermanentView_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public Action deferredCloseAction;

		internal void _003CShowWeaponPermanentView_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public RewardWndCfg cfg;

		public CommonRewardWndManager _003C_003E4__this;

		internal void _003CShowRewardsView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public BaseItemInfo itemInfo;

		internal bool _003CSetWeaponPermanentDataForGacha_003Eb__0(CommonRewardItemInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_1
	{
		public uint id;

		internal bool _003CSetWeaponPermanentDataForGacha_003Eb__1(CommonRewardItemInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public UICommonRewardWndController ctrl;

		public uint rowId;

		public Dictionary<ulong, uint> itemActivityIds;

		public Action<uint> selectAction;

		internal void _003CShowOptionalTaskRewardView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public OptionalRewardWndCfg cfg;

		internal void _003CShowOptionalBundleView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public HippoCrisisStoreWndCfg cfg;

		internal void _003CShowHippoCrisisStoreView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public OptionalRewardRankInfoWndCfg cfg;

		public CommonRewardWndManager _003C_003E4__this;

		internal void _003CShowLadderRankUpView_003Eb__0()
		{
		}
	}

	public const int MAX_ITEM_SHOWED_PER_POPUP = 5;

	public const int MAX_ITEM_SHOWED_PER_POPUP_DOUBLE_ROW = 10;

	private Queue<RewardWndCfg> m_RewardWndCfgQueue;

	private RewardWndCfg m_CurrentRewardWndCfg;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ShowOptionalTaskRewardView(List<BaseItemInfo> rewardList, Dictionary<ulong, uint> itemActivityIds, uint rowId, string title = "T_37_LQ_ACTIVITY_EXCHANGETITLE", Action<uint> selectAction = null)
	{
	}

	public void ShowOptionalBundleView(OptionalRewardWndCfg cfg)
	{
	}

	public void ShowHippoCrisisStoreView(HippoCrisisStoreWndCfg cfg)
	{
	}

	public void ShowLadderRankUpView(OptionalRewardRankInfoWndCfg cfg)
	{
	}

	public void ShowUnlockMatchRewardView(UnlockMatchRewardWndCfg cfg)
	{
	}

	public void ShowLevelUpReward(List<CommonRewardItemInfo> list, uint newLevel, Action closeAction = null)
	{
	}

	public bool ShowWeaponPermanentView(RewardWndCfg cfg, bool needSendFinish = false, bool hideDeltaTime = true, bool notShowPermanentInNextWnd = false, bool showFull = false)
	{
		return false;
	}

	public UICommonRewardWndController ShowRewardsView(RewardWndCfg cfg, bool inGameOpen = false)
	{
		return null;
	}

	private UICommonRewardWndController ShowCommonRewardWnd(RewardWndCfg cfg, bool showWeaponPermanent)
	{
		return null;
	}

	public bool ShowRewardsViewByBigEvent(ExchangeChangeData exchangeChangeData, UICommonRewardWndController.WndStyleEnum wndStyleEnum, Action closeAction = null, string customTipText = "")
	{
		return false;
	}

	public void ShowRewardsViewWithRewardList(List<CommonRewardItemInfo> rewardInfoList, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, ERewardFeatureType featureType = ERewardFeatureType.None, Action closeAction = null, bool useSkipReward = false, bool invokeCloseActionAfterAllWndClose = false, bool keepRewardListOrder = false)
	{
	}

	public bool ShowRewardsViewWithAutoOpenData(ExchangeChangeData exchangeChangeData, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, ERewardFeatureType featureType = ERewardFeatureType.None, Action closeAction = null, bool useSkipReward = false, bool protectBPCards = false, bool enableSparkPetRewardEquip = false)
	{
		return false;
	}

	public bool ShowRewardsViewWithAutoOpenData(List<ExchangedAward> exchangedAwardsList, AwardData awardData, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, ERewardFeatureType featureType = ERewardFeatureType.None, Action closeAction = null, bool useSkipReward = false)
	{
		return false;
	}

	public bool ShowRewardsViewWithAutoOpenData(AutoOpenIntegrationData autoOpenIntegrationData, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, ERewardFeatureType featureType = ERewardFeatureType.None, Action closeAction = null, bool useSkipReward = false)
	{
		return false;
	}

	public void ShowRewardsViewWithRewardListOnly(List<CommonRewardItemInfo> rewardInfoList)
	{
	}

	private void SortRewardItemInfoList(RewardWndCfg cfg)
	{
	}

	private int CompareCommonRewardItemInfo(CommonRewardItemInfo a, CommonRewardItemInfo b)
	{
		return 0;
	}

	public void SetWeaponPermanentDataForGacha(RewardWndCfg cfg, List<CommonRewardItemInfo> commonRewardItemInfos)
	{
	}

	public bool CheckPermanentFull(RewardWndCfg cfg)
	{
		return false;
	}

	private bool ProcessPermanentValue(RewardWndCfg cfg, bool keepPermanentBeforeVal = false)
	{
		return false;
	}

	private bool HasOtherWndAfterRewardsShow(RewardWndCfg cfg)
	{
		return false;
	}

	private int CompareOptionalBundleItemInfo(CommonRewardItemInfo a, CommonRewardItemInfo b)
	{
		return 0;
	}

	private bool CanNotShowRewardWnd(bool inGameOpen = false)
	{
		return false;
	}

	public bool CanNotShowRewardWndExternal(bool inGameOpen = false)
	{
		return false;
	}
}
