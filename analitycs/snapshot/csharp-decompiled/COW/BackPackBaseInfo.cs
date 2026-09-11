using System;
using proto;

namespace COW;

public class BackPackBaseInfo : CollectionBaseInfo, IComparable<BackPackBaseInfo>
{
	public BackPackData backpack_data;

	public BackPackBaseInfo(uint backpackId)
	{
	}

	public static implicit operator BackPackBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator BackPackBaseInfo(BackPackData backpack)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(BackPackBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
