using System;
using System.Collections.Generic;
using message;
using proto;

namespace COW;

public class ClanMember : IComparable<ClanMember>
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ClanMember _003C_003E4__this;

		public ClanMember other;

		internal bool _003CCompareTo_003Eb__0(TeamMemberWithAccountInfo e)
		{
			return false;
		}

		internal bool _003CCompareTo_003Eb__1(TeamMemberWithAccountInfo e)
		{
			return false;
		}
	}

	public BaseProfileInfo m_AccountInfo;

	public EClanRole m_Role;

	public EPresence.AccountPresence m_Status;

	public ulong m_JoinAt;

	public uint m_WeekActiveness;

	public uint m_PersonalWeekActiveness;

	public uint m_TotalActiveness;

	public uint m_WeekClanWar;

	public uint m_TotalClanWarPoint;

	public uint m_InvitePriority;

	public List<TimeRange> m_PrivilegeTimeRangeList;

	public static implicit operator ClanMember(ClanMemberWithAccountInfo data)
	{
		return null;
	}

	private static void ProcessSocialHighlight(ClanMember member, List<SocialHighLight> socialhighlights)
	{
	}

	public void SetPresenceStatus(uint presence, ulong groupId, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_NONE, NIKKALKPIBO gameMode = NIKKALKPIBO.EGAMEMODE_NONE, uint mapID = 0u, uint groupMemberCnt = 0u, uint groupMode = 2147483647u, uint socialstatus = 0u)
	{
	}

	public int CompareTo(ClanMember other)
	{
		return 0;
	}
}
