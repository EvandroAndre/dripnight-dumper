using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIQuickMatchController : UIBaseController, IUIModelDataChangeObserver
{
	public enum InterfaceType
	{
		Booyah = 1,
		Observer,
		Result,
		DragonTaskSkip
	}

	public enum EQuickMatchType
	{
		Normal,
		InviteDuel
	}

	public enum QuickMatchEnd
	{
		TeamingRankLimit = 1,
		CreditPunish
	}

	public enum EDisplayMode
	{
		QuickMatch,
		Rematch
	}

	public enum RematchReason
	{
		Default,
		Win,
		TeamKills,
		AvgRating,
		TeamRevives
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__66_0;

		public static Converter<MapModeData, uint> _003C_003E9__68_0;

		public static Converter<MapModeData, uint> _003C_003E9__117_0;

		internal void _003CInit_003Eb__66_0()
		{
		}

		internal uint _003CStartSoloMatchMaking_003Eb__68_0(MapModeData x)
		{
			return 0u;
		}

		internal uint _003COnInviteDuelBtnClick_003Eb__117_0(MapModeData x)
		{
			return 0u;
		}
	}

	private sealed class _003CRematchCountDownCoroutine_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIQuickMatchController _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003CtotalTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRematchCountDownCoroutine_003Ed__134(int _003C_003E1__state)
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

	private static readonly Dictionary<uint, string> RematchReasonToLocKey;

	public UIButton SoloQuickNextBtn;

	public UIButton MultQuickNextBtn;

	public UIButton ReadyBtn;

	public GameObject MatchMaking;

	public GameObject ReadyLabel;

	public GameObject CancelReadyLabel;

	public UIButton DisableBtn;

	public UILabel DisableBtnLabel;

	public UILabel MentionLabel;

	public UIMatchMakingManager m_MatchMakingManager;

	public GameObject NoticeVFX;

	public UIButton InviteDuelBtn;

	public GameObject WaitingDuelWidget;

	public UIButton AcceptDuelBtn;

	public GameObject RefuseDuelWidget;

	public UIButton PostMatchTeamUpBtn;

	public UILabel PostMatchTeamUpBtnLabel;

	public UIProgressBar RematchCountDownProgressBar;

	public GameObject RematchCountDownContainer;

	public UISprite RematchCountDownIcon;

	public UILabel RematchCountDownLabel;

	public UIButton PostMatchTeamUpQuickStartBtn;

	public UIButton PostMatchTeamUpDropDownBtn;

	public UIButton PostMatchTeamUpCancelBtn;

	public GameObject PostMatchTeammateContainerPos;

	public UILabel NewPostMatchTeamUpBtnLabel;

	private UIPostMacthButtonTeammatesContainerController m_PostMatchTeammatesContainerController;

	public VFXCreateHelper ThumbPos;

	private Coroutine m_RematchCountDownCoroutine;

	private bool m_IsInitCountDownState;

	private GameObject PostMatchTeamUpBtnPopup;

	private UILabel PostMatchTeamUpBtnPopupLabel;

	private EQuickMatchType m_QuickMatchType;

	private InterfaceType m_InterfaceType;

	private string MentionLabelText;

	private string MentionKey;

	private string SoloBtnKey;

	private string GroupBtnKey;

	public bool m_EnableQuickMatch;

	private EDisplayMode m_DisplayMode;

	private bool IsSoloGame;

	private float m_VFXDuration;

	private uint m_CloseNoticeVFXDelayCall;

	private ulong m_RemindeeTs;

	private ulong m_RemindeeCD;

	private uint m_LatestClickedType;

	public bool m_IsRankingTipsBubbleShow;

	public bool IsRematchPostMatching;

	private float m_EmergencyEffect;

	private UIModelMatch m_ModelMatch;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelUser m_ModelUser;

	private UIModelTeamReserve m_ModelTeamReserve;

	public bool IsRankingTipsBubbleShow
	{
		get
		{
			return false;
		}
		set
		{
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

	private void Init()
	{
	}

	private void RefreshGroupWaiting()
	{
	}

	private void StartSoloMatchMaking()
	{
	}

	public void CloseAllGameObject()
	{
	}

	public void RefreshBtnState()
	{
	}

	private void RefreshQuickMatchUI()
	{
	}

	private bool IsWinBooyahTeam()
	{
		return false;
	}

	private void RefreshPostMatchUI()
	{
	}

	private bool CanShowPostMatchCancelReadyUI()
	{
		return false;
	}

	private void RefreshRematchInvitePopupState()
	{
	}

	private void ShowRematchInvitePopup()
	{
	}

	private void CloseRematchInvitePopup()
	{
	}

	private void SaveRematchInviteIgnoreTodayIfChecked()
	{
	}

	public bool CheckCanRematchStart(ref ERematch.QuitReason reason)
	{
		return false;
	}

	public void RefreshDisableQuickMatchBtn()
	{
	}

	private void RefreshReadyLabel()
	{
	}

	private void CheckCanQuickMatch()
	{
	}

	private void OnMapIsError()
	{
	}

	private void OnMatchMakingHide()
	{
	}

	private void OnMatchMakingShow()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	private void OnGroupStopNtf(object[] data)
	{
	}

	private void OnGroupReadyNtf(object[] data)
	{
	}

	private void OnSoloQuickNextBtnClick()
	{
	}

	private void OnReadyBtnClick()
	{
	}

	private void OnDisableReadyBtnClick()
	{
	}

	private void OnMultQuickNextBtnClick()
	{
	}

	private void OnDisableQuickMatchBtn(uint type)
	{
	}

	private void OnLeaveGroup(object[] data)
	{
	}

	private void RefreshBtnState(object[] data)
	{
	}

	private void RefeshMentionLabel()
	{
	}

	private void OnGroupAllReadyStateChanged(object[] param)
	{
	}

	private void OnGroupErr()
	{
	}

	private void OnGetRemind(object[] data)
	{
	}

	public void OnDragonSkip()
	{
	}

	private void CloseNoticeVFX()
	{
	}

	private void RefreshByDisableState()
	{
	}

	private void OnQuickMatchEnd(object[] data)
	{
	}

	public void SetData(InterfaceType interfaceType, UIButton SoloQuickNextBtn = null, UIButton MultQuickNextBtn = null, UIButton ReadyBtn = null, GameObject MatchMaking = null, GameObject ReadyLabel = null, GameObject CancelReadyLabel = null, UIButton DisableBtn = null, UILabel DisableBtnLabel = null, UILabel MentionLabel = null, GameObject NoticeVFX = null, UIButton PostMatchTeamUpBtn = null, UILabel PostMatchTeamUpBtnLabel = null, UIProgressBar RematchCountDownProgressBar = null, UIButton PostMatchTeamUpQuickStartBtn = null, GameObject PostMatchTeamUpBtnPopup = null, UILabel PostMatchTeamUpBtnPopupLabel = null, UIButton PostMatchTeamUpCancelBtn = null, VFXCreateHelper ThumbPos = null, GameObject RematchCountDownContainer = null, UISprite RematchCountDownIcon = null, UILabel RematchCountDownLabel = null, GameObject PostMatchTeammateContainerPos = null, UILabel NewPostMatchTeamUpBtnLabel = null)
	{
	}

	public void SetDuelData(UIButton InviteDuelBtn, GameObject WaitingDuelWidget, UIButton AcceptDuelBtn, GameObject RefuseDuelWidget)
	{
	}

	public void SetRequestDuelState()
	{
	}

	public void SetClickQuickMatchLog()
	{
	}

	public void SetClickReturnLobby(bool isReturnToLobby = false)
	{
	}

	public void SetClickReturnToMatchResultLog()
	{
	}

	public void DisableQuickMatch()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public bool IsQuickMatchCanShow()
	{
		return false;
	}

	private void CheckAndSwitchToRematchModeIfNeeded()
	{
	}

	public void SetRematchMode()
	{
	}

	public void SetQuickMatchMode()
	{
	}

	public EDisplayMode GetDisplayMode()
	{
		return EDisplayMode.QuickMatch;
	}

	public void OnInviteDuelBtnClick()
	{
	}

	private void OnAcceptDuelBtnClick()
	{
	}

	private void OnGroupInviteSent(object[] data)
	{
	}

	private void OnGroupInviteNtf(object[] data)
	{
	}

	private void OnGroupRefuseNtf(object[] data)
	{
	}

	private void OnGroupCreateSuccess()
	{
	}

	private void OnGroupJoinNtf(object[] data)
	{
	}

	private void TargetRefuseDuel()
	{
	}

	private void OnLonewolfPlayerLogoutGameserverNtf(ulong data)
	{
	}

	private void SetTargetRefuseDuel()
	{
	}

	private void OnGroupStartNtf(object[] data)
	{
	}

	private void ClearDuelState()
	{
	}

	private void RefreshPlayerIcon()
	{
	}

	private void RefreshPostMatchTeamUpBtnState()
	{
	}

	private string GetPostMatchTeamUpBtnPopupLabelText()
	{
		return null;
	}

	private void StartRematchCountDown()
	{
	}

	private void StopRematchCountDown()
	{
	}

	private IEnumerator RematchCountDownCoroutine()
	{
		return null;
	}

	private void OnPostMatchTeamUpBtnClick()
	{
	}

	private void OnPostMatchTeamUpCancelBtnClick()
	{
	}

	private void OnPostMatchTeamUpQuickStartBtnClick()
	{
	}

	public void OnRematchPopupClosed(object[] data)
	{
	}

	public void OnRematchStartQuickMatchNoDisableNtf(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
