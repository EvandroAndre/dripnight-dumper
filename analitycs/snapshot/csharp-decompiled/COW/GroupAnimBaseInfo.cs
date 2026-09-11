using System;
using proto;

namespace COW;

public class GroupAnimBaseInfo : CollectionBaseInfo, IComparable<GroupAnimBaseInfo>
{
	public GroupAnimData group_anim_data;

	public GroupAnimBaseInfo(uint itemid)
	{
	}

	public static implicit operator GroupAnimBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator GroupAnimBaseInfo(EmoteData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(GroupAnimBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
