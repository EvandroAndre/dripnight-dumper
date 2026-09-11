using proto;

namespace COW;

public class CustomCDNItemInfo : BaseItemInfo
{
	public string cdn_url;

	public string small_cdn_url;

	public CustomCDNItemInfo()
		: base(EInventory.AwardType.AwardType_NONE, 0u)
	{
	}

	public CustomCDNItemInfo(ESpecialItemWithoutDataType type, uint count)
		: base(EInventory.AwardType.AwardType_NONE, 0u)
	{
	}

	public static implicit operator CustomCDNItemInfo(RelayMartShopDesc relayMartStoreItemDesc)
	{
		return null;
	}
}
