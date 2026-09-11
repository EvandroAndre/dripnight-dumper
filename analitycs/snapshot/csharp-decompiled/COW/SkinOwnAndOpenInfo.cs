using System.Collections.Generic;

namespace COW;

public class SkinOwnAndOpenInfo
{
	public WeaponSkinData SkinData;

	public bool IsOpening;

	public long OpenTime;

	public bool HaveOwned;

	public bool CanExchange;

	public List<int> FeatureInThisLevel;

	public List<int> Features;

	public uint RewardItem;

	public uint RewardItem2;

	public EvoWeaponType WeaponType;

	public uint OwnedPevWeaponSkinID;
}
