using System;
using proto;

namespace COW;

public class FriendReunionInviterData : IComparable
{
	private ulong m_AccoutnID;

	private FriendAccountInfo m_AccountInfo;

	private AccountInfoBasic m_AccountInfoNotFriend;

	private ulong m_InviteTime;

	private bool m_IsBind;

	public FriendAccountInfo AccountInfo => null;

	public AccountInfoBasic AccountInfoNotFriend => null;

	public ulong AccountID => 0uL;

	public ulong InviteTime => 0uL;

	public bool IsBind => false;

	public FriendReunionInviterData(FriendAccountInfo accountInfo, ulong id, ulong inviteTime, bool isBind, AccountInfoBasic accountInfoNotFriend)
	{
	}

	public int CompareTo(object obj)
	{
		return 0;
	}
}
