using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIGachaLimitContent : UIGachaContentBase, IUIModelDataChangeObserver, ILuckySpinContent
{
	private enum AutoRemoveCategory
	{
		Other,
		GachaTicket,
		Token,
		Unique
	}

	private enum CircleStage
	{
		NORMAL_RUNNING,
		GET_REWARD,
		END
	}

	private class RewardIdx
	{
		public int idx;

		public int iterationIdx;
	}

	private class RateCurve
	{
		public float a;

		public int powers;

		public float endY;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__18_0;

		internal void _003CShowExchangeResultWnd_003Eb__18_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public List<ItemTagInfo> launchTagItems;

		internal CommonRewardItemInfo _003CShowExchangeResultWnd_003Eb__1(ExchangedAward item)
		{
			return null;
		}
	}

	private const int LIMIT_POOL_DISPLAY_ITEM_COUNT = 10;

	private bool isInPreview;

	private UIGachaLimitContentView m_View;

	private List<GameObject> m_ItemPosList;

	private List<GachaShowItem> m_ItemList;

	private List<UIGachaLimitItemController> m_ItemCtrlList;

	private List<UIGachaExtraListItemController> m_ExtraList;

	private GachaLimitInfoData m_GachaInfo;

	private uint m_AutoSelectRemoveItemsGachaID;

	private bool m_HasAutoSelectRemoveItems;

	private RateCurve m_Curve;

	private List<RewardIdx> m_RewardIdxList;

	private int m_CurRewardIdx;

	private int m_IterationCounter;

	private uint m_CircleDC;

	private bool m_IsSingleCircle;

	private bool m_IsSkip;

	private const int FAKE_CIRCLE_CNT = 2;

	private const int TURNTABLE_REWARD_CNT = 10;

	private const float GET_REWARD_SHOW_SECOND = 1f;

	private const float FAST_ROUND_CD_SECOND = 0.05f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnSkipAnim()
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	private void ShowExchangeResultWnd(object[] data)
	{
	}

	public void RefreshExtraRewardList()
	{
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	private void AssembleTurntable()
	{
	}

	private void RefreshAllBtnState(bool finishRemove)
	{
	}

	protected override void OnPreviewSceneShowTypeChange()
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
	{
	}

	protected override void OnRefreshUIView()
	{
	}

	private void CheckShowPrimeAccess()
	{
	}

	public override Transform GetPrimeCountDownPos()
	{
		return null;
	}

	public override Transform GetNoPrimeTipsTrans()
	{
		return null;
	}

	private void RefreshPrimeShowState()
	{
	}

	private void SetCDNTitle()
	{
	}

	private void SetCDNBg()
	{
	}

	private void RefreshRewardPool(bool needResetState = true)
	{
	}

	private List<GachaShowItem> GetLimitPoolDisplayItemList()
	{
		return null;
	}

	private void TryAutoSelectRemoveItems(bool curRemoveState)
	{
	}

	private List<uint> GetDefaultRemoveItemIds()
	{
		return null;
	}

	private bool IsDefaultRemoveCandidate(GachaShowItem item)
	{
		return false;
	}

	private int CompareDefaultRemoveItem(GachaShowItem itemA, GachaShowItem itemB)
	{
		return 0;
	}

	private int GetDefaultRemoveOwnedPriority(GachaShowItem item)
	{
		return 0;
	}

	private AutoRemoveCategory GetDefaultRemoveCategory(GachaShowItem item)
	{
		return AutoRemoveCategory.Other;
	}

	private bool IsDefaultRemoveGachaTicket(EInventory.ItemSubType itemSubType)
	{
		return false;
	}

	private bool IsDefaultRemoveToken(EInventory.ItemSubType itemSubType)
	{
		return false;
	}

	private uint GetDefaultRemoveQuality(GachaShowItem item)
	{
		return 0u;
	}

	private void RefreshCountDownLabel()
	{
	}

	public override void OnShowContent()
	{
	}

	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	private void OnRemoveClick()
	{
	}

	private bool IsSameRemoveItems(List<uint> itemListA, List<uint> itemListB)
	{
		return false;
	}

	private void OnRareProbabilityClick()
	{
	}

	public void Circle(GachaResultInfo info)
	{
	}

	public override void OnHideContent()
	{
	}

	private void DoCircle()
	{
	}

	private void SetOutstand(int idx, UIGachaLimitItemController.ViewStage stage)
	{
	}

	private void ShowResultView()
	{
	}

	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return CircleStage.NORMAL_RUNNING;
	}

	private int RandomFindIdx(ExchangedAward award)
	{
		return 0;
	}

	private void Reset()
	{
	}

	private void GenRewardIndexList(GachaResultInfo info)
	{
	}

	private void BuildFirstLapRateCurve()
	{
	}

	private void SetItemPreviewState(uint itemId)
	{
	}

	public void SetItemPreviewState(BaseItemInfo info, int index = 0)
	{
	}

	private void OnRewardPoolOpen()
	{
	}

	public override void CloseRewardPool()
	{
	}

	private void RefreshCountDownShowState(bool show)
	{
	}

	private void OnPreviewItemBtnClick()
	{
	}

	private void OnRewardPoolClose()
	{
	}

	private void OnRewardPoolClose(object[] data)
	{
	}

	private float RateSample(int curIterationCounter)
	{
		return 0f;
	}

	private bool IsInFirstCircle(int curIdx)
	{
		return false;
	}

	private float RateCelling(float rate)
	{
		return 0f;
	}

	public void RefreshLuckySpinBtn()
	{
	}

	public void OpenRewardWnd()
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CSetCDNBg_003Eb__31_0()
	{
	}

	private void _003CShowResultView_003Eb__67_0()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPreviewSceneShowTypeChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationToGachaReward(uint P0)
	{
	}

	public Transform _003C_003EiFixBaseProxy_GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetNoPrimeTipsTrans()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	public void _003C_003EiFixBaseProxy_CloseRewardPool()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
