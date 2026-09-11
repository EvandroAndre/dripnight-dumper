using System.Collections.Generic;
using proto;

namespace COW;

public class ClanInfo
{
	public ulong m_ClanID;

	public string m_ClanName;

	public uint m_ClanLevel;

	public uint m_ClanMemberNum;

	public uint m_ClanScale;

	public uint m_ExtendTimes;

	public string m_ClanSlogan;

	public string m_ClanRegion;

	public uint m_LimitLevel;

	public uint m_LimitRank;

	public uint m_LimitCSRank;

	public string m_CaptainName;

	public string m_ClanAnnouncement;

	public ulong m_CreateDate;

	public ulong CaptainID;

	public ulong[] ViceCaptainID;

	public uint m_HonorPoint;

	public uint m_HonorPointAreaID;

	public uint m_EntryType;

	public uint m_RacePoint;

	public ulong m_ClaimRPAwardAt;

	public uint m_AreaID;

	public uint m_PlayStyle;

	public ulong m_DeputyCaptainID;

	public uint m_ClanBadgeID;

	public List<UnlockedClanBadgeInfo> m_UnlockClanBadgeInfo;

	public uint m_FrameId;

	public bool m_UseCustomBadge;

	public string m_CustomBadge;

	public uint m_TotalActiveness;

	public uint m_WeeklyActiveness;

	public uint m_PreClanLevel;

	public uint m_ClanWeekId;

	public uint m_Priority;

	public ulong m_LastBuyPromoTime;

	public List<uint> m_Tags;

	public uint m_SerialInactiveNum;

	public bool m_IsCertification;

	public GuildWarTitleInfo m_BestTitle;

	public GuildWarTitleInfo m_EquipedTitle;

	public ulong m_NotcieRefreshTime;

	public uint m_HidtoryBadgeId;

	public uint m_LastWeekGainedActiveness;

	public long m_LastWeekStartTime;

	public long m_LastWeekEndTime;

	public long m_PrivilegeExpireAt;

	public bool m_PrivilegeClaimed;

	public GuildWarHackerPunishmentInfo m_ClanWarHackerPunishment;

	public static implicit operator ClanInfo(proto.ClanInfo data)
	{
		return null;
	}

	private static uint GetExtendTimeFromMiscellaneous(string misc)
	{
		return 0u;
	}

	public bool IsDuringPromotion()
	{
		return false;
	}
}
