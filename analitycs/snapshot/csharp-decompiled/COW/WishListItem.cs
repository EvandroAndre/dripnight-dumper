using proto;

namespace COW;

public class WishListItem
{
	public CSSharedItemData itemData;

	private BaseItemInfo m_baseItemInfo;

	public uint addToWishListTimeStamp;

	private bool isHadFindGiftItem;

	public GiftItem m_giftItem;

	public BaseItemInfo baseItemInfo => null;

	public GiftItem giftItem => null;
}
