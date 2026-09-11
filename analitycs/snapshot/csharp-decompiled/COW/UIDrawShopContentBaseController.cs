using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public abstract class UIDrawShopContentBaseController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIDrawShopContentBaseController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CInitShowOptionalDownloadInfo_003Eb__0()
		{
		}
	}

	protected UIDrawShopController m_ParentController;

	protected UINavigationTopbarViewData m_TopbarViewData;

	protected UIModelDrawShop m_ModelDrawShop;

	protected UIModelInventory m_ModelInventory;

	protected UIModelGacha m_ModelGacha;

	protected UIDrawShopPreviewManager m_PreviewManager;

	protected FrontEndPreviewComponent_Gacha m_FrontEndPreviewComponent;

	protected uint m_CurrentChestId;

	protected UIModelDrawShop.DrawShopInfoData m_CurrentChestInfo;

	protected DrawShopBuyButtonComponent m_BuyButtonComponent;

	protected DrawShopDownloadComponent m_DownloadComponent;

	protected UIDrawShopContentViewSetting m_ViewSetting;

	protected GameObject m_AniReplayBtnNode;

	protected UIButton m_CGPlayButton;

	protected Transform m_AnimDownloadCtrlPos;

	protected bool m_IsPlayingDrawAnimation;

	protected bool m_SkipBundleOpenVFX;

	protected const float ENTRANCE_ANIM_START_DELAY = 0.5f;

	protected uint m_EntranceAnimStartDelayCall;

	protected bool m_IsWaitingEntranceAnim;

	protected UIPrimeGachaPrimeTipsController m_PrimeTipsController;

	protected UIPrimeGachaCountDownController m_PrimeCountDownController;

	protected UIPrimeGachaNoPrimeTipsController m_NoPrimeTipsController;

	private const float DEFAULT_CAROUSEL_TIME = 5f;

	private uint m_CarouselDelayCallId;

	private int m_CarouselIndex;

	private bool m_CarouselPaused;

	private bool m_CarouselStoppedBySelection;

	private bool m_IsCarouselPreviewCall;

	private bool m_NeedStartCarousel;

	protected bool m_HasEntranceAnimPlayed;

	protected bool m_IsShowingContentGuide;

	protected bool m_HasReceivedPrefabAnimFinish;

	protected bool m_IsEntranceAnimDone;

	private bool m_IsContentVisible;

	protected UINewDownloadInfoController m_AnimDownloadCtrl;

	protected bool IsCarouselPreviewCall => false;

	protected abstract void InitBuyButtons();

	protected abstract void OnRefreshContentUI();

	protected abstract UIWidget GetContentPreviewBorder();

	protected abstract FrontendPreviewType GetContentPreviewType();

	protected virtual UIDrawShopUnlimitedCardPoolController GetCardPoolController()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void InitComponents()
	{
	}

	private void DisposeComponents()
	{
	}

	private void RegisterModels()
	{
	}

	private void RegisterEvents()
	{
	}

	public void SetParentController(UIDrawShopController parent)
	{
	}

	public void SetTopbarViewData(UINavigationTopbarViewData topbarViewData)
	{
	}

	public virtual void ShowViewOnOverAnimation()
	{
	}

	public virtual void RefreshTopbarDisplay()
	{
	}

	private void OnMainCurrencyClick()
	{
	}

	protected virtual bool HasExchangeItems()
	{
		return false;
	}

	public void RefreshContent(uint DrawShopId)
	{
	}

	public virtual void OnContentClose()
	{
	}

	public virtual void OnContentShow()
	{
	}

	public virtual void ClearCache()
	{
	}

	public virtual void NavigateToItem(uint itemId)
	{
	}

	public virtual void OnAnimEvent(object[] param)
	{
	}

	public virtual void OnSkipDrawAnimation()
	{
	}

	protected virtual void ForceSkipDrawAnimation()
	{
	}

	public virtual void OnSkipFullScreenAnimation()
	{
	}

	public virtual void OnAnimationComplete()
	{
	}

	protected virtual bool IsFirstTimeEnterPool()
	{
		return false;
	}

	protected virtual void MarkPoolAsVisited()
	{
	}

	protected void TryStartEntranceAnimation()
	{
	}

	protected virtual void StartEntranceAnimationSequence(UIDrawShopUnlimitedCardPoolController cardPoolController)
	{
	}

	protected virtual void SkipEntranceAnimation()
	{
	}

	protected void CancelEntranceAnimStartDelayCall()
	{
	}

	public virtual void OnEntranceAnimationEnd()
	{
	}

	public virtual void ResetToDefaultPreview()
	{
	}

	protected virtual uint[] GetCarouselModelIds()
	{
		return null;
	}

	protected virtual float GetCarouselInterval()
	{
		return 0f;
	}

	protected virtual void ShowCarouselPreview(uint itemId)
	{
	}

	protected void StartCarousel()
	{
	}

	protected void StopCarouselBySelection()
	{
	}

	protected void PauseCarousel()
	{
	}

	protected void ResumeCarousel()
	{
	}

	private void ScheduleNextCarousel()
	{
	}

	private void OnCarouselTick()
	{
	}

	private void CancelCarousel()
	{
	}

	private void CancelCarouselDelayCall()
	{
	}

	protected void OnPrefabAnimFinished()
	{
	}

	protected void OnEntranceAnimDone()
	{
	}

	private void CheckAndShowContentGuide()
	{
	}

	protected virtual void TryShowContentGuide()
	{
	}

	public virtual void OnDrawSuccess(object[] param)
	{
	}

	public virtual void OnDrawFailed(object[] param)
	{
	}

	public virtual void OnTokenUpdated()
	{
	}

	public virtual void OnTokenRewardClaimed(object[] param)
	{
	}

	public virtual void OnExchangeSuccess(object[] param)
	{
	}

	public virtual void OnDiscountUpdated()
	{
	}

	public virtual void OnItemOwnershipStateChanged()
	{
	}

	public virtual void RefreshBuyButtonState()
	{
	}

	public virtual void OnPurchaseSuccess(bool isRepurchase)
	{
	}

	public virtual void OnPurchaseFailed()
	{
	}

	protected virtual void OnSingleBuy()
	{
	}

	protected virtual void OnMultiBuy()
	{
	}

	public UIWidget GetPreviewBorder()
	{
		return null;
	}

	public virtual FrontendPreviewType GetPreviewType()
	{
		return FrontendPreviewType.Lobby;
	}

	public virtual void OnPreviewTypeChanged()
	{
	}

	protected void RefreshDownloadButton()
	{
	}

	protected virtual List<ResourceID> GetAnimationResources()
	{
		return null;
	}

	public void ShowDownloadButton()
	{
	}

	public void HideDownloadButton()
	{
	}

	public virtual void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	public void HideAnimDownloadCtrl()
	{
	}

	public void HideAnimPlayBtn()
	{
	}

	public void ShowAnimDownloadCtrl()
	{
	}

	public void RefreshAniReplayBtnVisibility(FullscreenCgDesc animData)
	{
	}

	public void RefreshAnimPlayBtnView(FullscreenCgDesc animData)
	{
	}

	protected void NotifyAnimationStart(bool isFullScreen)
	{
	}

	public void NotifyAnimationEnd()
	{
	}

	protected void SetSkipMaskVisible(bool drawMask, bool fullScreenMask)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected void OpenRewardWindow(EDrawShopRewardStyle style, DrawShopRewardContext context)
	{
	}

	private IDrawShopRewardWindowStrategy GetRewardWindowStrategy(EDrawShopRewardStyle style)
	{
		return null;
	}

	protected virtual void OnRewardWindowClosed(object[] param)
	{
	}

	protected virtual void ShowPrimeAccess()
	{
	}

	protected virtual void HidePrimeAccess()
	{
	}

	protected virtual void ShowPrimeCountDownController(EGachaPrimeCountDownStyle style, long primeStartTime, long startTimeStamp, Action onCountDownFinished = null)
	{
	}

	protected virtual void ShowPrimeLimitedTips(EGachaPrimeLimitedTipsStyle style, long primeStartTime, long startTimeStamp, Action onCountDownFinished = null)
	{
	}

	public virtual Transform GetPrimeCountDownPos()
	{
		return null;
	}

	public virtual Transform GetNoPrimeTipsTrans()
	{
		return null;
	}

	protected bool IsInPrimeExclusivePeriod()
	{
		return false;
	}

	protected bool HasPrimePrivilege()
	{
		return false;
	}

	public virtual GameObject GetTimeContainsObject()
	{
		return null;
	}

	public virtual GameObject GetGuaranteedDropObject()
	{
		return null;
	}

	public virtual GameObject GetBuyButtonObject()
	{
		return null;
	}

	public void CheckCanShowPrimeAccess()
	{
	}

	protected void RefreshPrimeShowState()
	{
	}

	private void OnPrimeCountDownFinished()
	{
	}

	private void ApplyPrimeWithPrivilegeState()
	{
	}

	private void ApplyPrimeWithoutPrivilegeState()
	{
	}

	protected virtual void ApplyNonPrimeState()
	{
	}

	protected void AdjustWidgetToFullScreen(UIWidget widget)
	{
	}

	protected UIDrawShopController GetParentController()
	{
		return null;
	}

	protected uint GetCurrentChestId()
	{
		return 0u;
	}

	protected UIModelDrawShop.DrawShopInfoData GetCurrentChestInfo()
	{
		return null;
	}

	protected uint GetActualPrice(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return 0u;
	}

	protected uint GetOriginalPrice(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return 0u;
	}

	protected uint GetDrawCount()
	{
		return 0u;
	}

	private void _003CStartEntranceAnimationSequence_003Eb__60_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
