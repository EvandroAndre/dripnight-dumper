using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopUnlimitedTokenTowerContentController : UIDrawShopContentBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__45_0;

		public static Comparison<UIModelDrawShop.DrawShopTokenProgressShowData> _003C_003E9__82_0;

		internal void _003CInitCGReplayNodes_003Eb__45_0()
		{
		}

		internal int _003CGetTokenProgressShowDataList_003Eb__82_0(UIModelDrawShop.DrawShopTokenProgressShowData a, UIModelDrawShop.DrawShopTokenProgressShowData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public UILabel label;

		public uint guaranteedDrop;

		internal void _003CSetGuaranteedDropText_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003CPlayProgressAnimation_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int startTokenCount;

		public int endTokenCount;

		public UIDrawShopUnlimitedTokenTowerContentController _003C_003E4__this;

		private List<UIModelDrawShop.DrawShopTokenProgressShowData> _003CprogressDataList_003E5__2;

		private int _003CendTier_003E5__3;

		private float _003CstartProgressValue_003E5__4;

		private float _003CendProgressValue_003E5__5;

		private float _003Celapsed_003E5__6;

		private float _003Cduration_003E5__7;

		private int _003ClastCompletedTier_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressAnimation_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CTokenFlyInCoroutine_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopUnlimitedTokenTowerContentController _003C_003E4__this;

		private float _003CtimeCounter_003E5__2;

		private Vector3 _003CstartPos_003E5__3;

		private Vector3 _003CendPos_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTokenFlyInCoroutine_003Ed__131(int _003C_003E1__state)
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

	private const int MIN_REWARD_COUNT = 3;

	private const int MAX_REWARD_COUNT = 5;

	private const int PROGRESS_WIDTH_3_ITEMS = 513;

	private const int PROGRESS_WIDTH_4_ITEMS = 513;

	private const int PROGRESS_WIDTH_5_ITEMS = 525;

	private static readonly int[] SPOT_X_POS_3_ITEMS;

	private static readonly int[] SPOT_X_POS_4_ITEMS;

	private static readonly int[] SPOT_X_POS_5_ITEMS;

	private const float PROGRESS_ANIM_DURATION = 1f;

	private const float ITEM_SHAKE_INTERVAL = 2f;

	private const float FLYDURATION = 0.3f;

	private const float TOKEN_BURST_DURATION = 0.3f;

	private uint m_CachedCardPoolIndexForAnimation;

	private UIModelDrawShop.EDrawShopDrawType m_CachedCardPoolTypeForAnimation;

	protected UIDrawShopUnlimitedTokenTowerContentViewSetting m_contentViewSetting;

	private uint m_ChestId;

	private uint m_CurrentTokenProgress;

	private bool m_UseCDNProgressBar;

	private Coroutine m_ProgressCoroutine;

	private uint m_CurrentSelectedPoolAwardIndex;

	private bool m_IsAnimationPlaying;

	private UIModelDrawShop.EDrawShopTokenTowerType m_changeSkinType;

	private const string DRAW_SHOP_TOWER_TOKEN_FLY_IN_END = "DrawShopTowerTokenFlyInFinish";

	private List<UIDrawShopUnlimitedTokenTowerProgressItemController> m_ProgressItemList;

	private List<Transform> m_SpotPosTranList;

	private List<Transform> m_SpotSpriteTranList;

	private List<Transform> m_SpotSpriteBGTranList;

	private List<Transform> m_SpotContainerList;

	private List<UINetworkTexture> m_CDNSegmentList;

	private UIDrawShopUnlimitedTokenTowerCardPoolController m_CardPoolController;

	protected UIDrawShopUnlimitedBuyBtnController m_BuyController;

	private UIDrawShopUnlimitedELS_TT53PrivilegeController m_ELS_TT53PrivilegeController;

	private UIModelDrawShop.DrawShopTowerContentData m_ContentData;

	private Coroutine m_ShakeCoroutine;

	private bool m_HasClaimableReward;

	private GameObject m_ProgressVFX;

	private Coroutine m_TokenVfxCoroutine;

	private uint m_TokenCountBeforeDraw;

	private int m_PendingTokenFlyCount;

	private bool m_ShouldPlayProgressAnimation;

	private bool m_ShouldPlayCardPoolAnimAfterTokenFly;

	private uint m_DisplayedTokenProgress;

	private UICommonGuideController m_NoItemSelectedGuideCtrl;

	private GameObject m_TitleVFXInstance;

	private ResourceID m_TitleVFXResId;

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

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitCDNAndLocalizationKey()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshTitleVFX()
	{
	}

	private void DestroyTitleVFX()
	{
	}

	private void RefreshBG()
	{
	}

	private void RefreshChangeSkinCDN()
	{
	}

	private void InitModel()
	{
	}

	private void RegisterEvents()
	{
	}

	private void InitTransformLists()
	{
	}

	private void TryInitProgressItems()
	{
	}

	private void ClearProgressItems()
	{
	}

	public void SetViewData(uint chestId)
	{
	}

	public void RefreshUI()
	{
	}

	private void LoadContentData()
	{
	}

	private void RefreshELS_TT53PrivilegeBtn()
	{
	}

	private void RefreshCardPool()
	{
	}

	private void UpdateCardPoolState()
	{
	}

	private void ClearCardPoolSelectedState()
	{
	}

	private void RefreshCardPoolAnimationDisplay(bool isSingle, uint index)
	{
	}

	private void RefreshCardPoolImmediateWithFlash(bool isSingle, uint index)
	{
	}

	public override void OnAnimationComplete()
	{
	}

	private void StopCardPoolAnimationDisplay()
	{
	}

	private void RefreshDrawResultImmediateWithFlash(UIModelDrawShop.EDrawShopDrawType drawType, uint index)
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

	public override GameObject GetTimeContainsObject()
	{
		return null;
	}

	public override GameObject GetGuaranteedDropObject()
	{
		return null;
	}

	public override GameObject GetBuyButtonObject()
	{
		return null;
	}

	public void OnShowContent()
	{
	}

	public void OnHideContent()
	{
	}

	private void RefreshTokenProgressBar()
	{
	}

	private List<UIModelDrawShop.DrawShopTokenProgressShowData> GetTokenProgressShowDataList()
	{
		return null;
	}

	private bool SetCDNProgressBarMain()
	{
		return false;
	}

	private void SetCDNProgressBarLayout(int rewardCount)
	{
	}

	private void SetCDNProgressBarLayoutSimple(int rewardCount)
	{
	}

	private void SetDefaultProgressBarLayout(int rewardCount)
	{
	}

	private int GetProgressBarWidth(int rewardCount)
	{
		return 0;
	}

	private int[] GetSpotXPositions(int rewardCount)
	{
		return null;
	}

	private void SetDefaultProgressBarLayoutSimple(int rewardCount)
	{
	}

	private void SetupProgressItems()
	{
	}

	private void RefreshProgressBarValue()
	{
	}

	private void SetProgressBarValue(uint tokenProgress)
	{
	}

	private IEnumerator PlayProgressAnimation(int startTokenCount, int endTokenCount)
	{
		return null;
	}

	private int GetTierForTokenCount(uint tokenCount, List<UIModelDrawShop.DrawShopTokenProgressShowData> progressDataList)
	{
		return 0;
	}

	private float GetProgressValueForTier(int tier, int totalTiers)
	{
		return 0f;
	}

	protected override void InitBuyButtons()
	{
	}

	public void TryInitELS_TT53PrivilegeBtn()
	{
	}

	private void RefreshBuyBtnState()
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

	protected override UIDrawShopUnlimitedCardPoolController GetCardPoolController()
	{
		return null;
	}

	public override void ResetToDefaultPreview()
	{
	}

	public override void OnContentShow()
	{
	}

	public override void OnContentClose()
	{
	}

	private void CheckClaimableRewards()
	{
	}

	private void StartShakeAnimationIfNeeded()
	{
	}

	private void StopShakeAnimation()
	{
	}

	private void OnClickBuyTokenBtn()
	{
	}

	private void OnClickTokenIconBtn()
	{
	}

	private void OnProgressItemClick(int index, DrawShopTowerRewardDesc rewardDesc)
	{
	}

	private void ShowItemPreview(uint itemId)
	{
	}

	private void OnCardPoolItemSelected(object[] param)
	{
	}

	public void ShowPreview(uint itemID = 0u)
	{
	}

	public void ShowPreview(BaseItemInfo itemInfo)
	{
	}

	private void OnTitleBtnClick()
	{
	}

	private void OnAnimEvtOccur(object[] param)
	{
	}

	private void StartTokenFly()
	{
	}

	private void OnProgressBarClick()
	{
	}

	private void RefreshTokenInfo()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private uint GetTokenInCardPool()
	{
		return 0u;
	}

	private ResourceID GetTokenIconRes()
	{
		return default(ResourceID);
	}

	private void SetGuaranteedDropText(UILabel label, uint guaranteedDrop, ResourceID resID)
	{
	}

	private void RefreshBigAwardProgress()
	{
	}

	private void RefreshVFXState()
	{
	}

	private void StopAllAnimations()
	{
	}

	private void PlayTokenFlyStartVFX()
	{
	}

	private void PlayNextTokenFly()
	{
	}

	private IEnumerator TokenFlyInCoroutine()
	{
		return null;
	}

	private void PlayProgressFillSound()
	{
	}

	private void PlayTokenFlaySound()
	{
	}

	private void PlayProgressCompleteSound()
	{
	}

	private void PlayClaimableSound()
	{
	}

	private void PlayClaimSound()
	{
	}

	private void PlayRareRewardSound()
	{
	}

	public override void OnDrawSuccess(object[] param)
	{
	}

	public override void OnDrawFailed(object[] param)
	{
	}

	public override void OnItemOwnershipStateChanged()
	{
	}

	public override void OnSkipDrawAnimation()
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnRewardWindowClosed(object[] param)
	{
	}

	public uint GetDefaultPreviewItemID()
	{
		return 0u;
	}

	private void OnNoItemSelected(object[] param)
	{
	}

	private void ShowNoItemSelectedGuide()
	{
	}

	private void CloseNoItemSelectedGuide()
	{
	}

	public override void OnAnimEvent(object[] param)
	{
	}

	protected override void TryShowContentGuide()
	{
	}

	private void ShowTowerGuideStep1()
	{
	}

	private void ShowTowerGuideStep2()
	{
	}

	private void ShowTowerGuideStep3()
	{
	}

	private void ShowTowerGuideStep4()
	{
	}

	protected override uint[] GetCarouselModelIds()
	{
		return null;
	}

	protected override float GetCarouselInterval()
	{
		return 0f;
	}

	protected override void ShowCarouselPreview(uint itemId)
	{
	}

	private void _003CRefreshTitle_003Eb__50_0()
	{
	}

	private void _003CRefreshChangeSkinCDN_003Eb__56_0()
	{
	}

	private void _003CRefreshChangeSkinCDN_003Eb__56_1()
	{
	}

	private void _003CRefreshChangeSkinCDN_003Eb__56_2()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__121_0()
	{
	}

	private void _003CShowNoItemSelectedGuide_003Eb__147_0()
	{
	}

	private void _003CShowTowerGuideStep1_003Eb__151_0()
	{
	}

	private void _003CShowTowerGuideStep2_003Eb__152_0()
	{
	}

	private void _003CShowTowerGuideStep3_003Eb__153_0()
	{
	}

	private void _003CShowTowerGuideStep4_003Eb__154_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnimationComplete()
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

	public GameObject _003C_003EiFixBaseProxy_GetGuaranteedDropObject()
	{
		return null;
	}

	public GameObject _003C_003EiFixBaseProxy_GetBuyButtonObject()
	{
		return null;
	}

	public UIDrawShopUnlimitedCardPoolController _003C_003EiFixBaseProxy_GetCardPoolController()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ResetToDefaultPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnContentShow()
	{
	}

	public void _003C_003EiFixBaseProxy_OnContentClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDrawSuccess(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDrawFailed(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemOwnershipStateChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipDrawAnimation()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnRewardWindowClosed(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnimEvent(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_TryShowContentGuide()
	{
	}

	public uint[] _003C_003EiFixBaseProxy_GetCarouselModelIds()
	{
		return null;
	}

	public float _003C_003EiFixBaseProxy_GetCarouselInterval()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_ShowCarouselPreview(uint P0)
	{
	}
}
