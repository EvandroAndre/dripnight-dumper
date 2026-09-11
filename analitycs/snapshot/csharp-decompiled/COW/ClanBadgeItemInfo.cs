namespace COW;

public class ClanBadgeItemInfo
{
	public uint IsDefault;

	public uint UnLockCdt;

	public uint BadgeID;

	public uint UnlockCdtValue;

	public ClanBadgeType BadgeType;

	public ClanIconType ClanIconType;

	public string BadgeName;

	public string BadgeGetWay;

	public string SpriteName;

	public string SmallSpriteName;

	public string InGameSpriteName;

	public string SmallInGameSpriteName;

	public ulong expire_time;

	public bool IsNew;

	public static implicit operator ClanBadgeItemInfo(ClanBadgeInfoData data)
	{
		return null;
	}
}
