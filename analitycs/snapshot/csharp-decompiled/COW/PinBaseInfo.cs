using System;
using proto;

namespace COW;

public class PinBaseInfo : CollectionBaseInfo, IComparable<PinBaseInfo>
{
	public PinData pin_data;

	public PinBaseInfo(uint itemid)
	{
	}

	public static implicit operator PinBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator PinBaseInfo(PinData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(PinBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
