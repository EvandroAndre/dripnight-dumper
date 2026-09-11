using System.Collections.Generic;

namespace COW;

public struct PreviewShowAvatarParams
{
	public uint AvatarID;

	public List<uint> ClothList;

	public uint WeaponID;

	public bool NeedShowAnim;

	public bool NeedOptionalDownload;

	public bool NeedClearUI;

	public List<uint> CheckOptionalIds;

	public uint ClothEffectItemID;

	public HashSet<uint> UnlockClothEffectItemIds;

	public bool NeedCheckClothEffectUnlock;

	public PreviewBackpackParams BackPackParams;

	public uint? SkinColor;

	public ulong AccountID;
}
