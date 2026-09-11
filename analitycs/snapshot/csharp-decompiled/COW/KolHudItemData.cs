using System.Collections.Generic;
using proto;

namespace COW;

public class KolHudItemData
{
	public ulong AccountId;

	public string NickName;

	public uint HeadPic;

	public uint AvatarFrame;

	public uint HudIndex;

	public string Title;

	public string Description;

	public List<uint> TagList;

	public long LikesNum;

	public bool FakeHud;

	public bool HasLiked;

	public BadgeInfo BadgeInfo;

	public ExternalIconInfo ExternalIconInfo;

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
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
