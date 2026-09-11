using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaELS_TT53ContentController : UIGachaContentBase, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public UILabel label;

		public UIGachaELS_TT53ContentController _003C_003E4__this;

		internal void _003CSetGuaranteedDropText_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public UIGachaELS_TT53ContentController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CShowPrivilegeDownloadView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass147_0
	{
		public List<ItemTagInfo> launchTagItems;

		public List<CommonRewardItemInfo> rewardinfoList;

		public Action closeAction;

		internal CommonRewardItemInfo _003CShowExchangeResultWnd_003Eb__1(ExchangedAward item)
		{
			return null;
		}

		internal void _003CShowExchangeResultWnd_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public UIGachaELS_TT53ContentController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CInitShowOptionalDownloadInfo_003Eb__0()
		{
		}
	}

	private sealed class _003CCoRefreshDebrisGuide_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaELS_TT53ContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRefreshDebrisGuide_003Ed__121(int _003C_003E1__state)
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

	private sealed class _003CDelayHideDiscountBubbleCoroutine_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaELS_TT53ContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideDiscountBubbleCoroutine_003Ed__109(int _003C_003E1__state)
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

	private sealed class _003CPlayProgressAnim_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaELS_TT53ContentController _003C_003E4__this;

		public int endPoint;

		public int startPoint;

		private float _003CperGrowUpTime_003E5__2;

		private float _003CperTimeChange_003E5__3;

		private int _003Ci_003E5__4;

		private float _003Ccur_time_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressAnim_003Ed__97(int _003C_003E1__state)
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

	private sealed class _003CShowDownloadBubble_003Ed__142 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaELS_TT53ContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDownloadBubble_003Ed__142(int _003C_003E1__state)
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

	private sealed class _003CTokenVFXCoroutine_003Ed__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaELS_TT53ContentController _003C_003E4__this;

		private float _003CtimeCounter_003E5__2;

		private Vector3 _003CstartPos_003E5__3;

		private Vector3 _003CendPos_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTokenVFXCoroutine_003Ed__154(int _003C_003E1__state)
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

	private UIGachaELS_TT53ContentView m_View;

	public const uint OutputBundleId = 710053010u;

	private const string m_PrizePreviewVFXKey = "TokenTowerVFX_{0}_{1}_AccountId_{2}";

	private const string m_DownloadAnimCheckEverydayKey = "ELS_TT53DownloadAnimCheckEveryday_{0}_{1}";

	public const string m_CanSkipDrawAnimKey = "ELS_TT53CanSkipDrawAnim_{0}_{1}";

	private const float m_ShowContentUIOnShowFirstFreeNoticeDelayTime = 0.5f;

	private const uint m_GrowUpTime = 1u;

	private uint m_SpacingDistance;

	private bool m_ShowAvatarTransformUI;

	private uint m_AvatarTransformID;

	private float TimedAudioTimer;

	private bool TimedAudioTimerBlocked;

	private bool TimedAudioTimerStarted;

	private const uint FIRSTCALIBRATIONLENGTH = 45u;

	private const uint THREEGACHAINTERVAL = 145u;

	private const uint FOURGACHAINTERVAL = 140u;

	private const uint FIVEGACHAINTERVAL = 120u;

	private const int PROGRESSHEIGHTWITHTHREEITEM = 335;

	private const int PROGRESSHEIGHTWITHF0URITEM = 465;

	private const int PROGRESSHEIGHTWITHFIVEITEM = 525;

	private const int PRIVILEGEPANELBGWITHOUTITEM = 57;

	private const int PRIVILEGEPANELBGPADDING = 18;

	private const float SHOWDOWNLOADBUBBLETIME = 10f;

	private const float TimedAudioTime = 20f;

	private Vector3 m_AvatarTransformWithCDN;

	private Vector3 m_AvatarTransformWithoutCDN;

	private Vector3 m_PrivilegePanelPosWithoutCDN;

	private Vector3 m_PropertyBtnPosWithCDN;

	private Vector3 m_PropertyBtnPosWithoutCDN;

	private uint m_CurrentTokenNum;

	private uint m_CurrentExchangingGachaID;

	private uint m_LegendClothId;

	private GachaLegendaryInfoData m_GachaInfoData;

	private GachaDesc m_GachaDesc;

	private List<ResourceID> m_AnimResList;

	private UIGachaBuyBtnController m_GachaBuyBtnCtrl_WithSwitch;

	private UIGachaBuyBtnController m_GachaBuyBtnCtrl_NoSwitch;

	private List<LegendClothPrivilege> m_PrivilegeList;

	private List<UIGachaELS_TT53PrivilegeItemController> m_PrivilegeItemList;

	private List<Transform> m_PrivilegeTransList;

	private UINewDownloadInfoController m_PrivilegeDownloadCtrl;

	private bool m_IsShowPrivilegeDownloadView;

	private int m_PrivilegeDownloadIndex;

	private List<Transform> m_ExtraItemTransList;

	private List<Transform> m_ExtraItemPosList;

	private List<ExchangedAward> m_ExtraRewardList;

	private List<ItemTagInfo> m_LaunchTagItemList;

	private List<UIProgressBar> m_ProgressBarList;

	private List<UIGachaELS_TT53ExtraListItemController> m_ExtraRewardItemList;

	private GameObject m_ProgressBarVFX;

	private Coroutine m_ProgressCoroutine;

	private Coroutine m_ShowBubbleCoroutine;

	private GameObject m_TokenVfx;

	private UILaunchTagFrameController m_LaunchTagCtrl;

	private uint m_BundleID;

	private uint m_TransformAfterSingleAnimDelayCall;

	private uint m_EndPreviewPrivilegeDelayCall;

	private uint m_ShowContentUIOnShowFirstFreeNoticeDelayCall;

	private Coroutine m_FirstDrawNoticeDisappearTailCoroutine;

	private GameObject m_FristDrawNoticeDisappearTrail;

	private GameObject m_FristDrawNoticeBtnVFX;

	private bool _003CIsPreviewingPrivilege_003Ek__BackingField;

	private Coroutine m_DelayHideDiscountBubbleCoroutine;

	private bool m_IsRepurchasing;

	private UIGachaELS_TT53ContentCustomizedBackgroundController m_CustomizedBackgroundCtrl;

	private bool m_IsHidingContentUI;

	private bool m_IsPlayingDrawAnim;

	private bool m_CanSkipDrawAnim;

	private bool m_IsPlayingBGM;

	public bool IsPreviewingPrivilege
	{
		get
		{
			return _003CIsPreviewingPrivilege_003Ek__BackingField;
		}
		private set
		{
			_003CIsPreviewingPrivilege_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void PlayBGM()
	{
	}

	private void StopBGM()
	{
	}

	private void InitCustomizedBackground()
	{
	}

	public void HideCustomizedBackgroundVFX()
	{
	}

	public void ShowLoopVFX()
	{
	}

	private void OnShowLoopVFX()
	{
	}

	private void ShowContentUI(bool needPlayAnim = false)
	{
	}

	private void HideContentUI()
	{
	}

	private void PlayShowContentUIAnim()
	{
	}

	private void CheckCanShowPrimeAccess()
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

	private void InitProgressBarList()
	{
	}

	private void SetInitialState()
	{
	}

	public override void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	public override void OnTempHidePreview()
	{
	}

	private bool HasSpecialToken()
	{
		return false;
	}

	private void RefreshProgressValue()
	{
	}

	private IEnumerator PlayProgressAnim(int startPoint, int endPoint)
	{
		return null;
	}

	private void SetProgressBarValue(uint tokenNum)
	{
	}

	private void RefreshProgressBarVFX(float value)
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void RefreshGuaranteedDrop()
	{
	}

	private void SetGuaranteedDropText(UILabel label, ResourceID resID)
	{
	}

	private void SetSymbolLabelAtlasInfo(UILabel label, ResourceID resID)
	{
	}

	private void RefreshProgressBarValueOnShowContent()
	{
	}

	private void RefreshGuaranteedDropHighlight()
	{
	}

	private void RefreshDiscountBubble()
	{
	}

	private void ShowDiscountBubble()
	{
	}

	private void HideDiscountBubble()
	{
	}

	private IEnumerator DelayHideDiscountBubbleCoroutine()
	{
		return null;
	}

	private void OnBuyBtnSwitchBtnClick()
	{
	}

	private void RefreshLegendClothPrivilege()
	{
	}

	private void ResetPrivilegeDownloadView()
	{
	}

	private void ShowPrivilegeDownloadView(int index)
	{
	}

	public void OnPrivilegeItemClick(LegendClothPrivilege privilege, int index)
	{
	}

	private void OnStartPreviewPrivilege(LegendClothPrivilege privilege, int index)
	{
	}

	private void OnAnimEvt(object[] data)
	{
	}

	public void EndPreviewPrivilege(bool needDelay = false)
	{
	}

	private void OnEndPreviewPrivilege(object[] data)
	{
	}

	private void UnSelectAllPrivilegeItem()
	{
	}

	private void SetPrivilegeQualityBG(EInventory.RareType rare)
	{
	}

	private IEnumerator CoRefreshDebrisGuide()
	{
		return null;
	}

	private void RefreshDebrisGuide()
	{
	}

	private void OnGuideClose()
	{
	}

	private void SetCDNTitle()
	{
	}

	private void SetCDNBg()
	{
	}

	private void OnLegendGachaAdsClick(object[] data)
	{
	}

	private void OnClickRewardPoolBtn()
	{
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	public override void OnGachaSceneShowTypeChange(UIGachaSceneShowType type)
	{
	}

	private void OnPurchaseConfirmWndOpen()
	{
	}

	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	public override void OnSkipAnim()
	{
	}

	protected override void BeforeNavigationToGachaReward()
	{
	}

	protected override void OnNavigationToGachaReward(uint itemId)
	{
	}

	protected override void OnRefreshUIView()
	{
	}

	public override void OnHideContent()
	{
	}

	public override void OnShowContent()
	{
	}

	private void TryShowDownloadBubble()
	{
	}

	private void StartShowDownloadBubbleCoroutine()
	{
	}

	private void StopShowDownloadBubbleCoroutine()
	{
	}

	private IEnumerator ShowDownloadBubble()
	{
		return null;
	}

	private void HideExtraListItemVfx()
	{
	}

	private void RefreshFirstDrawFreeNotice(bool needAnimation = true)
	{
	}

	private void OnFirstFreeDrawNoticeBtnClick()
	{
	}

	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	private void ShowExchangeResultWnd(object[] data)
	{
	}

	private void OnCloseCommonRewardWindow(object[] param)
	{
	}

	protected override void OnCloseRewardPanel()
	{
	}

	private void OnRewardWndRepurchase()
	{
	}

	private void OnCancelPurchase()
	{
	}

	private void ResetInfoState()
	{
	}

	private void ShowTokenVfx()
	{
	}

	private IEnumerator TokenVFXCoroutine()
	{
		return null;
	}

	private void BeginPlayDrawAnim()
	{
	}

	private void BeginPlayPrizeDrawAnim()
	{
	}

	private void EndPlayDrawAnim()
	{
	}

	private void InitExtraRewardItems()
	{
	}

	private void OnExchangeAnimInterfaceMaskClick()
	{
	}

	private void RefreshExtraRewardList()
	{
	}

	private void OnShowExchangeAnim(object[] data)
	{
	}

	private void RefreshGachaAds()
	{
	}

	private void InitTransList()
	{
	}

	private void InitPrivilgeTransList()
	{
	}

	private uint GetBundleID()
	{
		return 0u;
	}

	private void OnLegendClothGotoBtnClick()
	{
	}

	private void OnDownloadBubbleBtnClick()
	{
	}

	private void OnPropertyBtnClick()
	{
	}

	private void OnPurchasePrepare(object[] param)
	{
	}

	private void SetLaunchTagData()
	{
	}

	private void ShowLaunchTag(bool show)
	{
	}

	private GameObject GetTokenVfx()
	{
		return null;
	}

	private void CancelDelayCall(bool isHiding = false)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnUIInit_003Eb__73_0()
	{
	}

	private void _003CInitCustomizedBackground_003Eb__79_0()
	{
	}

	private void _003CEndPreviewPrivilege_003Eb__117_0()
	{
	}

	private void _003CShowExchangeResultWnd_003Eb__147_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
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

	public void _003C_003EiFixBaseProxy_InitShowOptionalDownloadInfo(List<ResourceID> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTempHidePreview()
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

	public void _003C_003EiFixBaseProxy_OnGachaSceneShowTypeChange(UIGachaSceneShowType P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeNavigationToGachaReward()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationToGachaReward(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
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
