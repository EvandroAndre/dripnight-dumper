using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchis55TableController : UIBaseController
{
	private UIGachaIchis55TableView m_View;

	private UIGachaIchisTableBaseView m_BaseView;

	private UIModelIchis m_ModelIchis;

	private UIModelFriends m_ModelFriends;

	private uint m_JackPot;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private List<IchisTableRowData> m_RowDataList;

	private Action m_OnSwitchPoolClick;

	private bool m_MaskPoolCounts;

	private bool m_UseStaticDefaultAvatars;

	private bool m_DisableCodeDrivenEffects;

	private bool m_TableInteractionEnabled;

	private bool m_SuppressEntryAni;

	private bool m_ShowTcpEmptyPoolSwitchEntry;

	private UIGachaIchis55KellyTipsController m_TcpEmptyPoolKellyTipsCtrl;

	private IchisKellyTipsMode m_CurrentKellyTipsMode;

	private bool m_ShowCDCountDown;

	private bool m_InCDState;

	private List<UIGachaIchis55STierATierCombieItemController> m_CombineItemCtrls;

	private List<UIGachaIchisLeftPrizeNumberItemController> m_NumberItems;

	private int m_LastPrizesLeft;

	private int m_TotalCapacity;

	private bool m_PrizesLeftRolling;

	private int m_PendingPrizesLeft;

	private uint m_PrizesLeftRollEndDelayCallID;

	private const int MAX_CAROUSEL_ITEM = 3;

	private const float CAROUSEL_INTERVAL = 0.65f;

	private const float CAROUSEL_SLIDE_DURATION = 0.65f;

	private const float CAROUSEL_SLOT_SPACING = 50f;

	private const int CAROUSEL_SLOT_DEPTH_STEP = 10;

	private const int CAROUSEL_SLOT_DEPTH_BASE = 1;

	private const string MASKED_COUNT_TEXT = "?";

	private const string MASKED_ACCOUNT_COUNT_TEXT = "???";

	private static readonly Vector3 TCP_EMPTY_POOL_TIPS_LOCAL_POSITION;

	private List<UIGachaIchisCarouselHeadPicItemController> m_CarouselItems;

	private List<TweenPosition> m_CarouselTweens;

	private List<TweenAlpha> m_CarouselAlphaTweens;

	private List<ulong> m_CarouselAccountIds;

	private int m_CarouselCursor;

	private uint m_CarouselTickDelayCallID;

	private uint m_CarouselSlideEndDelayCallID;

	private static readonly Vector2 ICHIS55_COMBINE_ROW_SIZE;

	private static readonly Vector2 ICHIS55_QUALITY_BLOCK_ROW_SIZE;

	private static readonly UITable2.Margin DEFAULT_ROW_MARGIN;

	private const string SCALE_UP_CLIP_NAME_KEY = "MainScale1";

	private const string SCALE_DOWN_CLIP_NAME_KEY = "MainScale2";

	private const string FLY_CLIP_NAME_KEY = "Main1";

	private bool m_SwitchDepthBaseCached;

	private int m_SwitchRootBaseDepth;

	private int m_SwitchMidBaseDepth;

	private int m_SwitchPrizeBaseDepth;

	private int m_SwitchArrowBaseDepth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnChangePoolBtnClick()
	{
	}

	private void OnSwitchPoolConfirmed()
	{
	}

	private void OnPrizeLeftBtnClick()
	{
	}

	private void OnCarouselBtnClick()
	{
	}

	private void OpenIchisOverviewPopup()
	{
	}

	private void InitTable2Templates()
	{
	}

	public void SetJackPot(uint jackPot)
	{
	}

	public void SetChestIds(uint chestId, uint chestSubId)
	{
	}

	public void OnPoolSwitchedReset()
	{
	}

	public void SetSwitchPoolClickCallback(Action callback)
	{
	}

	public void SetTcpEmptyPoolSwitchEntry(bool show)
	{
	}

	public bool IsTcpEmptyPoolSwitchEntryActive()
	{
		return false;
	}

	public void SetTableInteractionEnabled(bool enabled)
	{
	}

	public bool PlayTableTweenPosition(Vector3 from, Vector3 to)
	{
		return false;
	}

	public bool PlayTableTweenPosition(Vector3 from, Vector3 to, float duration)
	{
		return false;
	}

	public bool PlayTableTweenPosition(Vector3 from, Vector3 to, float duration, UITweener.Method method)
	{
		return false;
	}

	public void StopTableTweenPosition()
	{
	}

	private AnimationState GetStartAnimState()
	{
		return null;
	}

	private AnimationState GetEndAnimState()
	{
		return null;
	}

	private AnimationState GetFlyAnimState()
	{
		return null;
	}

	private AnimationState GetMainAnimStateByNameKey(string nameKey)
	{
		return null;
	}

	public void DisableInUIFX()
	{
	}

	public void EnableInUIFX()
	{
	}

	public void DisableDefaultMainAnimAutoPlay()
	{
	}

	public void RestoreDefaultMainAnimAutoPlay()
	{
	}

	public bool PlayStartAnim(float speed)
	{
		return false;
	}

	public bool PlayEndAnim(float speed)
	{
		return false;
	}

	public bool PlayFlyAnim(float speed)
	{
		return false;
	}

	private bool PlaySwitchClip(AnimationState state, float speed)
	{
		return false;
	}

	public void StopAllSwitchAnims()
	{
	}

	private void StopSwitchClip(AnimationState state)
	{
	}

	public float GetFlyClipLength()
	{
		return 0f;
	}

	public float GetStartClipLength()
	{
		return 0f;
	}

	public float GetEndClipLength()
	{
		return 0f;
	}

	public void SampleAppearEndAsBase()
	{
	}

	public void ResetAnimToDefault()
	{
	}

	public void ForceResetScrollViewToTop()
	{
	}

	private void CacheSwitchDepthBaseIfNeeded()
	{
	}

	public void SetSwitchPanelDepthOffset(int offset)
	{
	}

	private void RefreshBlockPanelDepth()
	{
	}

	public void RefreshDisplay()
	{
	}

	public void RefreshDisplay(IchisTransitionPoolDisplayData displayData)
	{
	}

	private void RefreshRows(List<IchisTableRowData> rowLayout)
	{
	}

	public void ResetScrollViewToTop()
	{
	}

	public void SetSuppressEntryAni(bool suppress)
	{
	}

	public void ReplayMainAniOnTabEnter()
	{
	}

	public void ResetMainAniPlayStateOnTabLeave()
	{
	}

	public void UpdateItemByUniqueId(uint uniqueId)
	{
	}

	public bool UpdateItemsByUniqueIds(ICollection<uint> uniqueIds)
	{
		return false;
	}

	public bool RefreshAllItemsInPlace()
	{
		return false;
	}

	private Vector2 GetRowSize(IchisTableRowData rowData)
	{
		return default(Vector2);
	}

	private void SetPrizePoolScrollEnabled(bool enabled)
	{
	}

	private int GetPrizePoolChildPanelDepth()
	{
		return 0;
	}

	private void SetPresentationFlags(bool maskPoolCounts, bool useStaticDefaultAvatars, bool disableCodeDrivenEffects)
	{
	}

	private void SetCodeDrivenEffectsActive(bool active)
	{
	}

	private void SetSwitchPoolLoopActive(bool active)
	{
	}

	private void RefreshTableButtonCollider()
	{
	}

	private void SetButtonColliderEnabled(UIButton button, bool enabled)
	{
	}

	private void ResetPrizePoolScrollViewToCalculatedTop()
	{
	}

	private void RefreshSortableGoodsState(IchisSortableGoodsData data)
	{
	}

	private void RefreshPrizesLeftNumberGrid(int totalRemaining, int totalCapacity)
	{
	}

	private void UpdateQuestionMarkItems(int digitCount)
	{
	}

	private void UpdateDigitItems(int totalRemaining, int digitCount)
	{
	}

	private void UpdateDigitItems(int totalRemaining, int digitCount, bool forceAnimateAll)
	{
	}

	private int[] ExtractDigits(int value, int digitCount)
	{
		return null;
	}

	private void ClearNumberItems()
	{
	}

	private void OnPrizesLeftRollFinished()
	{
	}

	private void ResetPrizesLeftRollState()
	{
	}

	public void PlayPoolCountReveal()
	{
	}

	private void PlayPrizesLeftReveal(int totalRemaining, int totalCapacity)
	{
	}

	private void EnsureNumberGrid(int totalCapacity, int digitCount)
	{
	}

	private void PlayItemsCountRefresh()
	{
	}

	public void RefreshSwitchPoolUI()
	{
	}

	private void OnCDStateLabelBtnClick()
	{
	}

	private void ApplyCDSubState()
	{
	}

	public void HideSwitchPoolUI()
	{
	}

	private void RefreshKellyTips(bool poolEmptyEntry, bool hasQualification)
	{
	}

	private void ApplyKellyTipsView(IchisKellyTipsMode mode)
	{
	}

	private void CloseTcpEmptyPoolKellyTips()
	{
	}

	private void OnSwitchCooldownFinished()
	{
	}

	public void RefreshTierCounts()
	{
	}

	public void RefreshTierCounts(int totalRemaining, int totalCapacity)
	{
	}

	public void RefreshAccountCount(uint count)
	{
	}

	public void RefreshCarousel(ICollection<ulong> accountIds)
	{
	}

	private void RefreshStaticDefaultCarousel()
	{
	}

	private void EnsureCarouselItems()
	{
	}

	private void PrefetchAccountInfos()
	{
	}

	private void OnAccountInfosPrefetched(List<AccountInfoBasic> accountInfos)
	{
	}

	private void ApplyCarouselSlotLayout()
	{
	}

	private void FillCarouselItems()
	{
	}

	private void FillStaticDefaultCarouselItems()
	{
	}

	private void StartCarouselAutoPlay()
	{
	}

	private void StopCarouselAutoPlay()
	{
	}

	private void CancelCarouselTickCall()
	{
	}

	private void CancelCarouselSlideEndCall()
	{
	}

	private void KillCarouselTweens()
	{
	}

	private void OnCarouselTick()
	{
	}

	private void OnCarouselSlideFinished()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__53_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__53_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
