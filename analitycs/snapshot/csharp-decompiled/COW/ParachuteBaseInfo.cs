using System;
using proto;

namespace COW;

public class ParachuteBaseInfo : CollectionBaseInfo, IComparable<ParachuteBaseInfo>
{
	public ParachuteData parachute_data;

	public ParachuteBaseInfo(uint itemid)
	{
	}

	public static implicit operator ParachuteBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator ParachuteBaseInfo(ParachuteData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(ParachuteBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
