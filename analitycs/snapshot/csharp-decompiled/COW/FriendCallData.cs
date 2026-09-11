using System;

namespace COW;

public class FriendCallData : IComparable
{
	private bool m_HasBeenInvited;

	private ulong m_AccoutnID;

	private FriendAccountInfo m_AccountInfo;

	private string m_LastLoginTime;

	public FriendAccountInfo AccountInfo => null;

	public ulong AccountID => 0uL;

	public bool HasBeenInvited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string LastLoginTime => null;

	public FriendCallData(FriendAccountInfo accountInfo, ulong id, bool hasBeenInvited)
	{
	}

	public int CompareTo(object obj)
	{
		return 0;
	}
}
