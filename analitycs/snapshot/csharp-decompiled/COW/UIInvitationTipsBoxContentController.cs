using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

internal class UIInvitationTipsBoxContentController : UIBaseController
{
	public enum ESameMatchRelationType
	{
		Unknown,
		Teammate,
		Enemy
	}

	private struct KDAItem(string name, uint value, uint threshold, int priority)
	{
		public string Name = null;

		public uint Value = 0u;

		public uint Threshold = 0u;

		public int Priority = 0;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__84_0;

		public static Converter<uint, object> _003C_003E9__84_1;

		public static Predicate<uint> _003C_003E9__85_0;

		public static Converter<uint, object> _003C_003E9__85_1;

		public static Action _003C_003E9__87_1;

		public static Action _003C_003E9__87_2;

		public static Comparison<KDAItem> _003C_003E9__95_0;

		public static Action _003C_003E9__106_7;

		public static Action _003C_003E9__106_13;

		public static Action _003C_003E9__111_3;

		public static Action _003C_003E9__112_3;

		public static Action _003C_003E9__123_1;

		public static Action _003C_003E9__123_2;

		internal bool _003CSetCSRankingSpecialMissionData_003Eb__84_0(uint i)
		{
			return false;
		}

		internal object _003CSetCSRankingSpecialMissionData_003Eb__84_1(uint s)
		{
			return null;
		}

		internal bool _003CSetBRRankingSpecialMissionData_003Eb__85_0(uint i)
		{
			return false;
		}

		internal object _003CSetBRRankingSpecialMissionData_003Eb__85_1(uint s)
		{
			return null;
		}

		internal void _003CSetVeteranFriendOnlineData_003Eb__87_1()
		{
		}

		internal void _003CSetVeteranFriendOnlineData_003Eb__87_2()
		{
		}

		internal int _003CSetPlayerKDADisplay_003Eb__95_0(KDAItem a, KDAItem b)
		{
			return 0;
		}

		internal void _003CSetUIData_003Eb__106_7()
		{
		}

		internal void _003CSetUIData_003Eb__106_13()
		{
		}

		internal void _003CSetUIData_003Eb__111_3()
		{
		}

		internal void _003CSetUIData_003Eb__112_3()
		{
		}

		internal void _003CSetTeammateRecommendData_003Eb__123_1()
		{
		}

		internal void _003CSetTeammateRecommendData_003Eb__123_2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public GroupInviteNtf inviteNtfData;

		public tcp.EGroup.InviteChannelType channel;

		public bool isInResultInvite;

		public Action _003C_003E9__5;

		public Action _003C_003E9__6;

		public Action _003C_003E9__7;

		public Action _003C_003E9__8;

		internal bool _003CSetUIData_003Eb__4(tcp.RankingStatsSummary a)
		{
			return false;
		}

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__5()
		{
		}

		internal void _003CSetUIData_003Eb__6()
		{
		}

		internal void _003CSetUIData_003Eb__7()
		{
		}

		internal void _003CSetUIData_003Eb__8()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}

		internal void _003CSetUIData_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_1
	{
		public List<int> difficultys;

		public string mapMode;

		public _003C_003Ec__DisplayClass101_0 CS_0024_003C_003E8__locals1;

		internal void _003CSetUIData_003Eb__3(WorkshopBasicInfo res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public RoomWorkshopHalfwayInviteNtf ntf;

		internal void _003CSetUIDataForHalfwayInvite_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public RoomInviteNtf inviteNtfData;

		public Action _003C_003E9__4;

		public Action _003C_003E9__5;

		public Action _003C_003E9__6;

		public Action _003C_003E9__10;

		public Action _003C_003E9__11;

		public Action _003C_003E9__12;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}

		internal void _003CSetUIData_003Eb__4()
		{
		}

		internal void _003CSetUIData_003Eb__5()
		{
		}

		internal void _003CSetUIData_003Eb__6()
		{
		}

		internal void _003CSetUIData_003Eb__2()
		{
		}

		internal void _003CSetUIData_003Eb__3()
		{
		}

		internal void _003CSetUIData_003Eb__8()
		{
		}

		internal void _003CSetUIData_003Eb__10()
		{
		}

		internal void _003CSetUIData_003Eb__11()
		{
		}

		internal void _003CSetUIData_003Eb__12()
		{
		}

		internal void _003CSetUIData_003Eb__9()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public EsportsCheckinNtf esportsCheckinNtf;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public int cupKey;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public int cupKey;

		public ulong teamID;

		public Action _003C_003E9__2;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__2()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public FriendAccountInfo inviteNtfData;

		public UIInvitationTipsBoxContentController _003C_003E4__this;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}

