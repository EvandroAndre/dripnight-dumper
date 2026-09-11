using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Video;
using proto;

namespace COW;

internal class UIBM26_SYSMainController : UIBigEventMainBaseController, UIModelBM26_SYS.IBM26_SYSMain
{
	private enum EMainViewStatus
	{
		Null,
		FirstIn,
		ZoomIn,
		Normal,
		ZoomOut,
		StageSwitch,
		Close
	}

	private enum ShareStatus
	{
		Sharing = 1,
		Submit = 2,
		Receive = 4
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public GameObject progressFlyEffect;

		public uint nextProgress;

		internal void _003CPlayProgressSubmitFlyEffect_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass167_0
	{
		public int loadedCount;

		public int totalToLoad;

		public UIBM26_SYSMainController _003C_003E4__this;

		public Action _003C_003E9__0;

		internal void _003CLoadNextStageEffect_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public Action onLoadComplete;

		internal void _003CWaitForStageEffectLoad_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public float delayTime;

		public UIBM26_SYSMainController _003C_003E4__this;

		public Action _003C_003E9__1;

		internal void _003CPlayStageEffect_003Eb__0(GameObject go)
		{
		}

		internal void _003CPlayStageEffect_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass180_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public string strAnim;

		internal void _003CPlayStageSwitchMainInAnim_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass182_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public bool isShowAnim;

		internal void _003COnChangeStageShow_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public VideoPlayer videoPlayer;

		internal void _003CPlayMainFirstInAnim_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public Action callback;

		internal void _003CPlayZoomOutAnim_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public UIBM26_SYSMainController _003C_003E4__this;

		public List<UINetworkTexture> loadTextures;

		internal void _003CLoadCDNTextureMainView_003Eb__0()
		{
		}

		internal void _003CLoadCDNTextureMainView_003Eb__1()
		{
		}
	}

	private UIBM26SysMainView m_View;

	private UICommonGuideController m_GuideCtrl;

	private EMainViewStatus m_ViewStatus;

	private uint m_FirstInCtrlDelayCall;

	private uint m_AnimDelayKey;

	private uint m_SpineResumeDelayKey;

	private GameObject m_FirstInVFXGo;

	private int m_FirstInCutsceneSoundTicket;

	private string m_PendingZoomInAnimName;

	private bool m_IsFirstInVideoPlaying;

	private VideoPlayer m_CurrentSkippableVideoPlayer;

	private bool m_FirstInVideoSkipBtnRegistered;

	private bool m_InitData;

	private bool m_Setting;

	private UIModelBM26_SYS m_ModelBM26_SYS;

	private UIBM26_SYSTopBtnController m_TopBtnCtrl;

	private UIModelBM26_SYS.EffectObject m_RevenueEffect;

	private uint m_TargetProgress;

	private uint m_StartProgress;

	private uint m_CurrentProgress;

	private float m_ProgessDuration;

	private uint m_ProgressAnimKey;

	private uint m_ProgressEffectKey;

	private List<GameObject> m_ProgressFlyEffectPool;

	private List<uint> m_ProgressFlyEndDelayKeys;

	private float m_MinBezierCurvature;

	private float m_MaxBezierCurvature;

	private bool m_EnableRandomCurvature;

	private Vector3 m_ProgressThumbPosOffect;

	private List<UIModelBM26_SYS.ProgressRewardBoxGo> m_listProgressRewardBoxes;

	private UIProgressBar m_ProgressNodeBarView;

	public UIModelBM26_SYS.RoleSpineObject m_RoleSpineObject;

	private uint m_ShareStatus;

	private AnimatedAlpha m_ShareBgContainerAlpha;

	private bool m_NextStageEffectRead;

	private uint m_WaitStageLoadKey;

	private float m_WaitStageLoadTimeElapsed;

	private int m_LastProgressIndex;

	private Animation m_MainStageContainerAnim;

	protected List<UIModelBM26_SYS.StageObject> m_StageViewList;

	private UIModelBM26_SYS.StageObject m_CurrentStageAnimDataView;

	private UIModelBM26_SYS.EffectObject m_CurrentStageEffectObject;

	private uint m_StageEffectDelayKey;

	private uint m_StageChangeShowDelayKey;

	private uint m_MainStageRedUIFXDelayKey;

	private bool m_DelayShowStage;

	private uint m_DelayShowStageKey;

	private const float STAGE_SWITCH_CHANGE_SHOW_DELAY = 1.3f;

	private bool m_FirstShowStage;

	private uint m_SkipPromptMaskDelayKey;

	private bool m_InitToken;

	private bool m_InitAutoSelectToken;

	private bool m_IsTokenConsuming;

	private uint m_TipsBtnClickKey;

	private int m_TipsLastNum;

	public bool IsVaild => false;

	public bool IsPlaying => false;

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitView()
	{
	}

