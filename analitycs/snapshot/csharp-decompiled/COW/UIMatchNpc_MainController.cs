using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIMatchNpc_MainController : UINavigationController, IUIModelDataChangeObserver, IGuideQueueContainer, IBigEventTemplateIdentifier
{
	private sealed class _003CDelayRunGuideQueueCoroutine_003Ed__221 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMatchNpc_MainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRunGuideQueueCoroutine_003Ed__221(int _003C_003E1__state)
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

	private sealed class _003CPlayerAddTokenProcessUpgradeEffectEnumrator_003Ed__202 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMatchNpc_MainController _003C_003E4__this;

		private float _003Cbegin_value_003E5__2;

		private float _003Cend_value_003E5__3;

		private float _003CrollTime_003E5__4;

		private float _003ClerpValue_003E5__5;

		private float _003Cspeed_003E5__6;

		private UIProgressBar _003Cm_PlayerProcessBar_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayerAddTokenProcessUpgradeEffectEnumrator_003Ed__202(int _003C_003E1__state)
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

	private sealed class _003CPlayerTurnFinishedProcessUpgradeEffectEnumrator_003Ed__203 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMatchNpc_MainController _003C_003E4__this;

		private float _003Cbegin_value_003E5__2;

		private float _003Cend_value_003E5__3;

		private float _003CrollTime_003E5__4;

		private float _003ClerpValue_003E5__5;

		private float _003Cspeed_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayerTurnFinishedProcessUpgradeEffectEnumrator_003Ed__203(int _003C_003E1__state)
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

	private const string GUIDE_STEP1_KEY = "CustomEventMatchNPC_GuideStep1";

	private const string GUIDE_STEP2_KEY = "CustomEventMatchNPC_GuideStep2";

	private const string GUIDE_STEP3_KEY = "CustomEventMatchNPC_GuideStep3";

	private const int MillisecondToSecond = 1000;

	private const int LogTimeDigit = 1;

	private UIMatchNpc_MainView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelBigEvent_MatchNPC m_ModelBigEventMatchNpc;

	private List<UIBigEvent_Template_BtnItemBaseController> m_LeftBtnCtrls;

	private uint m_NextStoryId;

	private uint m_NowStoryId;

	private uint m_CurrentDialogStartStoryID;

	private double m_CurrentDialogStartTimestamp;

	private BigEventMatchNpcStoryType m_LastStoryShowType;

	private Action m_OnStoryFinished;

	private uint m_LastCharType;

	private List<UIMatchNpc_RewardBoxItemController> m_ShowRewardBoxItemList;

	private UIMatchNpc_RepeatRewardPrePopController m_RepeatRewardPopWnd;

	private UIBigEvent_MatchNPC_TokenItemController m_TokenCtrl;

	private BigEventMatchNpcCharPos m_PlayerPos;

	private const uint LEFT_CHARTALK = 1u;

	private const uint RIGHT_CHARTALK = 2u;

	private const uint NARRATION = 3u;

	private uint m_PlayerProcessMax;

	private uint m_NpcProcessMax;

	private uint m_PlayerTotalProcess;

	private bool m_ShowRedDotTexture;

	private uint m_PlayerBeforeAddTokenProcessValue;

	private uint m_PlayerBeforeTurnFinishedTotalProcessValue;

	private GuideQueue m_GuideQueue;

	private Coroutine m_DelayRunGuideQueueCoroutine;

	private GameObject m_PlayerWinIcon;

	private GameObject m_NpcWinIcon;

	private bool m_PlayerWinInThisTurn;

	private Vector3 m_LNpcBeginFlyInEffectPos;

	private Vector3 m_RNpcBeginFlyInEffectPos;

	private uint m_NowStoryProcessAmount;

	private ulong HourToSec;

	private static int SINGLEDIALOGMAXSHOWCHAR;

	private BigEventMatchNpcStoryType m_NowStoryShowType;

	private AudioResource m_WriterTypeSound;

	private AudioResource m_LoopUpgradeSound;

	private bool m_ShowSingleDialogTypeEffect;

	private bool m_ShowSpecialDialogTypeEffect;

	private uint m_DialogWriterSoundDelaycallID;

	private uint m_GuideDelayID;

	private uint m_AnimationInEffectDelayCall;

	private bool isFirstInMatchNPC;

	private bool m_isTotalProcessUseCdn;

	private bool m_hasInitTemplateUI;

	private ResourceID m_TokenToCharProcessVFXResID;

	private GameObject m_TokenToCharProcessVFXResGO;

	private ResourceID m_GainCharProcessVFXResID;

	private GameObject m_GainCharProcessVFXResGO;

	private ResourceID m_GainTotalProcessNPCVFXResID;

	private GameObject m_GainTotalProcessNPCVFXResGO;

	private ResourceID m_GainTotalProcessPlayerVFXResID;

	private GameObject m_GainTotalProcessPlayerVFXResGO;

	private ResourceID m_LeftFlyInEffectToTotalProcessVFXResID;

	private GameObject m_LeftFlyInEffectToTotalProcessVFXResGO;

	private ResourceID m_RightFlyInEffectToTotalProcessVFXResID;

	private GameObject m_RightFlyInEffectToTotalProcessVFXResGO;

	private ResourceID m_ShowResultBtnVFXResID;

	private GameObject m_ShowResultBtnVFXResGO;

	private ResourceID m_AddTokenBtnVFXResID;

	private GameObject m_AddTokenBtnVFXResGO;

	private ResourceID m_NpcUpGradeProcessEffectVFXResID;

	private GameObject m_NpcUpGradeProcessEffectVFXGO;

	private ResourceID m_WeakEnvironmentVFXResID;

	private GameObject m_WeakEnvironmentVFXResGO;

	private ResourceID m_DivideIconVFXResID;

	private GameObject m_DivideIconVFXResGO;

	private bool m_ShowGainProcessPlayerUp;

	private Coroutine m_PlayProceeUpgradeCoroutine;

	private Coroutine m_PlayTotalProcessUpgradeCoroutine;

	private const string SpecialDialogInAnimation = "UIFX_Common_UIMatch_Main_In";

	private const string SpecialDialogOutAnimation = "UIFX_Common_UIMatch_Main_Out";

	private const string SpecialDialogRoleInAnimation = "UIFX_UIMatchNpc_Role_In";

	private UIButton m_AddTokenBtn;

	private bool m_AddTokenShowNormal;

	private UIButton m_TurnFinishedBtn;

	private uint m_OpenSkipBtnDelayCall;

	private ulong m_LastClickTimeStamp;

	private static ulong TIMEGAP;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	private ulong countDownDetalTimeRefreshNpcProcess;

	private uint preProcessDetalTime;

	private uint m_CloseWndCount;

	private uint m_NeedCloseWnd;

	private bool m_ShowTypeEffect;

	private string m_NextShowStoryContent;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
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

	public static string PlayerFirstInMatchNpcActivity()
	{
		return null;
	}

	private void CheckPlayerFirstInMatchNpcBigEvent()
	{
	}

	private void CheckShowPopUpPeakDayWnd()
	{
	}

	private void InitCDN()
	{
	}

	private void InitUserInBigEventWndPlayDialog()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void InitLeftTopTitleCDNAndOpenTime()
	{
	}

	private void InitTokenOwnedShowState()
	{
	}

	private void RefreshTokenOwnNumAndCanAddNum()
	{
	}

	private void ShowPeakDayPopWnd()
	{
	}

	private void InitLeftBtnGrid()
	{
	}

	private void InitLeftBtnCtrls()
	{
	}

	private void InitCenterCDNPic()
	{
	}

	private void InitCentreCharactarProcessNum()
	{
	}

	private void InitIsYouTagShowState()
	{
	}

	private void OnInitCountDownUpdateCallBack()
	{
	}

	private void RefreshCountDownBeginTime()
	{
	}

	private void CountDownUpdateRefreshNpcProcess()
	{
	}

	private void CheckCountDownFinishedNpcProcess()
	{
	}

	private void RefreshNpcCountDownLabel()
	{
	}

	private void InitSpecialDialogCdn()
	{
	}

	private void InitRightRewardShow()
	{
	}

	private void CheckIsTotalProcessUseCdn()
	{
	}

	private void RefreshTotalProcess()
	{
	}

	private void InitRepeatRewardItem()
	{
	}

	private void OnRepeatRewardBtnClick()
	{
	}

	private void InitRewardBoxItemShow()
	{
	}

	private bool IsDialogProcessing()
	{
		return false;
	}

	private void SendLogOnDialogFinished()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void OnSkipBtnClick()
	{
	}

	private void OnBgDialogClick()
	{
	}

	private void ClaimReward(object[] data)
	{
	}

	private void ShowRewardPopWnd(object[] data)
	{
	}

	protected void OnFirstComeinAnimationClose(object[] data)
	{
	}

	private void InitMainGameShow()
	{
	}

	private void OnTurnResultWndOkBtnClick(object[] data)
	{
	}

	private void AddTokenBtnClick()
	{
	}

	private void OnTurnFinishedBtnClick()
	{
	}

	private void PauseCounDownLabel()
	{
	}

	private void OnMissionEntranceBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnCountDownloadBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void ShowDiaglog(BigEventMatchNpcTriggerDialogState state, Action onStoryFinished = null)
	{
	}

	private void InitSingleDialogTalkContent(CustomEventMatchNPCStoryDesc story_item)
	{
	}

	private void InitNextShowStoryString(string story_content)
	{
	}

	private bool IsInTypeWriteEffect()
	{
		return false;
	}

	private void StopTypeEffectSound()
	{
	}

	private void ResetSingleDialogWriteSoundState()
	{
	}

	private void ResetSpecialWriterSoundState()
	{
	}

	private void OnLNpcSingleDialogMaskClick()
	{
	}

	private void OnRNpcSingleDialogMaskClick()
	{
	}

	private void OnNextSingleDialogBtnClick()
	{
	}

	private void InitSpecialDialogCharNameShow()
	{
	}

	private void InitSpecialDialogSpeak(CustomEventMatchNPCStoryDesc storyItem)
	{
	}

	private void OpenSkipBtn()
	{
	}

	private void InitSpecialDialogShowStateNarration()
	{
	}

	private void InitSpecialDialogShowStatePlayerTalk()
	{
	}

	private void InitSpecialDialogShowStateFromNarrationToPlayerTalk()
	{
	}

	private void InitSpecialDialogShowStateFromPlayerTalkToNarration()
	{
	}

	private void HideAllYouTag()
	{
	}

	private void OnTPSpecialDialogNextBtnClick()
	{
	}

	private void InitRedDotShowState()
	{
	}

	private void InitShowCentreBtnState()
	{
	}

	private void HideNpcUpgradeEffect()
	{
	}

	private void ShowNpcUpgradeEffect()
	{
	}

	private void PlayTwonPersonInTalkAnim(bool playSound = true)
	{
	}

	private void PlayTwoPersonOutTalkAnim()
	{
	}

	private bool CheckThisTurnFinished()
	{
		return false;
	}

	private bool CheckThisTurnPlayerIsWin()
	{
		return false;
	}

	private bool CheckUserHaveToken()
	{
		return false;
	}

	private uint GetAddMaxTokenNum()
	{
		return 0u;
	}

	private uint PlayerCanAddTokenMaxCount()
	{
		return 0u;
	}

	private void ShowTurnFinishedBtn()
	{
	}

	private void ShowTokenAddBtn()
	{
	}

	private void RefresRightTotalProcessBar()
	{
	}

	private void RefreshPlayerAndNpcProcess(bool onlyRefreshNpc = false)
	{
	}

	private void InitPlayerAndNpcProcessLabelText(UILabel playerLabel, UILabel npcLabel, UIProgressBar playerProcessBar, UIProgressBar npcProcessBar, bool onlyRefreshNpc = false)
	{
	}

	private void RefreshCloseBtnShowState()
	{
	}

	private void CancelBtnAble()
	{
	}

	private void EnableBtnClick()
	{
	}

	private void RefreshAddTokenEffect()
	{
	}

	private void InitEffectShowState()
	{
	}

	private void InitNpcUpgradeEffect()
	{
	}

	private void InitEnvironmentWeakEffect()
	{
	}

	private void InitFirstComeInEffect()
	{
	}

	private void InitTypeWriterVFX()
	{
	}

	private void InitFlyInEffectPositionTween()
	{
	}

	private void InitDivideIconVFX()
	{
	}

	private void PlayTurnFinishedNpcAndPlayerFlyInEffect()
	{
	}

	private void PlayAddTokenEffectFlyInEffect()
	{
	}

	private void OnAddTokenFlyInEffectFinished()
	{
	}

	private void OnTurnFinishedLFlyInEffectFinished()
	{
	}

	private void OnTurnFinishedRFlyInEffectFinished()
	{
	}

	private void InitTotalProcessUpEffect()
	{
	}

	private void InitAddTokenUpgradeEffect()
	{
	}

	private void InitShowResultBtnEffect()
	{
	}

	private void InitAddTokenBtnEffect()
	{
	}

	private void PlayTotalProcessUpEffect()
	{
	}

	private void PlayAddTokenUpgradeEffect()
	{
	}

	private IEnumerator PlayerAddTokenProcessUpgradeEffectEnumrator()
	{
		return null;
	}

	private IEnumerator PlayerTurnFinishedProcessUpgradeEffectEnumrator()
	{
		return null;
	}

	private void RefreshRepeatRewardEffectState()
	{
	}

	private void RefreshRepeatRewardProcess()
	{
	}

	private void ResetEffectTweenPosition()
	{
	}

	private GameObject GetMissionEntranceTips()
	{
		return null;
	}

	private GameObject GetTurnFinishedTips()
	{
		return null;
	}

	private GameObject GetRepeatRewardTips()
	{
		return null;
	}

	private void RefreshCommonEntrancesTips()
	{
	}

	private void RefreshMissionEntranceTips()
	{
	}

	private void RefreshRightRewardTips()
	{
	}

	private void RefreshRepeatRewardTips()
	{
	}

	private void RefreshTurnFinishedTips()
	{
	}

	public bool IsAvailable()
	{
		return false;
	}

	public bool IsStepAvailable(string stepKey, out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	public GameObject GetGuideMask()
	{
		return null;
	}

	public UICommonGuideController OpenGuideController(string stepKey)
	{
		return null;
	}

	private void AddGuideQueueSteps()
	{
	}

	private void StartDelayRunGuideQueueCoroutine()
	{
	}

	private IEnumerator DelayRunGuideQueueCoroutine()
	{
		return null;
	}

	private void CloseSkipBtn()
	{
	}

	private void CloseSkipBtnDelayCall()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnGotoNavigation(uint entranceType)
	{
	}

	private void _003CRefreshNpcCountDownLabel_003Eb__116_0()
	{
	}

	private void _003CRefreshNpcCountDownLabel_003Eb__116_1()
	{
	}

	private void _003COnTPSpecialDialogNextBtnClick_003Eb__163_0()
	{
	}

	private void _003CPlayTwoPersonOutTalkAnim_003Eb__169_0()
	{
	}

	private void _003CInitFirstComeInEffect_003Eb__187_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
