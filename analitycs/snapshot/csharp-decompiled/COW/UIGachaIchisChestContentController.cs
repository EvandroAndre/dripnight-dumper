using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchisChestContentController : UIGachaContentBase
{
	private class FlyOutV3Card
	{
		public UIGachaIchisNormalTableController Ctrl;

		public int LogicalIndex;

		public int AppliedDepthOffset;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__144_0;

		internal CommonRewardItemInfo _003CShowIchisRewardWnd_003Eb__144_0(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public int slot;

		public int beatIndex;

		public UIGachaIchisChestContentController _003C_003E4__this;

		internal void _003CScheduleFlyOutV3Beats_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public int slot;

		public UIGachaIchisChestContentController _003C_003E4__this;

		internal void _003CScheduleFlyOutV3BottomRecycle_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass141_0
	{
		public UIGachaIchisChestContentController _003C_003E4__this;

		public ESharedGacha.DrawStatus capturedStatus;

		internal void _003CPlayDrawAnimAndReward_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass144_0
	{
		public UIGachaIchisChestContentController _003C_003E4__this;

		public List<CommonRewardItemInfo> rewardInfoList;

		public List<IchisBarrageData> selfBarrageData;

		public ESharedGacha.DrawStatus status;

		internal void _003CShowIchisRewardWnd_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public UIGachaIchisChestContentController _003C_003E4__this;

		public List<CommonRewardItemInfo> showCongratulationsList;

		public int index;

		public Action onComplete;

		internal void _003CPlayIchisCongratulationsAt_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public UIGachaIchisChestContentController _003C_003E4__this;

		public List<IchisBarrageData> selfBarrageData;

		internal void _003COpenIchisRewardWnd_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass152_0
	{
		public Action onSwitch;

		public UIGachaIchisChestContentController _003C_003E4__this;

		internal void _003CBuildPostRewardCloseAction_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public bool recheckForceReasonOnClose;

		public UIGachaIchisChestContentController _003C_003E4__this;

		public uint chestId;

		public uint chestSubId;

		public CSSwitchSharedGachaPoolReq.SwitchType switchType;

		internal void _003CBuildForceSwitchAction_003Eb__0()
		{
		}
	}

	private sealed class _003CInitBarrageLaunchers_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIchisChestContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitBarrageLaunchers_003Ed__50(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003COnlineCountPollingLoop_003Ed__161 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaIchisChestContentController _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnlineCountPollingLoop_003Ed__161(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIGachaIchisChestContentView m_View;

	private UIModelIchis m_ModelIchis;

	private UIModelBarrage m_ModelBarrage;

	private UIGachaIchisBuyBtnController m_IchisBuyBtnCtrl;

	private UIGachaIchisNormalTableController m_TableCtrl;

	private UIBarragePanelComponent m_BarragePanelComponent;

	private HashSet<int> m_BarrageTypes;

	private bool m_BarrageInitialized;

	private uint m_CurrentJackPot;

	private bool m_HasPoolData;

	private bool m_IsPoolDataReady;

	private bool m_IsPrimeBlocked;

	private bool m_SwitchPoolAvailable;

	private bool m_TcpEmptyPoolSwitchEntry;

	private uint m_PendingChestId;

	private uint m_PendingChestSubId;

	private Coroutine m_OnlineCountCoroutine;

	private const int SWITCH_FAKE_POOL_COUNT = 3;

	private const int SWITCH_ANIM_SEGMENT_COUNT = 4;

	private const float SWITCH_FAKE_SEGMENT_DURATION = 0.17f;

	private const float SWITCH_FINAL_LINEAR_DURATION = 0.085f;

	private const float SWITCH_FINAL_DECEL_DURATION = 0.5f;

	private const float SWITCH_SLIDE_DISTANCE = 670f;

	private const string SWITCH_POOL_SOUND_RES_NAME = "SOUND_UI_GACHA_ICHIS_SWITCHBOARD";

	private UIGachaIchisNormalTableController m_PendingTableCtrl;

	private bool m_IsSwitchAnimating;

	private Vector3 m_SwitchAnimAnchorPos;

	private uint m_SwitchAnimDelayCallID;

	private int m_SwitchAnimSegmentIndex;

	private IchisTransitionPoolDisplayData m_SwitchFakePoolDisplayData;

	private bool m_TableCtrlDisplaysFakePool;

	private bool m_PendingTableCtrlDisplaysFakePool;

	private bool m_SwitchAnimFinalPhaseBPending;

	private uint m_TableBoundChestId;

	private uint m_TableBoundChestSubId;

	private bool m_SwitchPoolRequestInFlight;

	private bool m_NextSwitchPoolShouldAnimate;

	private bool m_PendingEnterPoolForceCheck;

	private static readonly bool USE_FLY_OUT_V3_ANIMATION;

	private const int FLY_OUT_V3_PANEL_DEPTH_SPAN = 4;

	private const int FLY_OUT_V3_MIN_DECK_SIZE = 1;

	private const string FLY_OUT_V3_END_ANIM_EVENT = "IchisPoolSwitchEnd";

	private List<FlyOutV3Card> m_FlyOutV3Deck;

	private List<FlyOutV3Card> m_FlyOutV3Recyclable;

	private int m_FlyOutV3FlyCount;

	private Vector3 m_FlyOutV3AnchorPos;

	private bool m_IsFlyingOutV3;

	private IchisPoolSwitchAnimConfig m_FlyOutV3ActiveConfig;

	private List<uint> m_FlyOutV3BeatDelayCallIDs;

	private List<uint> m_FlyOutV3HideDelayCallIDs;

	private uint m_FlyOutV3FinalizeDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	public override Transform GetPrimeCountDownPos()
	{
		return null;
	}

	public override Transform GetNoPrimeTipsTrans()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	private void InitTableController()
	{
	}

	public override void OnShowContent()
	{
	}

	public override void OnHideContent()
	{
	}

	private void StartBarrage()
	{
	}

	private IEnumerator InitBarrageLaunchers()
	{
		return null;
	}

	private void StopBarrage()
	{
	}

	private BarrageData GetBarrageData(uint rowId)
	{
		return null;
	}

	protected override void OnRefreshUIView()
	{
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool IsBarragePropForCurrentPool(object[] param)
	{
		return false;
	}

	private bool IsParamForCurrentPool(object[] param)
	{
		return false;
	}

	private bool IsAccountParamForCurrentPool(object[] param)
	{
		return false;
	}

	private bool IsDrawResultParamForCurrentPool(object[] param)
	{
		return false;
	}

	private void RefreshCDNTitle()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void RefreshPrimeShowState()
	{
	}

	private void OnPrimeStateChanged()
	{
	}

	private bool CanShowBuyButton()
	{
		return false;
	}

	private void CheckPrimeEarlyPurchase(uint chestId, uint chestSubId)
	{
	}

	private void RefreshGuaranteedDisplay(uint chestId, uint chestSubId)
	{
	}

	private Action BuildForceSwitchAction(CSSwitchSharedGachaPoolReq.SwitchType switchType, bool recheckForceReasonOnClose)
	{
		return null;
	}

	private void TryShowEnterPoolForceSwitch(uint chestId, uint chestSubId)
	{
	}

	private void ShowForceSwitchPopup(Action onClose)
	{
	}

	private void RefreshSwitchPoolState()
	{
	}

	private void RefreshTcpEmptyPoolSwitchEntry(UIModelIchis.PoolDataUpdateSource source)
	{
	}

	private void SetTcpEmptyPoolSwitchEntry(bool active)
	{
	}

	private void RefreshSwitchPoolButtonVisibility()
	{
	}

	private void HideSwitchPoolUI()
	{
	}

	public void OnSwitchPoolBtnClick()
	{
	}

	private void OnSwitchPoolComplete()
	{
	}

	private void ResetPreviewToConfiguredChestModel()
	{
	}

	private void BeginPoolFlyOutAnimationV3()
	{
	}

	private IchisPoolSwitchAnimConfig GetFlyOutV3Config()
	{
		return null;
	}

	private bool TryBeginPoolFlyOutAnimationV3()
	{
		return false;
	}

	private FlyOutV3Card WrapExistingTableAsFlyOutV3Card()
	{
		return null;
	}

	private FlyOutV3Card CreateFlyOutV3Card()
	{
		return null;
	}

	private FlyOutV3Card TakeRecyclableOrCreateFlyOutV3Card()
	{
		return null;
	}

	private void SetupFlyOutV3Card(FlyOutV3Card card, int logicalIndex, bool keepCurrentData, bool useRealPool)
	{
	}

	private void RefreshFlyOutV3DeckDepth()
	{
	}

	private void AbortFlyOutV3Setup()
	{
	}

	private void ScheduleFlyOutV3Beats()
	{
	}

	private void OnFlyOutV3Beat(int beatIndex)
	{
	}

	private void OnFlyOutV3AnimEvent(object[] data)
	{
	}

	private void RecycleFlyOutV3OthersExceptRealPool()
	{
	}

	private void ScheduleFlyOutV3BottomRecycle(float delay)
	{
	}

	private void RecycleFlyOutV3Bottom()
	{
	}

	private void RecycleFlyOutV3Card(FlyOutV3Card card)
	{
	}

	private void OnFlyOutV3FinishTimeReached()
	{
	}

	private void EnsureFlyOutV3AnimationFinalized()
	{
	}

	private void FinalizeFlyOutV3Animation(bool interrupted)
	{
	}

	private FlyOutV3Card FindFlyOutV3Survivor()
	{
		return null;
	}

	private void CloseFlyOutV3CardsExcept(UIGachaIchisNormalTableController survivor)
	{
	}

	private void CloseFlyOutV3CardList(List<FlyOutV3Card> cards, UIGachaIchisNormalTableController survivor)
	{
	}

	private void CancelDelayCallList(List<uint> ids)
	{
	}

	public void DebugTriggerPoolFlyOutV3Animation()
	{
	}

	private void RefreshPoolItemsDisplay()
	{
	}

	private void RefreshTierRemainingDisplay()
	{
	}

	private void RefreshAccountCountDisplay()
	{
	}

	private bool RefreshChangedPoolItemsDisplay(object[] param)
	{
		return false;
	}

	private bool TryRefreshAllItemsInPlaceForTcpDraw(UIModelIchis.PoolDataUpdateSource poolUpdateSource)
	{
		return false;
	}

	private static uint[] GetChangedPoolItemIds(object[] param)
	{
		return null;
	}

	private void OnSwitchPoolFailed()
	{
	}

	private void OnPoolSwitched()
	{
	}

	private void BeginPoolSwitchAnimation()
	{
	}

	private void PlaySwitchPoolSound()
	{
	}

	private bool TryBeginChainedPoolSwitchAnimation()
	{
		return false;
	}

	private void PlayNextSwitchAnimationSegment()
	{
	}

	private void BindSwitchTable(UIGachaIchisNormalTableController table, bool useRealPool)
	{
	}

	private void RefreshSwitchFakeTableIfNeeded(UIGachaIchisNormalTableController table)
	{
	}

	private IchisTransitionPoolDisplayData BuildSwitchFakePoolDisplayData()
	{
		return null;
	}

	private bool GetSwitchTableFakeFlag(UIGachaIchisNormalTableController table)
	{
		return false;
	}

	private void SetSwitchTableFakeFlag(UIGachaIchisNormalTableController table, bool isFakePool)
	{
	}

	private void OnSwitchAnimEnd()
	{
	}

	private void CompleteSwitchAnimationSegment()
	{
	}

	private void EnsureSwitchAnimationFinalized()
	{
	}

	private void EnsurePoolSwitchAnimationsFinalized()
	{
	}

	private void FinalizeSwitchAnimation()
	{
	}

	private void KillSlideTween(UIGachaIchisNormalTableController ctrl)
	{
	}

	private void OnDrawResult()
	{
	}

	private void HandleDrawStatusFanOut()
	{
	}

	private void PlayDrawAnimAndReward(ESharedGacha.DrawStatus status)
	{
	}

	private void ResetBuyBtnAfterDraw()
	{
	}

	private void OnDrawAnimEnd(ESharedGacha.DrawStatus status)
	{
	}

	private void ShowIchisRewardWnd(ESharedGacha.DrawStatus status)
	{
	}

	private List<CommonRewardItemInfo> BuildIchisCongratulationsList(List<CommonRewardItemInfo> rewardInfoList, List<ExchangedAward> awards)
	{
		return null;
	}

	private uint GetIchisAwardSourceItemId(ExchangedAward award, CommonRewardItemInfo info)
	{
		return 0u;
	}

	private void ApplyIchisAutoOpenSourceTag(CommonRewardItemInfo info, ExchangedAward award)
	{
	}

	private CommonRewardItemInfo BuildIchisCongratulationsInfo(CommonRewardItemInfo info, uint itemId)
	{
		return null;
	}

	private void PlayIchisCongratulations(List<CommonRewardItemInfo> showCongratulationsList, Action onComplete)
	{
	}

	private void PlayIchisCongratulationsAt(List<CommonRewardItemInfo> showCongratulationsList, int index, Action onComplete)
	{
	}

	private void OpenIchisRewardWnd(List<CommonRewardItemInfo> rewardInfoList, List<IchisBarrageData> selfBarrageData, ESharedGacha.DrawStatus status)
	{
	}

	private Action BuildPostRewardCloseAction(ESharedGacha.DrawStatus status)
	{
		return null;
	}

	private void ShowDrawPartialPopup(Action onClose)
	{
	}

	private bool TryEnableIchisContinueDraw(UICommonRewardWndController ctrl, ELottery.LotteryType drawType)
	{
		return false;
	}

	private UIGachaBuyBtnController.BuyBtnState ResolveIchisAwareTenBuyBtnState()
	{
		return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
	}

	private uint ResolveIchisCurrencyPrice(UIModelGacha.GachaDrawType dType)
	{
		return 0u;
	}

	private string ResolveIchisRepurchaseLabel(UIModelGacha.GachaDrawType dType)
	{
		return null;
	}

	private void OnDrawFailed()
	{
	}

	private void StartOnlineCountPolling()
	{
	}

	private void StopOnlineCountPolling()
	{
	}

	private IEnumerator OnlineCountPollingLoop()
	{
		return null;
	}

	private void RefreshOnlineCountDisplay()
	{
	}

	private void _003CRefreshCDNTitle_003Eb__60_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__61_0()
	{
	}

	private void _003CBuildPostRewardCloseAction_003Eb__152_1()
	{
	}

	private void _003CBuildPostRewardCloseAction_003Eb__152_2()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	public FrontendPreviewType _003C_003EiFixBaseProxy_GetFrontendPreviewType(uint P0)
	{
		return FrontendPreviewType.Lobby;
	}

	public Transform _003C_003EiFixBaseProxy_GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetNoPrimeTipsTrans()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}
