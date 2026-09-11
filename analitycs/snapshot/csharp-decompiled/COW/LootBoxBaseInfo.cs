using System;
using proto;

namespace COW;

public class LootBoxBaseInfo : CollectionBaseInfo, IComparable<LootBoxBaseInfo>
{
	public LootBoxData lootbox_data;

	public LootBoxBaseInfo(uint lootboxId)
	{
	}

	public static implicit operator LootBoxBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator LootBoxBaseInfo(LootBoxData box)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(LootBoxBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