		internal void _003CSetUIData_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public FriendAccountInfo inviteNtfData;

		public UIInvitationTipsBoxContentController _003C_003E4__this;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}

		internal void _003CSetUIData_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public RecommendFriendInfo recommendFriend;

		public UIInvitationTipsBoxContentController _003C_003E4__this;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}

		internal void _003CSetUIData_003Eb__2()
		{
		}

		internal void _003CSetUIData_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public GroupJoinRequestNtf inviteNtfData;

		internal void _003CSetUIData_003Eb__0()
		{
		}

		internal void _003CSetUIData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public proto.EPresence.AccountPresence presence;

		public proto.EPresence.SocialPresence socialPresence;

		internal void _003CSetReservationUIData_003Eb__0()
		{
		}

		internal void _003CSetReservationUIData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public FriendAccountInfo friendInfo;

		internal void _003CSetNewFriendTeamUpInviteData_003Eb__0()
		{
		}

		internal void _003CSetNewFriendTeamUpInviteData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public TeammateStats stats;

		internal void _003CSetTeammateRecommendData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass143_0
	{
		public InviteSocialNtf inviteSocialNtf;

		public bool isSocialArea;

		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public ulong accountId;

		internal void _003CSetInviteToTrainingMode_003Eb__0()
		{
		}

		internal void _003CSetInviteToTrainingMode_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass148_0
	{
		public ulong veteranAccountId;

		internal bool _003CIsRoomLimit_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003CDelayRepositionPlayerKDA_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInvitationTipsBoxContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRepositionPlayerKDA_003Ed__96(int _003C_003E1__state)
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

	private sealed class _003CShowCommonFriendAndSocialLight_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInvitationTipsBoxContentController _003C_003E4__this;

		public tcp.RankingStatsSummary stats;

		private bool _003CisBr_003E5__2;

		private TeamUpRecommendConfigDesc _003Cconfig_003E5__3;

		private UITeamUpRecommendReasonItemController _003Cctrl_003E5__4;

		private List<tcp.SocialHighLight>.Enumerator _003C_003E7__wrap4;

		private UILeaderBoardTitleIconController _003CweaponTitleCtrl_003E5__6;

		private UISocialHighlightIconController _003ChighLightCtrl_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowCommonFriendAndSocialLight_003Ed__153(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIInvitationTipsBoxContentView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelInvitation m_ModelInvitation;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelMatch m_ModelMatch;

	private UIModelPrime m_ModelPrime;

	private UIPopMenuSmallControler m_RejectReasonPopMenuController;

	private List<PopMenuData> m_RejectReasonPopMenuList;

	private Action m_OnOK;

	private Action m_OnCancel;

	private Action m_OnToggle;

	private Action m_OnExpired;

	private ulong m_InviterAccountID;

	private object m_Data;

	private ulong m_InvitationExpiredCallID;

	private ulong m_CurrentExpireTimeStamp;

	public bool ShouldOut;

	public bool IsInAni;

	public bool ShouldUp;

	public ulong InvitationID;

	private float m_TimeStart;

	private ulong m_AccountID;

	private string m_NickName;

	private int m_Rank;

	private float m_RankPoints;

	private uint m_PeakRankPos;

	private bool m_HasExpired;

	private bool m_UseSpecialTitle;

	private bool m_HasNoResponse;

	private NotifyData m_NotifyData;

	private bool NeedQuitSceneEdit;

	private UICommonSocialHighlightController m_SocialHighlightCtrl;

	private UILeaderBoardTitleSingleController m_LeaderBoardTitleCtrl;

	private UIPopupMessageBoxController m_MesBoxCtrl;

	private uint m_RefuseReason;

	private List<RejectReasonData> m_RejectReasonData;

	private bool m_HasNoResponseKey;

	private GroupInviteNtf m_InviteNtfData;

	private GroupJoinRequestNtf m_GroupJoinRequestNtf;

	private uint m_TimeOutRejectIndex;

	private TeammateStats m_InviterStats;

	private ESameMatchRelationType m_SameMatchRelationType;

	private bool m_isNeedSkinModCheckPopup;

	private int m_BiggerClickMaskHeight;

	private uint m_HeadPic;

	private string m_ExternalIcon;

	private proto.EAccount.ExternalIconStatus m_ExternalIconStatus;

	private proto.EAccount.ExternalIconShowType m_ExternalIconShowType;

	private const string NICKNAMEKEY = "T_26_A_NOTI_COM";

	private const string PRIMENICKNAMEKEY = "[x1.5][S0][-]{0}";

	private const string NewFriendInviteTitleKey = "T_38_JQ_TEAM_INVITATION_PLAY";

	private const string NewFriendInviteSoloTextKey = "T_54_D_FRIENDRECOM_TEXT1";

	private const string NewFriendInviteGroupTextKey = "T_54_D_FRIENDRECOM_TEXT2";

	private const string NewFriendInviteTagKey = "T_54_D_FRIENDRECOM_TAG";

	private DLBMPCCFKKM m_ChooseMatchMode;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private uint m_AvatarFrameId;

	private bool m_ShowPrimeAvatarFrame;

	private bool m_ShowPrimeInviteBg;

	private UISprite m_CurTimeCircle;

	private UILabel m_CurTimeLabel;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	private readonly List<UIKDATagConController> m_KDATagControllers;

	private const int MAX_KDA_TAG_COUNT = 3;

	private bool m_HasSentSettlementPopupLog;

	private FriendAccountInfo m_FriendInfo;

	private bool m_ShowReasonReachLimit;

	private const uint MAX_REASON_WIDTH = 476u;

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

	private void Update()
	{
	}

	public object GetData()
	{
		return null;
	}

	public int GetRemainingTimeSeconds()
	{
		return 0;
	}

	public void UpdateRank(int rank, uint peakRankPos, bool displayCSPeakPoints = false, uint csPeakTournamentPoints = 0u, bool enableLabel2 = false, bool is_BRRank = true, bool isPrime = false, bool isInResult = false)
	{
	}

	private void UpdateTeamInfoLabel(bool show)
	{
	}

	private void OnChangeBlockPlayer()
	{
	}

	private void BeforeSetData(bool changeRejectLabel = false)
	{
	}

	public void SetData(object[] args, ulong time, bool isFirst, ulong invitationID)
	{
	}

	private void OnSpecialMissionGotoBtnClick()
	{
	}

	private void SetCSRankingSpecialMissionData(CSRankingTaskInfo taskInfo)
	{
	}

	private void SetBRRankingSpecialMissionData(RankingTaskInfo taskInfo)
	{
	}

	private void SetSpecialMissionView()
	{
	}

	private void SetVeteranFriendOnlineData(VeteranFriendOnlineNtf data)
	{
	}

	private void UpdataNickName()
	{
	}

	private void SetUIData(RoomApplyJoinNtf joinData)
	{
	}

	private TeammateStats GetInviterStatsFromLastMatch(ulong accountId, out ESameMatchRelationType relationType)
	{
		relationType = default(ESameMatchRelationType);
		return null;
	}

	private TeammateStats TryBuildStatsFromMatchPlayer(ulong accountId, ref ESameMatchRelationType relationType)
	{
		return null;
	}

	private string GetSameMatchRelationString(ESameMatchRelationType relationType)
	{
		return null;
	}

	private Color GetSameMatchRelationColor(ESameMatchRelationType relationType)
	{
		return default(Color);
	}

	private bool SetPlayerKDADisplay(TeammateStats stats)
	{
		return false;
	}

	private IEnumerator DelayRepositionPlayerKDA()
	{
		return null;
	}

	private void ClearKDATagControllers()
	{
	}

	private void SetPlayerIndexDisplay(TeammateStats stats)
	{
	}

	private void SendSettlementInvitePopupLog(ulong targetId, int opType, int teamSize)
	{
	}

	private void SetUIData(GroupInviteNtf inviteNtfData, bool isInResultInvite = false)
	{
	}

	private void OnGroupInviteOK(GroupInviteNtf inviteNtfData, tcp.EGroup.InviteChannelType channel, bool isInResultInvite = false)
	{
	}

	private void InitRefuseReason()
	{
	}

	private void SendCancleMessage(ulong accountid)
	{
	}

	private void SetUIDataForHalfwayInvite(RoomWorkshopHalfwayInviteNtf ntf)
	{
	}

	private void SetUIData(RoomInviteNtf inviteNtfData)
	{
	}

	private void SetUIData(EsportsCheckinNtf esportsCheckinNtf)
	{
	}

	private void OnRoomInviteOK(RoomInviteNtf inviteNtfData)
	{
	}

	public void SetUIData(RequestJoinCupTeamReq requestJoinCupTeamReq)
	{
	}

	public void SetUIData(InviteToCupTeamReq inviteToCupTeamReq)
	{
	}

	public void SetUIData(FriendAccountInfo inviteNtfData)
	{
	}

	public void SetUIData(AccountBriefInfo accountBriefInfo)
	{
	}

	public void SetUIData(RecommendFriendInfo recommendFriend)
	{
	}

	private void SetUIData(GroupJoinRequestNtf inviteNtfData, bool isInResultJoin = false)
	{
	}

	private proto.EPresence.AccountPresence GetFriendInfoPresence()
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	private proto.EPresence.SocialPresence GetFriendInfoSocialPresence()
	{
		return proto.EPresence.SocialPresence.AccountSocialPresence_NONE;
	}

	private FriendAccountInfo GetVeteranAccountInfo()
	{
		return null;
	}

	public void SetReservationUIData(FriendAccountInfo inviteInfo)
	{
	}

	public void SetNewFriendTeamUpInviteData(NewFriendTeamUpInviteData inviteData)
	{
	}

	private void InviteNewFriendTeamUp(FriendAccountInfo friendInfo)
	{
	}

	private void InviteNewFriendToMyGroup(FriendAccountInfo friendInfo)
	{
	}

	public void SetTeammateRecommendData(TeammateStats stats, bool isBR)
	{
	}

	private void RefuseInvite()
	{
	}

	private void RefuseInviteWithoutLog()
	{
	}

	private void AfterSetData(bool isInResultData = false)
	{
	}

	private void AfterSetInviteToSocialArea()
	{
	}

	private string GetTimeString()
	{
		return null;
	}

	private void OnClickName()
	{
	}

	private void OnClickOK()
	{
	}

	private void OnClickCancel()
	{
	}

	public void OnTipsBoxClose()
	{
	}

	private void OnClickToggle()
	{
	}

	private void AnimEvtHandler(object[] data)
	{
	}

	public void SetContentDepth(int depth)
	{
	}

	private int GetCurrentExpireLeftSeconds()
	{
		return 0;
	}

	public void PlayUpAni()
	{
	}

	private bool UpdateSocialHighlight(List<proto.SocialHighLight> socialHighlights)
	{
		return false;
	}

	private bool UpdateSocialHighlight(List<tcp.SocialHighLight> socialHighlights)
	{
		return false;
	}

	private void UpdateLeaderBoardTitle(proto.LeaderboardTitleInfo leaderboard_titles, uint peakRankPos, uint csPeakRankPos, ulong accountID, string region)
	{
	}

	private void UpdateLeaderBoardTitle(tcp.LeaderboardTitleInfo leaderboard_titles, uint peakRankPos, uint csPeakRankPos, ulong accountID, string region)
	{
	}

	private bool UpdateCommonFriend()
	{
		return false;
	}

	private void SetInviteToTrainingMode(InviteSocialNtf inviteSocialNtf, bool isSocialArea)
	{
	}

	private void InitTipsBoxForGroupInvitation()
	{
	}

	private void GenerateRejectReasonFilterData()
	{
	}

	private void OnStateSelect(object obj)
	{
	}

	private void InviteVeteranFriend()
	{
	}

	private bool IsRoomLimit()
	{
		return false;
	}

	private void UpdateHeadPic()
	{
	}

	private void RefreshPrime(tcp.PrimePrivilegeDetail primeInfo, ref uint primeLevel, ref bool hasBadgePrivilege)
	{
	}

	private void RefreshPrime(proto.PrimePrivilegeDetail primeInfo, ref uint primeLevel, ref bool hasBadgePrivilege)
	{
	}

	private void RefreshPrimeAvatarFrame()
	{
	}

	private IEnumerator ShowCommonFriendAndSocialLight(tcp.RankingStatsSummary stats)
	{
		return null;
	}

	private void CheckShowMaxLimit(UIBaseController ctrl)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void RefreshPrivilegeIcon(BadgeInfoLobby badgeInfo, uint role, uint primeLevel, bool hasBadgePrivilege)
	{
	}

	private void _003CSetCSRankingSpecialMissionData_003Eb__84_2()
	{
	}

	private void _003CSetBRRankingSpecialMissionData_003Eb__85_2()
	{
	}

	private void _003CSetSpecialMissionView_003Eb__86_0()
	{
	}

	private void _003CSetVeteranFriendOnlineData_003Eb__87_0()
	{
	}

	private void _003CSetUIData_003Eb__89_0()
	{
	}

	private void _003CSetUIData_003Eb__89_1()
	{
	}

	private void _003CAfterSetData_003Eb__126_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
