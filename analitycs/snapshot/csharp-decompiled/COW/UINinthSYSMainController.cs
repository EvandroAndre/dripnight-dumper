using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UINinthSYSMainController : UIBigEventMainBaseController
{
	private enum EMainViewStatus
	{
		Null,
		FirstIn,
		ZoomIn,
		Normal,
		ZoomOut,
		Close
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public UINinthSYSMainController _003C_003E4__this;

		public Action callback;

		internal void _003CPlayZoomOutAnim_003Eb__0()
		{
		}
	}

	private UIModelNinthSYS m_ModelNinthSYS;

	private UINinthSYSMainView m_View;

	private bool m_InitData;

	private bool m_Setting;

	private bool m_HasTokenInfo;

	private bool m_EffectAsync;

	private bool m_IsTokenCusumeGuide;

	private EMainViewStatus m_ViewStatus;

	private uint m_FirstInAnimDelayCall;

	private uint m_FirstInCtrlDelayCall;

	private uint m_AnimDelayKey;

	private GameObject m_FirstInVFXGo;

	private bool m_NavigationShowed;

	private const float DEFAULT_GAMEPLAY_ALPHA = 1f;

	private bool m_IsEnteredNinthArea;

	private bool m_IsLocalPlayerHorizontalMoving;

	private float m_CurrentAlpha;

	private float m_AlphaFrom;

	private float m_AlphaTo;

	private float m_DelayTimer;

	private float m_AlphaDuration;

	private float m_DurationTimer;

	private bool m_IsAlphaDelaying;

	private bool m_IsAlphaAnimating;

	private AnimatedAlpha[] m_AnimatedAlphas;

	private CSConsumeNinthSysTokenRes m_CurrentConsumeTokenRes;

	private NinthSysAwardDesc.ELevel m_CurrentConsumeTokenLevel;

	private UIModelNinthSYS.Sequence m_TokenAnimSequence;

	private bool m_IsSuperReward;

	private int m_TokenAnimSoundEffectTicket;

	public bool isVaild => false;

	public bool IsTokenAnimPlaying => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override UIBigEventPeakDayWndBaseController GetPeakDayWndCtrl()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void Update()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override bool AutoOpenPeakDayWndEnabled()
	{
		return false;
	}

	protected override void AutoOpenPeakDayWnd(float time, bool autoOpenEnabled = true, bool needDelayShowPeakDay = true)
	{
	}

	private AwardDesc GetAwardDesc(ClientActivityDesc desc, int index)
	{
		return null;
	}

	protected override void OpenPeakDayWnd()
	{
	}

	private void ShowDefaultView(bool isDefault)
	{
	}

	private void RefershConsumeTokenBtn()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	public override void OnCloseAllPopupWindows()
	{
	}

	private void RefershSimpleTokenBtnGiftPoint()
	{
	}

	private void RefershTokenAllInBtn()
	{
	}

	private void InitView()
	{
	}

	private void TryShowMainPage()
	{
	}

	private void OnClickTokenConsumeBtn()
	{
	}

	private void OnClickTokenAllInBtn()
	{
	}

	private void OnClickSkipBtn()
	{
	}

	private int IsNeedMainFirstInAnim()
	{
		return 0;
	}

	private void SaveMainFirstInAnim()
	{
	}

	private bool PlayFristInAnim()
	{
		return false;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private float PlayZoomInAnim(string strAnim)
	{
		return 0f;
	}

	private bool PlayZoomOutAnim(Action callback)
	{
		return false;
	}

	private void OnViewZoomOutCallback()
	{
	}

	private void OnViewZoomInCallback()
	{
	}

	private void ClearAnimationStatus()
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnSettingCallback()
	{
	}

	private void OnInfoCallback()
	{
	}

	private void OnProgressStateCallback()
	{
	}

	private void RefershRedDot()
	{
	}

	private void OnTokenChangedCallback()
	{
	}

	private void OnTokenInfoInGameCallback()
	{
	}

	private void OnProgressCallback()
	{
	}

	public bool OpenBigEventEntranceID(UIModelBigEvent.EBigEventEntranceID entranceID, uint subType = 0u)
	{
		return false;
	}

	private UIPopupWindowController OpenEntranceController(Type type)
	{
		return null;
	}

	private void CheckMainViewVisible()
	{
	}

	private void OnMainViewVisibleChange(bool isVisible)
	{
	}

	private void OnAnimEvtOccur(object[] param)
	{
	}

	private void OnSocialAreaTipsFinishCallback()
	{
	}

	private void InitEntranceView()
	{
	}

	private void DestroyEntranceView()
	{
	}

	private void SetEntranceCdnAndBubbleView()
	{
	}

	private void InitCommonEntranceView()
	{
	}

	protected override void OnGoToNavigation(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	protected override void RefreshPeakDayBtnView()
	{
	}

	public override void RefreshView()
	{
	}

	protected override void OnBtnPeakDayClick()
	{
	}

	private void OnClickMissionBtn()
	{
	}

	private void RefershMissionView()
	{
	}

	private void RefershMissionPromptView()
	{
	}

	private void OnClickGameplayBtn()
	{
	}

	private void InitGamePlayView()
	{
	}

	public void SetNinthAreaState(bool isEntered)
	{
	}

	private void OnClickSimpleTokenConsumeBtn()
	{
	}

	private void ResetMovingState()
	{
	}

	private void UpdateAlpha()
	{
	}

	private void PlayAlphaAnimation(bool isMoving)
	{
	}

	private void OnLocalPlayerHorizontalMovingStateChanged(object[] data)
	{
	}

	private float GetDynamicAlphaDuration(float fromAlpha, float toAlpha)
	{
		return 0f;
	}

	private void ApplyAlpha(float alpha)
	{
	}

	private bool CanStartTokenAnimation()
	{
		return false;
	}

	private void UpdateSequence()
	{
	}

	private void StartTokenAnimation()
	{
	}

	private void BuildTokenAnimSequence()
	{
	}

	private void OnTaskUIOutStarted()
	{
	}

	private void OnTaskUIOutCompleted()
	{
	}

	private void OnTaskStatueStarted()
	{
	}

	private void OnTaskStatueCompleted()
	{
	}

	private void OnTaskPrivilegeStarted()
	{
	}

	private void OnPrivilegeWndClosed()
	{
	}

	private void OnTaskPrivilegeCompleted()
	{
	}

	private void OnTaskRewardStarted()
	{
	}

	private void OnRewardWndClosed()
	{
	}

	private void OnTaskRewardCompleted()
	{
	}

	private void OnTaskUIEnterStarted()
	{
	}

	private void OnTaskUIEnterCompleted()
	{
	}

	private void OnTaskVFXFlyStarted()
	{
	}

	private void OnTaskVFXFlyCompleted()
	{
	}

	private void OnAllTokenAnimCompleted()
	{
	}

	private void CleanupTokenAnimation(bool clear = true)
	{
	}

	private void InitTopLeftView()
	{
	}

	private void DestroyTopLeftView()
	{
	}

	private void OnClickRuleBtn()
	{
	}

	private void InitTopRightView()
	{
	}

	private void DestroyTopRightView()
	{
	}

	private void InitTokenData()
	{
	}

	private void RefershTokenView()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickTokenBtn()
	{
	}

	private void OnClickApplyBtn()
	{
	}

	private void InitTopRightInfo()
	{
	}

	private void OnNinthStatueToSocialArea()
	{
	}

	private void InithApplyBtnView()
	{
	}

	private void _003CPlayZoomInAnim_003Eb__45_0()
	{
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public UIBigEventPeakDayWndBaseController _003C_003EiFixBaseProxy_GetPeakDayWndCtrl()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_AutoOpenPeakDayWndEnabled()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_AutoOpenPeakDayWnd(float P0, bool P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OpenPeakDayWnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseAllPopupWindows()
	{
	}

	public new bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGoToNavigation(UIModelBigEvent.EBigEventEntranceID P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshPeakDayBtnView()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnPeakDayClick()
	{
	}
}