	private void LoadCDNTextureMainView()
	{
	}

	private void OnLoadCDNTextureMainViewComplete()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override UIBigEventPeakDayWndBaseController GetPeakDayWndCtrl()
	{
		return null;
	}

	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public override void RefreshView()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnGoToNavigation(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	public void OpenBigEventEntranceID(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	private void OpenEntranceController(Type type)
	{
	}

	protected void OnCheckGuide()
	{
	}

	private void OnDestroyGuide()
	{
	}

	public bool OnCheckIsTopPopupWindowsExist()
	{
		return false;
	}

	public bool OnCheckIsStateValid()
	{
		return false;
	}

	private void OnFirstInAnimEnd(string zoomInAnimName)
	{
	}

	public new void OnDataReady()
	{
	}

	private void DoPlayZoomInWithStage(string zoomInAnimName)
	{
	}

	protected void InitAnimView()
	{
	}

	protected void OnPlayMainAnim()
	{
	}

	private bool PlayMainFirstInAnim(ref float firstInDuration)
	{
		return false;
	}

	protected override void PlayFrontEndBGM()
	{
	}

	private void SetFirstInVideoBgmMuted(bool isMuted)
	{
	}

	private void OnVideoPlayComplete(VideoPlayer videoPlayer)
	{
	}

	private void ShowFirstInVideoSkipBtn(bool show)
	{
	}

	private void OnClickFirstInVideoSkipBtn()
	{
	}

	protected void DdaptFixFirstSize()
	{
	}

	private bool PlayDailyFirstInAnim(ref float firstInDuration)
	{
		return false;
	}

	protected void SkipDailyFirstInAnim()
	{
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

	protected void OnDestroyAnimation()
	{
	}

	private void StopFirstInCutsceneSound()
	{
	}

	protected void OnDestroyFirstInVFXGo()
	{
	}

	protected void InitDataView()
	{
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnSettingCallback()
	{
	}

	private void OnInfoCallback()
	{
	}

	private void OnProgressAwardCallback()
	{
	}

	private void OnRedCallback()
	{
	}

	private void OnProgressValCallback()
	{
	}

	private void OnTokenChangedCallback()
	{
	}

	private void OnActivityUpdateCallback()
	{
	}

	private void UpdateNetworkBlock()
	{
	}

	private void InitCommonView()
	{
	}

	private void ShowTokenTips(uint tokenId, Vector3 position)
	{
	}

	private void RefershMission()
	{
	}

	protected void InitTopBtnCtrl()
	{
	}

	private void InitEntrance()
	{
	}

	protected void OnDestroyEntrance()
	{
	}

	private void InitCommonEntranceView()
	{
	}

	private void SetEntranceCdnAndBubbleView()
	{
	}

	public void InitCommonEntrance()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickRuleBtn()
	{
	}

	private void OnClickMissionBtn()
	{
	}

	private GameObject GetProgressFlyEffectFromPool()
	{
		return null;
	}

	private void ReturnProgressFlyEffectToPool(GameObject effect)
	{
	}

	private void InitProgressView()
	{
	}

	private void OnDestroyProgress()
	{
	}

	public void RefershProgressInfoView()
	{
	}

	public void RefreshCycleRewardBoxVisibility()
	{
	}

	private void UpdateProgressData()
	{
	}

	public void PlayProgressEffect()
	{
	}

	public void PlayProgressSubmitFlyEffectFromClaim(uint nextProgress)
	{
	}

	public void PlayProgressSubmitFlyEffect(uint nextProgress, Vector3 startPoint, Vector3 endPoint, float flyDuration)
	{
	}

	public void PlayProgressSubmitAnimatiom(uint simulateProgress)
	{
	}

	private void OnProgressFinishCallback()
	{
	}

	private void UpdateProgressNodes()
	{
	}

	public void InitRoleSpine()
	{
	}

	protected void InitShareView()
	{
	}

	protected void OnDestroyShareView()
	{
	}

	private void OnShareCdnSuccessCallback()
	{
	}

	private void RefershShareBtn()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	private void SendBigEventShareLog(bool success, uint platform)
	{
	}

	private void SendLimitedEventShareLog(uint id, uint platform, uint pageId, uint type, bool success)
	{
	}

	public override void OnCopyShareLink(bool success)
	{
	}

	public override void OnSaveSharePhoto(bool success)
	{
	}

	private void SubmitShareActivity()
	{
	}

	private void SetShareView(bool visible)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnClickShareBtn()
	{
	}

	private void DoShare(ClientActivityDesc clientActivityDesc)
	{
	}

	private void OnShareClose()
	{
	}

	private void RefreshShareRed()
	{
	}

	protected void InitStage()
	{
	}

	protected void OnDestroyStage()
	{
	}

	protected void InitStageAnim()
	{
	}

	protected void InitShowStageAnimm()
	{
	}

	protected void PrepareDelayShowStage()
	{
	}

	protected void DelayShowStage(float delayTime)
	{
	}

	protected void ClearDelayShowStage(bool showStage = false)
	{
	}

	private UIModelBM26_SYS.StageObject GetStageViewByUnlockIndex(int unlockIndex)
	{
		return null;
	}

	private int GetCurrentStageUnlockIndex()
	{
		return 0;
	}

	private int GetLatestUnlockedStageUnlockIndex()
	{
		return 0;
	}

	private UIModelBM26_SYS.StageObject.StageVisableState GetStageVisableState(int unlockIndex, int progressIndex)
	{
		return UIModelBM26_SYS.StageObject.StageVisableState.DisActive;
	}

	protected void ShowStageActive()
	{
	}

	protected void ChangeStageVisable(bool isShowAnim = false, bool isEnterStage = false)
	{
	}

	protected void PlayStageIdleAnim()
	{
	}

	protected void PlayStageFirstEffect()
	{
	}

	protected void LoadNextStageEffect()
	{
	}

	private void WaitForStageEffectLoad(Action onLoadComplete, float delayTime = 0.05f)
	{
	}

	protected void ClearWaitStageLoad()
	{
	}

	public bool PlayStageAnim(string animName, out float animLength)
	{
		animLength = default(float);
		return false;
	}

	public void CheckChangeStage()
	{
	}

	private void PlayThirdTokenWithStageSwitch()
	{
	}

	public void PlayStageEffect(ResourceID effectResId, float delayTime = 0f)
	{
	}

	private float PlayMainStageMaxRedUIFX()
	{
		return 0f;
	}

	private void ClearMainStageRedUIFXDelay()
	{
	}

	public void PlayClearStageEffect()
	{
	}

	public void ClearStageEffect()
	{
	}

	private void ClearStageChangeShowDelay()
	{
	}

	private void PlayStageSwitchAnim()
	{
	}

	private void PlayStageSwitchMainInAnim()
	{
	}

	private void PlayStageSwitchMainInAnimInternal(string strAnim)
	{
	}

	protected void OnChangeStageShow(bool isShowAnim = false)
	{
	}

	private void OnStageSwitchComplete()
	{
	}

	private void OnClickStageSkipBtn()
	{
	}

	protected void ClearSkipPromptMaskDelay()
	{
	}

	protected void InitTokenView()
	{
	}

	protected void OnDestroyTokenView()
	{
	}

	protected void OnClickComsumeTokenBtn()
	{
	}

	protected void ShowSpecTipsBtnClickAnim()
	{
	}

	private void ProcessNextPendingToken(uint tokenCount)
	{
	}

	private void ProcessMaxToken()
	{
	}

	private void OnRequestConsumeFailed()
	{
	}

	private void OnConsumeTokenComplete()
	{
	}

	private void StartTokenConsumePresentation()
	{
	}

	private void UpdateTipsNumState()
	{
	}

	protected void RefreshTipsLabelState()
	{
	}

	private void InitShowTipsState(bool force = false)
	{
	}

	private void UpdateShowTipsNum()
	{
	}

	public void ShowTokenTipsDetail()
	{
	}

	private void _003CPlayDailyFirstInAnim_003Eb__49_0()
	{
	}

	private void _003CPlayZoomInAnim_003Eb__51_0()
	{
	}

	private void _003CPlayProgressSubmitAnimatiom_003Eb__112_0()
	{
	}

	private void _003COnProgressFinishCallback_003Eb__113_0()
	{
	}

	private void _003CInitShowStageAnimm_003Eb__155_0()
	{
	}

	private void _003CDelayShowStage_003Eb__157_0()
	{
	}

	private void _003CPlayThirdTokenWithStageSwitch_003Eb__172_0()
	{
	}

	private void _003CPlayMainStageMaxRedUIFX_003Eb__174_0()
	{
	}

	private void _003CPlayStageSwitchAnim_003Eb__179_0()
	{
	}

	private void _003CPlayStageSwitchAnim_003Eb__179_1()
	{
	}

	private void _003CPlayStageSwitchMainInAnimInternal_003Eb__181_0()
	{
	}

	private void _003COnClickStageSkipBtn_003Eb__185_0()
	{
	}

	private void _003CShowSpecTipsBtnClickAnim_003Eb__195_0()
	{
	}

	private void _003CShowSpecTipsBtnClickAnim_003Eb__195_1()
	{
	}

	private void _003CStartTokenConsumePresentation_003Eb__200_0()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public UIBigEventPeakDayWndBaseController _003C_003EiFixBaseProxy_GetPeakDayWndCtrl()
	{
		return null;
	}

	public new UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}

	public new bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnGoToNavigation(UIModelBigEvent.EBigEventEntranceID P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayFrontEndBGM()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCopyShareLink(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSaveSharePhoto(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
