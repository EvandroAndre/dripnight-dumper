using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public abstract class UIGachaContentBase : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__46_0;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__46_9;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__46_16;

		internal CommonRewardItemInfo _003COpenCommonRewardWnd_003Eb__46_0(ExchangedAward item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003COpenCommonRewardWnd_003Eb__46_9(ExchangedAward item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003COpenCommonRewardWnd_003Eb__46_16(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIGachaContentBase _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CInitShowOptionalDownloadInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public UIGachaIIVTWRewardWndController ctrl;

		public bool isLuckySpin;

		internal void _003COpenCommonRewardWnd_003Eb__7()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_1
	{
		public CommonRewardItemInfo reward;

		internal bool _003COpenCommonRewardWnd_003Eb__2(ItemTagInfo x)
		{
			return false;
		}

		internal bool _003COpenCommonRewardWnd_003Eb__3(ExchangedAward x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_10
	{
		public ExchangedAward item;

		internal bool _003COpenCommonRewardWnd_003Eb__20(ItemTagInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_2
	{
		public ExchangedAward item;

		internal bool _003COpenCommonRewardWnd_003Eb__4(ItemTagInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_3
	{
		public GachaDoubleWheelInfo dwInfo;

		internal bool _003COpenCommonRewardWnd_003Eb__5(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_4
	{
		public GachaShowItem item;

		internal bool _003COpenCommonRewardWnd_003Eb__6(CommonRewardItemInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_5
	{
		public GachaResultInfo info;

		public UIGachaELS_TT53RewardWndController ctrl;

		public bool isLuckySpin;

		internal CommonRewardItemInfo _003COpenCommonRewardWnd_003Eb__8(ExchangedAward item)
		{
			return null;
		}

		internal void _003COpenCommonRewardWnd_003Eb__14()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_6
	{
		public CommonRewardItemInfo reward;

		internal bool _003COpenCommonRewardWnd_003Eb__11(ItemTagInfo x)
		{
			return false;
		}

		internal bool _003COpenCommonRewardWnd_003Eb__12(ExchangedAward x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_7
	{
		public ExchangedAward item;

		internal bool _003COpenCommonRewardWnd_003Eb__13(ItemTagInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_8
	{
		public GachaResultInfo info;

		public UICommonRewardWndController ctrl;

		public bool isLuckySpin;

		internal CommonRewardItemInfo _003COpenCommonRewardWnd_003Eb__15(ExchangedAward item)
		{
			return null;
		}

		internal void _003COpenCommonRewardWnd_003Eb__21()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_9
	{
		public CommonRewardItemInfo reward;

		internal bool _003COpenCommonRewardWnd_003Eb__18(ItemTagInfo x)
		{
			return false;
		}

		internal bool _003COpenCommonRewardWnd_003Eb__19(ExchangedAward x)
		{
			return false;
		}
	}

	protected UIModelGacha m_ModelGacha;

	protected UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	protected UIGachaContentViewSetting m_ContentViewSetting;

	protected UINavigationTopbarViewData m_TopbarViewData;

	protected UIGachaBuyBtnController m_GachaBuyBtnCtrl;

	protected FrontEndPreviewComponent_Gacha m_FrontEndPreviewComponent;

	protected UINewDownloadInfoController m_AnimDownloadCtrl;

	protected Dictionary<uint, uint> GachaLuckyNeedSpinCountDic;

	protected uint m_GachaID;

	protected UIGachaSceneShowType m_CurrentShowType;

	private GameObject m_TitleVFX;

	protected bool m_SkipBundleOpenVFX;

	private bool _003CIsShowingGuide_003Ek__BackingField;

	protected UIPrimeGachaPrimeTipsController m_PrimeTipsController;

	protected UIPrimeGachaCountDownController m_GachaCountDownController;

	private const string Gacha_PRIME_TIPS_DAILY_SHOW_KEY = "GachaPrimeTipsDailyShowStamp";

	protected UIPrimeGachaNoPrimeTipsController m_GachaNoPrimeController;

	protected bool IsShowingGuide
	{
		private get
		{
			return _003CIsShowingGuide_003Ek__BackingField;
		}
		set
		{
			_003CIsShowingGuide_003Ek__BackingField = value;
		}
	}

	protected abstract void InitGachaContentBuyBtn();

	protected abstract void OnRefreshUIView();

	protected override void OnUIInit()
	{
	}

	public void SetTopbarViewData(UINavigationTopbarViewData topbarViewData)
	{
	}

	public void RefreshUIView(uint chestID)
	{
	}

	public void NavigationToGachaReward(uint itemId)
	{
	}

	protected virtual void BeforeNavigationToGachaReward()
	{
	}

	protected virtual void OnNavigationToGachaReward(uint itemId)
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

	public UIGachaContentViewSetting GetGameViewSettig()
	{
		return null;
	}

	public virtual void OnTempHidePreview()
	{
	}

	public virtual void OnRecoverPreview()
	{
	}

	public virtual void OnHideContent()
	{
	}

	public virtual void OnShowContent()
	{
	}

	public virtual void OnShowContent(bool needSkipAnim)
	{
	}

	public virtual void RefreshBuyBtnState()
	{
	}

	private void RefreshTitleVFX()
	{
	}

	public virtual void OnPurchaseResult(bool isSuccess)
	{
	}

	public virtual void OnPurchaseResult(bool isSuccess, bool isRepurchase)
	{
	}

	public virtual void OnSkipAnim()
	{
	}

	public virtual void OnSkipFullScreenAnim()
	{
	}

	public virtual void OnFullScreenAnimOver()
	{
	}

	public virtual void OnSplashCDNOpen()
	{
	}

	public virtual void OnSplashCDNClose()
	{
	}

	public virtual UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public virtual FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	protected void AdjustWidgtDimFullScreen(UIWidget widget)
	{
	}

	protected void OpenCommonRewardWnd(UICommonRewardWndController.WndStyleEnum style, UIModelGacha.GachaDrawType dType, UIGachaBuyBtnController.BuyBtnState state, bool enableAnim, bool useNewItem = false)
	{
	}

	private int CompareRewardList(CommonRewardItemInfo a, CommonRewardItemInfo b)
	{
		return 0;
	}

	private uint GetTotalSpinCount(GachaDesc desc, GachaInfo info)
	{
		return 0u;
	}

	private uint GetSecondGooldAwardID(List<CommonRewardItemInfo> rewardInfoList)
	{
		return 0u;
	}

	private void OnPreviewSceneShowTypeChange(object[] data)
	{
	}

	protected virtual void OnPreviewSceneShowTypeChange()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual void OnCloseRewardPanel()
	{
	}

	public virtual void CloseRewardPool()
	{
	}

	public virtual void OnGachaSceneShowTypeChange(UIGachaSceneShowType type)
	{
	}

	public virtual void OnGachaCouponInsufficientBuyClick(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
	}

	public virtual void SetFrontendPreviewComponent(FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	public bool IsFrontendPreviewComponentNull()
	{
		return false;
	}

	public void ShowPrimeAccess()
	{
	}

	public void HidePrimeAccess()
	{
	}

	public void ShowGachaCountDownController(EGachaPrimeCountDownStyle style, ClientChestType chestInfo, Action onCountDownFinished = null)
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

	public void ShowPrimeGachaLimitedTips(EGachaPrimeLimitedTipsStyle style, ClientChestType chestInfo, Action onCountDownFinished = null)
	{
	}

	private void _003COpenCommonRewardWnd_003Eb__46_1()
	{
	}

	private void _003COpenCommonRewardWnd_003Eb__46_10()
	{
	}

	private void _003COpenCommonRewardWnd_003Eb__46_17()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
