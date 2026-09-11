using System;

namespace COW;

public class FriendAccountInfoData : IComparable<FriendAccountInfoData>
{
	public FriendAccountInfo info;

	public bool IsShowClanIcon;

	public int CompareTo(FriendAccountInfoData other)
	{
		return 0;
	}
}
