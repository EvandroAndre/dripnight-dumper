using System;

namespace COW;

public class CallBackFriendData : IComparable
{
	private ulong m_AccoutnID;

	private FriendAccountInfo m_AccountInfo;

	private CallBackFriendType m_Type;

	public FriendAccountInfo AccountInfo => null;

	public ulong AccountID => 0uL;

	public CallBackFriendType Type
	{
		get
		{
			return CallBackFriendType.None;
		}
		set
		{
		}
	}

	public CallBackFriendData(FriendAccountInfo accountInfo, ulong id, CallBackFriendType type)
	{
	}

	public int CompareTo(object obj)
	{
		return 0;
	}
}
