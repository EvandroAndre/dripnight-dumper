using GCommon;
using proto;

namespace COW;

public class BaseItemInfo
{
	public static BaseItemInfo[] EmptyArray;

	public uint m_ID;

	public string m_Name;

	public int m_Type;

	public ResourceID m_IconRes;

	public ResourceID m_BigIconRes;

	public uint m_Count;

	public EInventory.ItemStatus m_Status;

	public uint m_DeltaTime;

	public bool m_HideDeltaTime;

	public uint m_Quality;

	public string m_Description;

	public bool m_IsBigEventBadge;

	public bool m_IsLinkDebris;

	public uint m_PermanentValue;

	public bool m_IsReward;

	public bool m_IsLikeItem;

	public bool m_IsBoxTag;

	public bool m_IsBundleTag;

	public ItemUtil.ItemShareType m_ShareType;

	public bool m_ShowExtraContent;

	public ESpecialItemWithoutDataType m_SpecialItemType;

	public string m_PreviewCDNUrl;

	public uint m_LaunchTagSerialNumber;

	public uint m_GachaShowItemId;

	public bool m_ShowItemCount;

	public string m_FullScreenPreviewCDNUrl;

	public ResourceID m_FullScreenPreviewBGVFXRes;

	public static implicit operator BaseItemInfo(AwardDesc awardItem)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(CSLuckyWheelShopItemDesc awardItem)
	{
		return null;
	}

	public BaseItemInfo(EInventory.AwardType type, uint quantity)
	{
	}

	public BaseItemInfo(uint quality, ResourceID resourceID, string name)
	{
	}

	public BaseItemInfo(ESpecialItemWithoutDataType type, uint count)
	{
	}

	public BaseItemInfo(uint itemID, EInventory.AwardType type, uint count, uint effectTime = 0u)
	{
	}

	public BaseItemInfo()
	{
	}

	public static implicit operator BaseItemInfo(GachaShowItem item)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(DrawShopPoolItemData item)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(Item item)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(BundleShowData awardItem)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(OptionalBundleShowData awardItem)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(TreasureBoxShowData awardItem)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(StoreDesc storeDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(MysteryPoolStoreItem storeDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(DiscountStoreDesc discountDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(StarterStoreItemDesc starterStoreDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(PrimeStoreItemDesc primeStoreDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(VeteranStoreDesc VeteranStoreDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(GiftItem giftItem)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(FlashStoreGoodsDesc exchangeItemDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(ExchangeStoreItemDesc exchangeItemDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(ClanDiamondAwardSettingDesc awardDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(RelayMartShopDesc relayMartStoreItemDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(PetInfo petData)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(BigEventStoreCommodityDesc commodityDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(WeaponSkinUpdateItemDesc weaponSkinItemDesc)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(ChestSpecialExchangeDesc awardItem)
	{
		return null;
	}

	public static implicit operator BaseItemInfo(DrawShopWheelExchangeDesc exchangeDesc)
	{
		return null;
	}

	public bool IsGold()
	{
		return false;
	}

	public bool IsGem()
	{
		return false;
	}

	public bool IsExp()
	{
		return false;
	}

	public bool IsLink()
	{
		return false;
	}

	public bool IsHippoCrisisItem()
	{
		return false;
	}

	public string GetName()
	{
		return null;
	}

	public uint GetCount()
	{
		return 0u;
	}

	public string GetDescription()
	{
		return null;
	}

	public void SetGemId()
	{
	}

	public void SetGoldId()
	{
	}

	public void SetExpId()
	{
	}

	public BaseItemInfo DeepCopy()
	{
		return null;
	}
}
