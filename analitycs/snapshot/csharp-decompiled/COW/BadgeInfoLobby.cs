using proto;
using tcp;

namespace COW;

public class BadgeInfoLobby
{
	public BadgeType BadgeType;

	public uint SubType;

	public BadgeInfoLobby()
	{
	}

	public BadgeInfoLobby(BadgeType badgeType, uint subType)
	{
	}

	public static implicit operator BadgeInfoLobby(proto.BadgeInfo badgeInfo)
	{
		return null;
	}

	public static implicit operator BadgeInfoLobby(tcp.BadgeInfo badgeInfo)
	{
		return null;
	}
}
