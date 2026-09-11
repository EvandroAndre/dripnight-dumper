using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopLimitedContentController : UIDrawShopContentBaseController
{
	private enum DrawShopLimitedState
	{
		None,
		Selected,
		MultiDrawAnimation,
		ShowDropReward
	}

	private enum ERebackAnimStep
	{
		WaitBeforeReback,
		PlayDropItemReback,
		PlayPoolItemReback,
		Complete
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__48_0;

		internal void _003CInitCGReplayNodes_003Eb__48_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIDrawShopLimitedContentController _003C_003E4__this;

		public int capturedIndex;

		internal void _003CCreateDropItemForReward_003Eb__0(int index)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public int capturedIndex;

		public UIDrawShopLimitedContentController _003C_003E4__this;

		internal void _003CCreatePendingDropItemsOnInit_003Eb__0(int clickIndex)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_1
	{
		public int capturedIndex;

		public UIDrawShopLimitedContentController _003C_003E4__this;

		internal void _003CCreatePendingDropItemsOnInit_003Eb__1(int clickIndex)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public UIDrawShopLimitedContentController _003C_003E4__this;

		public long primeStartTime;

		public long startTimeStamp;

		public Action onCountDownFinished;

		internal void _003CShowPrimeLimitedTips_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public UIDrawShopLimitedContentController _003C_003E4__this;

		public int poolIndex;

		internal void _003CPlayDirectDropForReward_003Eb__0()
		{
		}
	}

	private const float CIRCLE_REWARD_DISPLAY_TIME_QUICK = 0.01f;

	private const float CIRCLE_REWARD_DISPLAY_TIME_MIN = 0.2f;

	private const float SELECT_REWARD_DISPLAY_TIME = 0.4f;

	private const float SHOW_REWARD_DELAY = 1.35f;

	private const int FAKE_CIRCLE_CNT = 15;

	private const int QUICK_CIRCLE_CNT_MIN = 2;

	private const int QUICK_CIRCLE_CNT_MAX = 6;

	private const float DIRECT_DROP_DELAY = 0.3f;

	private const float DROP_NEXT_REWARD_DELAY = 0.5f;

	private UIDrawShopLimitedContentView m_View;

	private UIDrawShopLimitedBuyBtnController m_DrawShopBuyBtnCtrl;

	private DrawShopLimitedPoolSettingDesc m_SettingDesc;

	private DrawShopLimitedPoolChangeSkinDesc m_SkinDesc;

	private UIDrawShopLimitedLayoutRewardController m_LayoutController;

	private Dictionary<EDrawShopLayoutType, UIDrawShopLimitedLayoutRewardController> m_LayoutControllerDict;

	private List<UIDrawShopLimitedRewardItemController> m_CachedRewardItems;

	private int m_SelectedItemIndex;

	private List<UIDrawShopLimitedRewardItemController> m_DrawResultItems;

	private List<ExchangedAward> m_CachedExchangedAwards;

	private List<ItemTagInfo> m_CachedTagItems;

	private uint m_CachedSelectedPoolItemId;

	private DrawShopLimitedState m_CurrentState;

	private bool m_IsInitialized;

	private uint m_LoopDelayCall;

	private uint m_PoolItemSetDropStateDelayCall;

	private const float POOL_ITEM_SET_DROP_STATE_DELAY = 0.15f;

	private uint m_ShowDefaultDisplayModelDelayCall;

	private uint m_PrimeLimitedTipsDelayCall;

	private DelayCallSequencer m_RebackAnimSequencer;

	private Queue<int> m_DrawResultIndexes;

	private int m_SelectedDrawResultIndex;

	private int m_HighlightIndex;

	private int m_IterationCounter;

	private int m_NextRewardCount;

	private int m_MaxRewardCount;

	private int m_MaxItemCount;

	private const int TOTAL_TURN = 8;

	private int m_NextTurn;

	private bool m_HasPendingPurchase;

	private bool m_IsShowingGuide;

	private bool m_HasPendingDrawAnimation;

	private bool m_PreviewUIHide;

	private bool m_PlayedPreviewAnim;

	private HashSet<uint> m_PreviewItemIdSet;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCGReplayNodes()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void ShowPreview(BaseItemInfo itemInfo, bool skipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void ShowPreview(DrawShopPoolItemData itemData, bool skipAnim = false, bool needSkipKillNotify = false)
	{
	}

	private bool IsPreviewItemShown(uint itemId)
	{
		return false;
	}

	private void MarkPreviewItemShown(uint itemId)
	{
	}

	private void ShowHidePreviewUI(bool show)
	{
	}

	protected override void InitBuyButtons()
	{
	}

	protected override void OnRefreshContentUI()
	{
	}

	protected override UIWidget GetContentPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetContentPreviewType()
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

	public override GameObject GetTimeContainsObject()
	{
		return null;
	}

	public override GameObject GetBuyButtonObject()
	{
		return null;
	}

	public override void OnContentShow()
	{
	}

	protected override void ApplyNonPrimeState()
	{
	}

	protected override void ShowPrimeLimitedTips(EGachaPrimeLimitedTipsStyle style, long primeStartTime, long startTimeStamp, Action onCountDownFinished = null)
	{
	}

	protected override void ShowPrimeAccess()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshCountdown()
	{
	}

	private void OnCountdownEnd()
	{
	}

	private void RefreshRewardPool()
	{
	}

	private void RefreshCachedRewardItems()
	{
	}

	private void CreateOrSwitchLayoutController(EDrawShopLayoutType layoutType, List<DrawShopPoolItemData> poolData)
	{
	}

	private List<DrawShopPoolItemData> GetPoolRewardData()
	{
		return null;
	}

	private Transform GetDropItemTransform(int index)
	{
		return null;
	}

	private UIDrawShopLimitedRewardItemController CreateRewardItemByRarity(DrawShopPoolItemData itemData, Transform parentTransform)
	{
		return null;
	}

	private void ClearDrawResultItems(bool clearModelSelection = true)
	{
	}

	private void SetCDN()
	{
	}

	private void StopAllCDNDownloads()
	{
	}

	private void RefreshGoodsBgColor(bool isInit = true)
	{
	}

	public void OnBuy()
	{
	}

	public override void RefreshBuyButtonState()
	{
	}

	private void UpdateBuyButtonEnabled()
	{
	}

	private bool HasSelectedDrawResultItem()
	{
		return false;
	}

	public override void OnDrawSuccess(object[] param)
	{
	}

	public void PlayPendingDrawAnimation()
	{
	}

	private int FindRewardItemIndexByPoolItemId(uint poolItemId)
	{
		return 0;
	}

	private int GetRandomAvailableItemIndex()
	{
		return 0;
	}

	private bool IsItemAlreadyDropped(uint poolItemId)
	{
		return false;
	}

	private void PlayDrawAnimation()
	{
	}

	private void PlayDirectDropAnimationForFinalRound()
	{
	}

	private void PlayDirectDropForReward()
	{
	}

	private void PlayWheelSpinAnimation()
	{
	}

	private void OnDrawAnimationComplete()
	{
	}

	private void ApplyLimitedPoolRewardDropUpBuff(CommonRewardItemInfo rewardInfo)
	{
	}

	public void ShowPurchaseSuccessReward()
	{
	}

	private void ShowPurchaseSuccessRewardSimple()
	{
	}

	private void ShowPurchaseSuccessRewardWithBundleOpen()
	{
	}

	private void OnPurchaseRewardWindowClosed()
	{
	}

	private void PlayUnselectedItemsRebackAnimation()
	{
	}

	private void InitRebackAnimSequencer()
	{
	}

	private float GetRebackAnimStepDuration(int step)
	{
		return 0f;
	}

	private void ExecuteRebackAnimStep(int step)
	{
	}

	private void OnRebackAnimationComplete()
	{
	}

	private void DoDrawCircle()
	{
	}

	private void OnRewardDrop()
	{
	}

	private void PlayDropAnimationForReward(int poolIndex)
	{
	}

	private void CreateDropItemForReward(int poolIndex, bool reposition)
	{
	}

	private void SkipAndGenerateAllRewards()
	{
	}

	private void CreatePendingDropItemsOnInit(List<uint> pendingPoolItemIds)
	{
	}

	private void RefreshPoolChooseTipsLabel(bool isInit = false)
	{
	}

	private void RefreshTopTipsLabel()
	{
	}

	private void ApplyTopPriceTipsLabel(DrawShopLimitedPoolPrice price, string locKey)
	{
	}

	private void RefreshStartAndEndLabel(bool isInit = false)
	{
	}

	private void SetAllRewardItemsViewStage(EDrawShopItemViewStage stage)
	{
	}

	private void SetRewardItemViewStage(int index, EDrawShopItemViewStage stage)
	{
	}

	private void ShowDrawResultDirectly()
	{
	}

	private void UpdatePoolItemsStateForDroppedRewards()
	{
	}

	public override void OnDrawFailed(object[] param)
	{
	}

	private void OnStartBtnClick()
	{
	}

	private void OnTitleBtnClick()
	{
	}

	public override void ShowViewOnOverAnimation()
	{
	}

	private void ShowDefaultDisplayModel()
	{
	}

	private void OnClickSelectRewardItem(int index)
	{
	}

	private void DetectAndSelectDrawResultItemByClickPos()
	{
	}

	private void OnClickDrawResultDropItem(int index)
	{
	}

	private void OnAvatarPlayChangeClothAnim()
	{
	}

	private void OnAvatarFinishChangeClothAnim()
	{
	}

	private void OnWeaponSkinPlayAnim()
	{
	}

	private void OnWeaponSkinFinishAnim(object[] data)
	{
	}

	private void OnShowPreviewUIBtnClick()
	{
	}

	private void SaveSelectedDropItemIndexToModel(int index)
	{
	}

	private void ClearSelectedDropItemIndexInModel()
	{
	}

	private void RestoreSelectedDropItem()
	{
	}

	private void UpdateCachedRewardItemsRemoveState()
	{
	}

	public override void OnTokenUpdated()
	{
	}

	private void SwitchState(DrawShopLimitedState newState)
	{
	}

	private bool IsInAnimationState()
	{
		return false;
	}

	public override void OnContentClose()
	{
	}

	public override void OnSkipDrawAnimation()
	{
	}

	private void _003COnRefreshContentUI_003Eb__56_0()
	{
	}

	private void _003COnRefreshContentUI_003Eb__56_1()
	{
	}

	private void _003C_003En__0(EGachaPrimeLimitedTipsStyle style, long primeStartTime, long startTimeStamp, Action onCountDownFinished)
	{
	}

	private void _003CSetCDN_003Eb__77_0()
	{
	}

	private void _003CSetCDN_003Eb__77_1()
	{
	}

	private void _003CSetCDN_003Eb__77_2()
	{
	}

	private void _003CSetCDN_003Eb__77_3()
	{
	}

	private void _003CSetCDN_003Eb__77_4()
	{
	}

	private void _003COnDrawAnimationComplete_003Eb__93_0()
	{
	}

	private void _003CShowDrawResultDirectly_003Eb__116_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
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

	public GameObject _003C_003EiFixBaseProxy_GetTimeContainsObject()
	{
		return null;
	}

	public GameObject _003C_003EiFixBaseProxy_GetBuyButtonObject()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnContentShow()
	{
	}

	public void _003C_003EiFixBaseProxy_ApplyNonPrimeState()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowPrimeLimitedTips(EGachaPrimeLimitedTipsStyle P0, long P1, long P2, Action P3)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowPrimeAccess()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshBuyButtonState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDrawSuccess(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDrawFailed(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowViewOnOverAnimation()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTokenUpdated()
	{
	}

	public void _003C_003EiFixBaseProxy_OnContentClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipDrawAnimation()
	{
	}
}
