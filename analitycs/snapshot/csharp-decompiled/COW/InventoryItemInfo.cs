using System;
using GCommon;
using proto;

namespace COW;

public class InventoryItemInfo : BaseItemInfo, IComparable<InventoryItemInfo>
{
	public CSSharedItemData itemData;

	public Item protoItem;

	public bool IsNewOwned;

	public uint iID;

	public InventoryItemInfo(Item it)
		: base(EInventory.AwardType.AwardType_NONE, 0u)
	{
	}

	public static implicit operator InventoryItemInfo(Item it)
	{
		return null;
	}

	public static implicit operator CSVBaseData(InventoryItemInfo info)
	{
		return null;
	}

	public int CompareTo(InventoryItemInfo other)
	{
		return 0;
	}
}
