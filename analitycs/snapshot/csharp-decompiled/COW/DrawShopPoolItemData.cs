using proto;

namespace COW;

public class DrawShopPoolItemData
{
	public uint DrawShopId;

	public uint PoolItemId;

	public EInventory.AwardType RewardItemType;

	public uint ItemId;

	public uint ItemNum;

	public uint ItemDuration;

	public EDrawShop.RareType RareItem;

	public float BaseProbability;

	public bool IsRemove;

	public EDrawShopItemViewStage ViewStage;

	public uint OwnedChangeItemType;

	public uint OwnedChangeItemId;

	public uint OwnedChangeItemNum;
}
