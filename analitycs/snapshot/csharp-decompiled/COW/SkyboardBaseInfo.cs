using System;
using proto;

namespace COW;

public class SkyboardBaseInfo : CollectionBaseInfo, IComparable<SkyboardBaseInfo>
{
	public SkyboardData skyboard_data;

	public SkyboardBaseInfo(uint itemid)
	{
	}

	public static implicit operator SkyboardBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator SkyboardBaseInfo(SkyboardData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(SkyboardBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
