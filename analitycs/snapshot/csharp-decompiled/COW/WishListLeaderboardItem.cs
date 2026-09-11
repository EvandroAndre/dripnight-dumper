namespace COW;

public class WishListLeaderboardItem
{
	public uint ItemId;

	public uint ChangeCnt;

	public uint Rank;

	public CSSharedItemData ItemData;

	public ItemChannelInfo ItemChannelInfo;

	public WishListLeaderboardObtainState ObtainState;

	private BaseItemInfo m_BaseItemInfo;

	public BaseItemInfo BaseItemInfo => null;
}
