using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class FriendInfo : IComparable<FriendInfo>, IEqualityComparer<FriendInfo>
{
	public ulong m_AccountId;

	public uint m_Level;

	public string m_Name;

	public string m_PortraitUrl;

	public uint m_Banner;

	public uint m_HeadPic;

	public proto.EPresence.AccountPresence m_OnlineStatus;

	public bool m_IsSelected;

	public bool m_IsMeetCondition;

	public bool m_IsFavor;

	public bool m_IsConfidant;

	public UIToggleButton m_UIToggleBtn;

	public string m_Reason;

	public EGiftStore_BuddyType m_BuddyType;

	public string m_Region;

	public string m_ExternalIcon;

	public proto.EAccount.ExternalIconStatus m_ExternalIconStatus;

	public proto.EAccount.ExternalIconShowType m_ExternalIconShowType;

	public uint m_FriendIntimacyValue;

	public bool m_PrimeGiftSend;

	public List<uint> m_ShowPrimePri;

	public static implicit operator FriendInfo(FriendAccountInfo accountInfo)
	{
		return null;
	}

	public static implicit operator FriendInfo(ClanMember memberInfo)
	{
		return null;
	}

	public static implicit operator FriendInfo(GroupMemberInfo memberInfo)
	{
		return null;
	}

	public static implicit operator FriendInfo(TeammateStats memberInfo)
	{
		return null;
	}

	public int CompareTo(FriendInfo other)
	{
		return 0;
	}

	public bool Equals(FriendInfo x, FriendInfo y)
	{
		return false;
	}

	public int GetHashCode(FriendInfo obj)
	{
		return 0;
	}
}
