using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelRecruit : UIBaseModel
{
	public enum ERecruitSource
	{
		Update,
		RecruitEntrance,
		BannedTrioRank,
		NewbieOneKeyRecruit
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GroupRecruitTeamInfo> _003C_003E9__87_0;

		public static Predicate<GroupRecruitTeamInfo> _003C_003E9__87_1;

		internal int _003CProcessRecruitListData_003Eb__87_0(GroupRecruitTeamInfo info, GroupRecruitTeamInfo teamInfo)
		{
			return 0;
		}

		internal bool _003CProcessRecruitListData_003Eb__87_1(GroupRecruitTeamInfo teamInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public Action success;

		public Action cancel;

		internal void _003CJoinRoomRecruiSecondConfirm_003Eb__0()
		{
		}

		internal void _003CJoinRoomRecruiSecondConfirm_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public UIModelGroup modelGroup;

		internal bool _003CCanShowNoticeChangeTeam_003Eb__0(GroupMemberInfo member)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public UIModelRecruit _003C_003E4__this;

		public ulong groupId;

		public string recruitCode;

		internal void _003CRefreshRecruitHangupReportState_003Eb__0()
		{
		}
	}

	public NewRecruitFilterInfo NewRecruitFilterInfo;

	private NewRecruitReqInfo m_NewRecruitReqInfo;

	public GroupRecruitNtf RecruitInfo;

	private RecruitVarDesc m_RecruitVarDesc;

	private uint m_MaxRecruitTagNum;

	private SortedDictionary<uint, NewTeamLabelDesc> m_RecruitTeamLabelDict;

	private NewTeamLabelDesc m_DefaultRecruitTeamLabelDesc;

	public ulong LastManualRefreshTs;

	public ulong LastGetRecruitListTs;

	public bool AutoReqRecruitListSuccess;

	public bool ManualReqRecruitListSuccess;

	public bool AutoReqRoomRecruitListSuccess;

	public bool ManualReqRoomRecruitListSuccess;

	public bool CanClickQuickJoin;

	public bool OpenQuickJoin;

	public bool OpenInTeamQuickJoin;

	public bool NeedNoticeRecruit;

	public bool NeedTopShowSelfRecruitInList;

	private uint m_RecruitHangupReportDelayCallID;

	private ulong m_RecruitHangupReportGroupId;

	private string m_RecruitHangupReportCode;

	private ulong m_LastRecruitHangupReportGroupId;

	private string m_LastRecruitHangupReportCode;

	private long m_AccountRecruitBanExpireTs;

	private bool m_PendingNoticeChangeTeamReadyTrigger;

	private bool m_HasNoticeChangeTeamReadyTrigger;

	private bool m_HasLoggedNoticeChangeTeamInCurrentGroup;

	private bool m_HasEnteredCurrentGroupByRecruit;

	private bool m_IsNoticeChangeTeamQuickJoinCD;

	private float m_NoticeChangeTeamQuickJoinEndTime;

	private bool m_IsOpenNewRecruit;

	public uint RecruitManualRefreshCD;

	public uint RecruitAutoRefreshCD;

	public uint RecruitClientFilterCD;

	public List<ulong> LastRefreshGroupIds;

	public List<GroupRecruitTeamInfo> LastShowRecruitTeamInfoList;

	private List<GroupRecruitTeamInfo> m_GroupRecruitTeamInfoList;

	private RecruitRoomInfo m_RecruitRoomInfo;

	private List<RecruitRoomInfo> m_RecruitRoomInfoList;

	private List<ulong> m_LastRefreshRoomIds;

	private List<RecruitRoomInfo> m_LastShowRoomRecruitTeamInfoList;

	private bool m_IsCustomRoomMode;

	public NewRecruitReqInfo NewRecruitReqInfo => null;

	public List<GroupRecruitTeamInfo> GroupRecruitTeamInfoList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RecruitVarDesc RecruitVarDesc => null;

	public float AFKJudgmentTime => 0f;

	public float NoticeChangeTeamWaitTime => 0f;

	public float NoticeChangeTeamQuickJoinCDTime => 0f;

	public uint MaxRecruitTagNum => 0u;

	public bool IsOpenNewRecruit => false;

	public bool IsNoticeChangeTeamQuickJoinCD => false;

	public bool HasNoticeChangeTeamReadyTrigger => false;

	public int NoticeChangeTeamQuickJoinCDSecond => 0;

	public RecruitRoomInfo RecruitRoomInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ulong> LastRefreshRoomIds
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<RecruitRoomInfo> RecruitRoomInfoList => null;

	public List<RecruitRoomInfo> LastShowRoomRecruitTeamInfoList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsCustomRoomMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetNewRecruitFilterInfo(bool isAllMode, bool openMapBonus, uint gameMode, uint matchMode, uint groupMode, uint eventId, uint minRank, uint[] tags)
	{
	}

	public void SetNewRecruitReqInfo(uint minRank, uint maxRank, bool openMapBonus, uint[] groupTags, uint specialModeEventId, bool sendWorld, bool sendGuild, bool sendNewbie = false)
	{
	}

	public bool CanShowNoticeChangeTeam(bool checkQuickJoinClick = true)
	{
		return false;
	}

	public bool RefreshNoticeChangeTeamReadyTrigger(bool readyChanged, bool ready, bool isGroupLeader)
	{
		return false;
	}

	public bool CanStartNoticeChangeTeamReadyTrigger()
	{
		return false;
	}

	public void MarkNoticeChangeTeamFirstTriggerShown()
	{
	}

	public void ResetNoticeChangeTeamReadyTrigger()
	{
	}

	public bool TryMarkNoticeChangeTeamRecruitGroup()
	{
		return false;
	}

	public void ResetNoticeChangeTeamRecruitGroup()
	{
	}

	private void ResetNoticeChangeTeamDisplayTrigger()
	{
	}

	public void StartNoticeChangeTeamQuickJoinCD()
	{
	}

	public void StopNoticeChangeTeamQuickJoinCD(bool resetQuickJoin)
	{
	}

	private bool IsNoticeChangeTeamQuickJoinChannelWhitelisted()
	{
		return false;
	}

	private bool IsRecruitChannelWhitelisted(tcp.EGroup.InviteChannelType channelType)
	{
		return false;
	}

	public void RefreshRecruitHangupReportState()
	{
	}

	private bool CanReportRecruitHangup(out ulong groupId, out string recruitCode)
	{
		groupId = default(ulong);
		recruitCode = null;
		return false;
	}

	private void RequestRecruitHangupReport(ulong groupId, string recruitCode)
	{
	}

	private void CancelRecruitHangupReportDelay()
	{
	}

	public void ProcessAccountRecruitBannedNtf(AccountRecruitBannedNtf ntf)
	{
	}

	public bool CheckAccountRecruitBanAndShowTips()
	{
		return false;
	}

	private bool IsAccountRecruitBanned()
	{
		return false;
	}

	private void ShowAccountRecruitBannedTips()
	{
	}

	private int GetAccountRecruitBanRemainingMinutes()
	{
		return 0;
	}

	public void ProcessRecruitReqInfoData(uint gameMode, uint matchMode)
	{
	}

	public void ProcessRecruitListData(List<GroupRecruitTeamInfo> recruitTeamInfos, tcp.EGroup.RecruitListType recruitListType)
	{
	}

	public void ClearNewRecruitData()
	{
	}

	public SortedDictionary<uint, NewTeamLabelDesc> GetRecruitTeamLabelDict()
	{
		return null;
	}

	public NewTeamLabelDesc GetDefaultRecruitTeamLabelDesc()
	{
		return null;
	}

	public NewTeamLabelDesc GetTeamLabelDescById(uint labelId)
	{
		return null;
	}

	public void ProcessRecruitVarDesc(RecruitVarDesc recruitVarDesc)
	{
	}

	public void ProcessRecruitTeamLabelDesc(List<NewTeamLabelDesc> labelDescs)
	{
	}

	public void RequestRecruit(ulong groupId, uint minRank, uint maxRank, uint[] groupTags, bool mapBonus = false, uint specialEventId = 0u, bool sendWorld = false, bool sendGuild = false, ERecruitSource source = ERecruitSource.RecruitEntrance, bool sendNewbie = false)
	{
	}

	public void RequestGetRecruitInfo(ulong groupId)
	{
	}

	public void RequestStopRecruit(ulong groupId)
	{
	}

	public RecruitPlayerBasicInfo GetRecruitPlayerBasicInfo()
	{
		return null;
	}

	public void RequestGetRecruitList(tcp.EGroup.RecruitListType type, bool openMapBonus, EMatch.GameMode gameMode, EMatch.MatchMode matchMode, EMatch.GroupMode groupMode, uint brRank, uint csRank, uint csPeakRank, uint minRank, uint specialModeEventId, bool isAllMode, ulong[] groupIds = null)
	{
	}

	public void RequestQuickJoin(ulong groupId, bool openMapBonus, EMatch.GameMode gameMode, EMatch.MatchMode matchMode, EMatch.GroupMode groupMode, uint brRank, uint csRank, uint csPeakRank, uint[] teamTags, uint specialEventModeId, bool isAllMode, tcp.EGroup.InviteChannelType channelType = tcp.EGroup.InviteChannelType.InviteChannelType_RECRUIT)
	{
	}

	public uint[] GetOccupationIdsByRecuritTagId(uint[] tags)
	{
		return null;
	}

	public uint GetOccupationIdByRecuritTagId(uint tag)
	{
		return 0u;
	}

	public void DebugLog(string msg)
	{
	}

	public void TryShowRecruitView()
	{
	}

	public void RequestRoomRecruit(ulong roomId, tcp.ERoom.Type roomType, bool sendWorld, bool sendGuild)
	{
	}

	public void RequestRoomRecruitList(tcp.ERoom.Type roomType, uint level, ulong[] roomIdList = null, tcp.ERoom.RecruitListType listType = tcp.ERoom.RecruitListType.RecruitListType_AUTO_REFRESH, bool isAllMode = false)
	{
	}

	public void RequestStopRoomRecruitReq(ulong roomId, tcp.ERoom.Type roomType)
	{
	}

	public void RequestRoomRecruitReqInfo(ulong roomId, tcp.ERoom.Type roomType)
	{
	}

	public void ProcessRoomRecruitListData(List<RecruitRoomInfo> rooms, tcp.ERoom.RecruitListType recruitListType)
	{
	}

	public void ClearRoomRecruitData()
	{
	}

	public void JoinRoomRecruiSecondConfirm(Action success, Action cancel, string recruitNickName)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
