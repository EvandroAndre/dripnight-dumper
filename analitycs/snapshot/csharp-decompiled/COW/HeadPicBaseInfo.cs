using System;
using proto;

namespace COW;

public class HeadPicBaseInfo : CollectionBaseInfo, IComparable<HeadPicBaseInfo>
{
	public uint headpic_id;

	public HeadPicData headpic_data;

	public Item headpic_item;

	public HeadPicBaseInfo(uint headpicId)
	{
	}

	public static implicit operator HeadPicBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator HeadPicBaseInfo(HeadPicData pd)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(HeadPicBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
