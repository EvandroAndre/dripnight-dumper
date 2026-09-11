using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UILobbyGroupV2Controller : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIModelGroup modelGroup;

		internal void _003COnPlayBtnClickOffline_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayReposInfoGrid_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyGroupV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayReposInfoGrid_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003CSetButtonCoolDown_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UILobbyGroupV2Controller _003C_003E4__this;

		public UIButton btn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetButtonCoolDown_003Ed__95(int _003C_003E1__state)
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

	private UILobbyGroupV2View m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelChat m_ModelChat;

	private UIModelHuntingGround m_ModelHuntingGround;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelMatch m_ModelMatch;

	private UIModelInventory m_ModelInventory;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private UILobbyV2TeamInfoController m_TeamInfoController;

	private UILobbyV2TeamLimitTipsController m_TeamLimitTipsController;

	private UILobbyGroupV2InGameTeamInfoController m_InGameTeamInfoCtrl;

	protected byte m_GameMode;

	private UIPopupMessageBoxController m_QuitDialog;

	private UICountDownController m_BanMatchCDCtrl;

	private CMDBIPLGLGA m_GroupMode;

	private uint m_DelayCallID;

	private readonly int INVITE_GUIDE_TIME;

	private uint m_TipsGuideCall;

	private uint m_StartGameGuideCall;

	private UICommonGuideController m_CommonGuideCtrl;

	private uint m_PlayDelayCall;

	private uint m_AllReadyDelayCall;

	private bool m_UpdateAfterPurchase;

	private bool m_AllReady;

	private GameObject m_RemindPlayShot;

	private Color TeamLimitGreyColor;

	private string m_defaultStartIcon;

	private bool m_IsInGame;

	private Vector3 m_InfoGridOriPosition;

	private Vector3 m_InfoGridSoloPosition;

	private const string MIX_GROUP_FIGHTON_TIPS_KEY = "T_53_D_1V1FIGHTON_TIPS2";

	public const string BRMapIcon = "FF_icon_RankTipsUp";

	public const string CSMapIcon = "FF_icon_RankTipsUp_CS";

	public const string BRMapLackIcon = "FF_icon_RankTipsUp_01";

	public const string CSMapLackIcon = "FF_icon_RankTipsUp_CS_01";

	private const string MapLight = "UI_Bg_Line_03";

	public const string SocialBufIcon = "UI_icon_socialbuff";

	private const string SocialBufLight = "UI_Bg_Line_02";

	private const string RankLimitLight = "UI_Bg_Line_01";

	public const string TeamRankLimitedIcon = "UI_Icon_Rank02";

	public static bool DebugSkipCSPeakSquadCheck;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void TryInitInGameTeamInfo()
	{
	}

	private void GroupVoiceRejoin(object[] param)
	{
	}

	private void TryJoinGroupVoiceRoom(bool forceJoin = false)
	{
	}

	private void OnRemindSuccess()
	{
	}

	private void OnGetRemind(object[] param)
	{
	}

	private void OnPeriodicLadderMapSelectChanged(object[] param)
	{
	}

	private void RefreshBtnTeamInfoView()
	{
	}

	private IEnumerator DelayReposInfoGrid()
	{
		return null;
	}

	private void UpdateGroupInfo()
	{
	}

	private void UpdateSkillBtnState()
	{
	}

	private void OnCupTicketToggleChange()
	{
	}

	private void OnBanMatchBtnClick()
	{
	}

	private void OnInHippoCrisisBtnClick()
	{
	}

	private void OnInRoomBtnClick()
	{
	}

	private void OnOpenCustomRoom(object[] param)
	{
	}

	private void OnCloseCustomRoom(object[] param)
	{
	}

	private bool CanRequestUseTicket(bool choice)
	{
		return false;
	}

	public void SetData(string modeName, string mapName, uint groupMode)
	{
	}

	private void OnClickLeaveGroup(object[] data)
	{
	}

	private void onLeaveBtnClick()
	{
	}

	public void OnUGCLeaveGroup(object[] data)
	{
	}

	public void ResetReadyBtn()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnMatchmakingHide()
	{
	}

	private void OnMatchmakingShow()
	{
	}

	private void OnRoomHangup(object[] data)
	{
	}

	private void OnRoomHangupEnd(object[] data)
	{
	}

	private void OnCupTeamLockSuccess(object[] data)
	{
	}

	private void OnGroupQuit(object[] data)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void ResetInfoGridPosition()
	{
	}

	public void CloseGroupUI()
	{
	}

	public void OnPlayBtnClickOffline()
	{
	}

	public void OnPlayBtnClick()
	{
	}

	private bool IsCSPeakSquadSelected()
	{
		return false;
	}

	private bool IsCSPeakSquadPlayerCountEnough()
	{
		return false;
	}

	private void RequestPlayAfterCreateGroup()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void OnCupMatchSecondConfirm(object[] data)
	{
	}

	private void HideReadyEffect(object[] data)
	{
	}

	public void OnReadyBtnClick()
	{
	}

	private void OnHighPingExpire()
	{
	}

	private void OnReady(bool manualClick)
	{
	}

	private void RefreshReadyState(object[] param)
	{
	}

	private void OnRecruitStateChange(object[] data)
	{
	}

	private bool IsOpenHippoCrisisLobby()
	{
		return false;
	}

	private bool CheckIsMapAvailabe()
	{
		return false;
	}

	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
	{
		return null;
	}

	private void StartMatchMaking()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private static bool IsNewGroupChatMessageAdded(uint propID, object[] param)
	{
		return false;
	}

	private void TryShowSocialAreaGroupRemindTips()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshRankLimitView()
	{
	}

	private void SetTeamRankLimitTipBg(bool showSoft, bool showHard)
	{
	}

	private void HandleLeaveNtf(object[] param)
	{
	}

	private void OnGroupStartNtf(object[] data)
	{
	}

	private void OnGroupStopNtf(object[] data)
	{
	}

	private void OnGroupReadyNtf(object[] data)
	{
	}

	private void RefreshReadyBtnStyle()
	{
	}

	private void OnGroupAllReadyStateChanged(object[] data)
	{
	}

	private void RefreshStartBtn(bool showAllReady = false, bool showAllReadyTips = false)
	{
	}

	private void RefreshInHippoCrisisState()
	{
	}

	private void ShowReadyEffect(GroupEffectShow show)
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnLeaveNtf(object[] data)
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void HideOnlineMatchInfo()
	{
	}

	private void RefreshChampionshipInfo()
	{
	}

	private void RefreshCupMatchInfo()
	{
	}

	private void RefreshChampionshipTeamName()
	{
	}

	private void RefreshCupMatchTeamName()
	{
	}

	private void RefreshAutoMatchUI(bool forceSetAutoMacth = false)
	{
	}

	private void OnServiceOff(object[] data)
	{
	}

	private void OnQuitToSolo(object[] data)
	{
	}

	private void OnCreateGroupFail(object[] data)
	{
	}

	private void OnDismissNtf(object[] data)
	{
	}

	private void NotInGroup(object[] data)
	{
	}

	private void OnTicketBtnClick()
	{
	}

	public void StartNewbieGuide()
	{
	}

	public void StopNewbieGuide(object[] args)
	{
	}

	public void OnStopGroupNewbieGuide()
	{
	}

	private void OnShowLobbyStartGameGuide(object[] data)
	{
	}

	private void RefreshGroupLeaderView(object[] data)
	{
	}

	private void OnGroupNotReady(object[] data)
	{
	}

	public void StopRemindAnim(object[] data)
	{
	}

	private void OnSelfNotReady(object[] data)
	{
	}

	private void CancelPlayDelayCall()
	{
	}

	private void ShowCupTeamLocking(bool show)
	{
	}

	private void RefreshGameLobbyEnterStyle()
	{
	}

	private void RefreshStartBtnView(string lobbyStartIcon)
	{
	}

	private void OnBtnTeamInfoClick()
	{
	}

	private void OnBtnRankLimitClick()
	{
	}

	private void RefreshBtnView()
	{
	}

	private void RefreshBanMatchView()
	{
	}

	private void GroupInfoSync(object[] param)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void _003ConLeaveBtnClick_003Eb__65_0()
	{
	}

	private void _003ConLeaveBtnClick_003Eb__65_1()
	{
	}

	private void _003CRefreshStartBtn_003Eb__109_0()
	{
	}

	private void _003CStartNewbieGuide_003Eb__127_0()
	{
	}

	private void _003COnGroupNotReady_003Eb__132_0()
	{
	}

	private void _003CRefreshBanMatchView_003Eb__142_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
