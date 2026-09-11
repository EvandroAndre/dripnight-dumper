using proto;

namespace COW;

public class InventoryClothInfo : InventoryItemInfo
{
	public AvatarWardrobeData wardrobeData;

	public InventoryClothInfo(Item it)
		: base(null)
	{
	}

	public static implicit operator InventoryClothInfo(Item it)
	{
		return null;
	}
}
