using System;
using System.Collections.Generic;
using message;
using proto;
using tcp;

namespace COW;

public class FriendAccountInfo : IComparable<FriendAccountInfo>, IGameAssistItemData
{
	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public FriendAccountInfo _003C_003E4__this;

		public FriendAccountInfo other;

		internal bool _003CCompareTo_003Eb__0(TeamMemberWithAccountInfo e)
		{
			return false;
		}

		internal bool _003CCompareTo_003Eb__1(TeamMemberWithAccountInfo e)
		{
			return false;
		}
	}

	private static readonly Dictionary<uint, int> AccountPresenceSortOrder;

	public ulong account_id;

	public uint account_type;

	public string nickname;

	public uint level;

	public uint exp;

	public proto.EPresence.AccountPresence presence;

	public proto.EPresence.SocialPresence socialPresence;

	public proto.EPresence.AccountCraftLandEditStatus craftlandPresence;

	public NIKKALKPIBO presenceGameMode;

	public DLBMPCCFKKM presenceMatchMode;

	public uint presenceMapID;

	public string external_id;

	public ulong external_platform_id;

	public string workshop_code;

	public string workshop_map;

	public uint external_type;

	public EAccountAdscription account_adscription;

	public string external_name;

	public string portrait;

	public string region;

	public ulong groupId;

	public double solo_score;

	public double duo_score;

	public double quad_score;

	public AccountInfoWithStats solo_stats_ranking;

	public AccountInfoWithStats duo_stats_ranking;

	public AccountInfoWithStats quad_stats_ranking;

	public AccountInfoWithStats solo_stats_casual;

	public AccountInfoWithStats duo_stats_casual;

	public AccountInfoWithStats quad_stats_casual;

	public AccountInfoWithStats cs_stats;

	public bool is_friend;

	public uint friend_intimacy;

	public uint rank;

	public uint ranking_points;

	public uint peak_rank_pos;

	public uint csrank;

	public uint csranking_points;

	public uint cspeak_rank_pos;

	public uint periodic_rank;

	public uint periodic_ranking_points;

	public uint hippo_rank;

	public uint hippo_ranking_points;

	public uint hippo_total_profit;

	public uint hippo_total_worth;

	public string clan_name;

	public ulong clan_id;

	public ulong championship_team_id;

	public string championship_team_name;

	public uint championship_team_member_num;

	public uint banner_id;

	public uint headpic_id;

	public uint pin_id;

	public uint title_id;

	public uint ep_badgeId;

	public bool is_ep;

	public uint ep_badge_count;

	public bool ShowRank;

	public bool ShowCSRank;

	public bool ShowBRRank;

	public bool ShowCSPeakTournamentRank;

	public uint cs_peak_tournament_rank_pos;

	public uint cs_peak_points;

	public long LastLoginAt;

	public uint Role;

	public bool FriendSpectateDisable;

	public bool isCommonFriend;

	public bool isClanmate;

	public bool isRecentMate;

	public bool is_cs_ranking_ban;

	public Dictionary<uint, uint> LimitedTimeRankScore;

	public uint friendNumInSameChampionshipTeam;

	public long updateTime;

	public long createTime;

	public uint veteranTag;

	public EAttendance.PreVeteranActionType preVeteranType;

	public proto.ESocial.Gender gender;

	public proto.ESocial.Language language;

	public proto.ESocial.ModePrefer modePrefer;

	public proto.ESocial.TimeActive timeActive;

	public List<proto.SocialHighLight> social_highlights;

	public proto.SocialHighLight br_social_highlight;

	public proto.SocialHighLight cs_social_highlight;

	public proto.SocialHighLight common_social_highlight;

	public proto.LeaderboardTitleInfo leaderboard_title;

	public ulong RoomID;

	public uint RoomType;

	public uint RoomMember;

	public uint RoomMaxMember;

	public uint social_status;

	public bool isOnlyId;

	public uint group_member_cnt;

	public uint group_mode;

	public bool HalfwayJoinEnabled;

	public tcp.EGroup.PlayerDisplayState display_state;

	public ERecommandReason recommand_reason;

	public uint priority;

	public List<proto.HuntingGroundLikePVEInfo> HGSnowRecords;

	public string externalIcon;

	public proto.EAccount.ExternalIconStatus externalIconStatus;

	public proto.EAccount.ExternalIconShowType externalIconShowType;

	public string releaseVersion;

	public ulong veteranExpireTime;

	public uint friendIntimacyValue;

	public bool membership_state;

	public proto.BadgeInfo equipBadgeInfo;

	public proto.PrimePrivilegeDetail primeInfo;

	public proto.WorkshopAccountSummaryInfo workshop_summary_info;

	public uint avatarFrameID;

	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	private bool m_HasRead;

	public bool HasAddDataToRead;

	private bool m_NeedHideLine;

	public string ReleaseVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HasRead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ELobbyAssistDataType SubType
	{
		get
		{
			return ELobbyAssistDataType.None;
		}
		set
		{
		}
	}

	public bool NeedHideLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong Assist_Id
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public FriendAccountInfo()
	{
	}

	public FriendAccountInfo(ulong id, bool friend_flag)
	{
	}

	public void CopyFromAccountInfoWithPresence(AccountInfoWithPresence info)
	{
	}

	private void ProcessSocialHighlight(List<proto.SocialHighLight> socialhighlights)
	{
	}

	private AccountInfoWithStats CreateEmptyAccountInfoStats()
	{
		return null;
	}

	public void CopyFromBaseProfileInfo(BaseProfileInfo info)
	{
	}

	public void CopyFromAccountInfoBasic(AccountInfoBasic info)
	{
	}

	public void SetSocialInfo(SocialBasicInfo info)
	{
	}

	public void SetRecommandReson(ERecommandReason recommandReason)
	{
	}

	public int CompareTo(FriendAccountInfo other)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public Dictionary<uint, int> GetAccountPresenceSortOrder()
	{
		return null;
	}

	public bool CheckAssistStateIsFit(bool checkNewMessage)
	{
		return false;
	}

	public bool CheckCanAddToList()
	{
		return false;
	}

	public void AddDataToViewList(uint index, List<IGameAssistItemData> list)
	{
	}

	public bool InSceneEdit()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}
}
